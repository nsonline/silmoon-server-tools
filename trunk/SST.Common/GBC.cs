using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Collections;
using Silmoon.Service;
using System.Reflection;
using System.Reflection.Emit;
using System.IO;
using System.Net.Sockets;
using System.Diagnostics;
using System.Threading;
using Microsoft.Win32;
using Silmoon.Security;
using SST.Common;
using Silmoon.Reflection;
using Silmoon.Configure;

public class GBC : Silmoon.MySilmoon.SilmoonProductGBCInternat
{
    public PathInfo Pathinfo;
    private string _remoteAppVersion = "0";
    IniFile _ini;
    IniFile _rini;

    public EncryptDocument Encrydocuments = new EncryptDocument();

    public ServiceControl ServiceCtrl = new ServiceControl();
    public Silmoon.IO.FileWatcher FileWatch = new Silmoon.IO.FileWatcher(true, true, false);
    private System.Timers.Timer _t = new System.Timers.Timer();
    public PlusManager plusManager;

    public event EventHandler EverySecondEvent;
    public event EventHandler OnAppStart;
    public event EventHandler OnAppExit;
    public ServerInfo serverInfo;
    public RegistryRW Reg;
    public ConfigRW Cfg;

    public Logger LoggerObj;
    public Form MainForm;
    public NotifyIcon Tray;
    public ToolStripStatusLabel StatusLabel;

    public IniFile ConfigIni
    {
        get { return _ini; }
        set { _ini = value; }
    }
    public IniFile RConfigIni
    {
        get { return _rini; }
        set { _rini = value; }
    }
    public string GetAppVersion
    {
        get
        {
            if (ReleaseVersion == "0")
                ReleaseVersion = _ini.ReadInivalue("Version", "AppVersion");
            return ReleaseVersion;
        }
    }
    public string GetRomoteAppVersion
    {
        get
        {
            if (_remoteAppVersion == "0")
                _remoteAppVersion = _rini.ReadInivalue("Version", "AppVersion");
            return _remoteAppVersion;
        }
    }

    public GBC()
    {
        try
        { InitClass(); }
        catch (Exception e) { MessageBox.Show("错误：\r\n\r\n" + e.ToString(), "加载GBC抛出异常"); }
    }

    private void InitClass()
    {
        InitProductInfo("silmoonservertool", 100, "8.0");
        Pathinfo = new PathInfo(this);
        LoggerObj = new Logger(this);
        _ini = new IniFile(Pathinfo.ConfigPath);
        _rini = new IniFile(Pathinfo.DLConfigPath);
        serverInfo = new ServerInfo();
        _t.Elapsed += new System.Timers.ElapsedEventHandler(_t_Elapsed);
        Reg = new RegistryRW(this);
        Cfg = new ConfigRW(this);
        plusManager = new PlusManager(this);
        InitConfigs();

        _t.Interval = 1000;
        _t.Start();
        onStartApp();
        ValidateProgram();
    }

    private void ValidateProgram()
    {
        Thread _t = new Thread(_th_validate);
        _t.IsBackground = true;
        _t.Start();
    }
    private void _th_validate()
    {
        WebClient _w = new WebClient();
        try
        {
            Thread.Sleep(3000);
            string s = _w.DownloadString(Pathinfo.RemoteBase + "Validate.ashx?version=" + GetAppVersion);
            if (s == "200") { LoggerObj.WriteLogLine("与SST服务器验证完成！"); }
            else if (s == "400")
            {
                LoggerObj.WriteLogLine("与SST服务器验证错误！");
                LoggerObj.WriteLogLine("服务器控制退出！！！");
                MessageBox.Show(((IWin32Window)MainForm), "服务器控制客户端退出，因为服务器拒绝运行公共库！");
                ExitApp();
            }
        }
        catch { LoggerObj.WriteLogLine("与SST服务器连接错误！"); }
        _w.Dispose();
    }

    private void InitConfigs()
    {
            DownloadRemoteConfigFile();
    }

    #region 全局事件
    void _t_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
    {
        LoggerObj.WrtieLogFile();
        if (EverySecondEvent != null) EverySecondEvent(this, System.EventArgs.Empty);
    }
    void onStartApp()
    {
        try
        { if (OnAppStart != null) OnAppStart(this, EventArgs.Empty); }
        catch { }
        
        Reg.WriteKey("OpenCount", Convert.ToInt32(Reg.ReadKey("OpenCount")) + 1, RegistryValueKind.DWord);
        Reg.WriteKey("Status", "Running", RegistryValueKind.String);

    }
    void OnExitApp()
    {
        if (OnAppExit != null) OnAppExit(this, EventArgs.Empty);
        LoggerObj.WriteLogLine("程序退出...\r\n\r\n");
        LoggerObj.WrtieLogFile();
        try { Directory.Delete(Pathinfo.SysTempDir, true); }
        catch { }
        Reg.WriteKey("Status", "Stoped", RegistryValueKind.String);
        File.Delete(Pathinfo.DLConfigPath);
    }
    #endregion

    public void DownloadRemoteConfigFile()
    {
        try
        {
            WebClient _webClient = new WebClient();
            _webClient.DownloadFile(Pathinfo.RemoteConfig, Pathinfo.DLConfigPath);
            _webClient.Dispose();
            Reg.WriteKey("FailOpenRemoteConfig", 0, RegistryValueKind.DWord);
        }
        catch (Exception ex)
        {
            Reg.WriteKey("FailOpenRemoteConfig", Convert.ToString(Convert.ToInt32(Reg.ReadKey("FailOpenRemoteConfig")) + 1), RegistryValueKind.DWord);

            MessageBox.Show("加载的时候有一个错误。\r\n\r\n" + ex.ToString());
            MessageBox.Show("远程 配置不可用，使用本地配置作为临时可用的配置");
            File.Copy(Pathinfo.ConfigPath, Pathinfo.DLConfigPath, true);
        }
    }
    public void ExitApp()
    {
        OnExitApp();
        Application.ExitThread();
        Application.Exit();
    }
    public void ResetApp()
    {
        ExitApp();
        Process.Start(Application.ExecutablePath, "login");
    }

    public void WriteException(string content)
    {
        if (!Directory.Exists(Pathinfo.ReportDir)) Directory.CreateDirectory(Pathinfo.ReportDir);
        File.WriteAllText(Pathinfo.ReportDir + "Exception-" + DateTime.Now.ToString("yyyyMMddHHmmddss") + ".log", content);
    }
    public void TryOpenProcess(string filePath)
    {
        try
        { Process.Start(filePath); }
        catch { MessageBox.Show("打开\r\n" + filePath + "\r\n失败", "Open Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
    }
    public void ProtectRunAsClass(string message, string exceptionContent)
    {
        ProtectRunAsClass(message);
        WriteException(exceptionContent);
    }
    public void ProtectRunAsClass(string message)
    {
        MessageBox.Show("实在抱歉，我们的程序在受保护的运行代码段出现一个异常：\r\n\r\n    " + message + "\r\n\r\n如果你确定异常不来自己您的操作问题，请报告开发人员！谢谢。", "已处理的异常", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
    public void PopErrorMessage(string message)
    {
        MessageBox.Show("执行中返回一个异常：\r\n\r\n    " + message + "\r\n\r\n如果你确定异常不来自己您的操作问题，请报告开发人员！谢谢。", "已处理的异常", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
public class ObjectClass
{
    public ObjectClass() { }
    public string ObjectName;
    public ISSTPlus OBJ;
}
public class PathInfo : MarshalByRefObject
{
    public PathInfo(GBC g)
    {
        RemoteConfig += "?specid=" + g.Encrydocuments.ReadString("SpecialID");
    }
    public string ConfigPath = Application.StartupPath + "\\Config.ini";
    public string SystemConfigPath = Application.StartupPath + "\\System.ini";
    public string LogPath = Application.StartupPath + "\\Log.log";
    public string DLConfigPath = Application.StartupPath + "\\~config.ini";
    private string reportDir = Application.StartupPath + "\\Report\\";
    public string ReportDir
    {
        get
        {
            if (!Directory.Exists(reportDir)) Directory.CreateDirectory(reportDir);
            return reportDir;
        }
    }
    private string resourceDir = Application.StartupPath + "\\Resource\\";
    public string ResourceDir
    {
        get
        {
            if (!Directory.Exists(resourceDir)) Directory.CreateDirectory(resourceDir);
            return resourceDir;
        }
    }
    private string tempDir = Application.StartupPath + "\\Temp\\";
    public string TempDir
    {
        get
        {
            if (!Directory.Exists(tempDir)) Directory.CreateDirectory(tempDir);
            return tempDir;
        }
    }
    private string systempDir = "C:\\WINDOWS\\Temp\\sst\\";
    public string SysTempDir
    {
        get
        {
            if (!Directory.Exists(systempDir)) Directory.CreateDirectory(systempDir);
            return systempDir;
        }
    }
    public string RemoteBase = "http://client.silmoon.com/Silmoonservertools/";
    public string RemoteResourceList = "http://client.silmoon.com/SilmoonServertools/Resource/DownloadResource.txt";
    public string RemoteConfig = "http://client.silmoon.com/update/SST/Config.txt";
    public string RemoteSSTFile = "http://client.silmoon.com/SilmoonServertools/SST_File/";
    public string RemoteGuideList = "http://client.silmoon.com/silmoonservertools/guidefile/guidelist.txt";
    public string PlusConfig
    {
        get { return Application.StartupPath + "\\Plugin.txt"; }
    }
}
public class RegistryRW : MarshalByRefObject
{
    string _rootRegPath = "Software\\SST";
    RegistryKey _rootKey;
    GBC _g;
    public RegistryRW(GBC g)
    {
        _g = g;
        try
        {
            _rootKey = Registry.CurrentUser.OpenSubKey(_rootRegPath, true);
            if (_rootKey == null)
            {
                RegistryKey _createKey = Registry.CurrentUser.OpenSubKey("Software", true);
                _createKey.CreateSubKey("SST");
                _createKey.Close();
                _rootKey = Registry.CurrentUser.OpenSubKey(_rootRegPath, true);
            }
        }
        catch (Exception e) { MessageBox.Show("错误：\r\n\r\n" + e.ToString(), "加载RegistryRW抛出异常"); }
    }
    public object ReadKey(string keyName)
    {
        try
        { return _rootKey.GetValue(keyName); }
        catch { return null; }
    }
    public void WriteKey(string keyName, object value,RegistryValueKind _type)
    {
        try { _rootKey.SetValue(keyName, value, _type); }
        catch (Exception ex) { _g.ProtectRunAsClass(ex.ToString(), ex.ToString()); }
    }
    ~RegistryRW()
    {
        _rootKey.Close();
    }
}
public class ConfigRW : MarshalByRefObject
{
    GBC _g;
    public ConfigRW(GBC g)
    {
        _g = g;
    }
    public void WriteConfig(string name, string value)
    {
        _g.ConfigIni.WriteInivalue("Config", name, value);
    }
    public string  ReadConfig(string name)
    {
        return _g.ConfigIni.ReadInivalue("Config", name);
    }
}
public class ServerInfo : MarshalByRefObject
{
    IPAddress _wanIP;
    public IPAddress WanIP
    {
        get
        {
            if (_wanIP == null)
            {
                try
                {
                    WebClient _wclit = new WebClient();
                    string _ip = _wclit.DownloadString("https://encrypted.silmoon.com/system/ip/c");
                    _wclit.Dispose();
                    _wanIP = IPAddress.Parse(_ip);
                }
                catch
                {
                    _wanIP = Dns.GetHostAddresses(Dns.GetHostName())[0];
                }

            }
            return _wanIP;
        }
    }

    IPAddress[] _localIP;
    public IPAddress[] LocalIP
    {
        get
        {
            if (_localIP == null)
                _localIP = Dns.GetHostAddresses(Dns.GetHostName());
            return _localIP;
        }
    }

    IPAddress _gatewayIP;
    public IPAddress GatewayIP
    {
        get
        {
            if (_gatewayIP == null)
                _gatewayIP = Silmoon.Net.NetworkInformation.NetworkBaseInformations.GetDefaultGateWay();
            return _gatewayIP;
        }
    }

    string _gatewayMAC;
    public string GatewayMAC
    {
        get
        {
            if (_gatewayMAC == null)
                _gatewayMAC = Silmoon.Net.NetworkInformation.NetworkBaseInformations.GetMacAddress(GatewayIP, "-");
            return _gatewayMAC;
        }
    }
}
public class EncryptDocument : MarshalByRefObject
{
    IniFile _ini;
    public EncryptDocument()
    {
        _ini = new IniFile(Application.StartupPath + "\\APP.SMD");
    }
    public string ReadString(string key)
    {
        return EncryptString.DiscryptSilmoonBinary(_ini.ReadInivalue("Encrypt", EncryptString.EncryptSilmoonBinary(key)));
    }
    public void WriteString(string key, string value)
    {
        _ini.WriteInivalue("Encrypt", EncryptString.EncryptSilmoonBinary(key), EncryptString.EncryptSilmoonBinary(value));
    }
}
public class PlusManager
{
    public ArrayList ObjectList = new ArrayList();
    GBC _g;
    public PlusManager(GBC g)
    {
        _g = g;
    }
    public void LoadDLL(string filename)
    {
        AppDomain ad = AppDomain.CurrentDomain;

    }
    public void AddPlus(ISSTPlus obj)
    {
        ObjectClass oc = new ObjectClass();
        oc.OBJ = obj;
        oc.ObjectName = obj.PlusName;
        ObjectList.Add(oc);
        oc.OBJ.InitPlus(_g);
        _g.LoggerObj.WriteLogLine("(PLS)加载插件:" + oc.ObjectName);
    }
    public ISSTPlus GetPlusObject(string objName)
    {
        ISSTPlus obj = null;
        for (int i = 0; i < ObjectList.Count; i++)
        {
            ObjectClass oc = ((ObjectClass)ObjectList[i]);
            if (oc.ObjectName == objName)
            {
                obj = oc.OBJ;
                break;
            }
        }
        return obj;
    }
    public bool RemovePlus(string objName)
    {
        for (int i = 0; i < ObjectList.Count; i++)
        {
            ObjectClass oc = ((ObjectClass)ObjectList[i]);
            if (oc.ObjectName == objName)
            {
                if (((ISSTPlus)oc.OBJ).RemovePlus())
                {
                    ObjectList.Remove(ObjectList[i]);
                    _g.LoggerObj.WriteLogLine("(PLS)移除插件:" + oc.ObjectName);
                    return true;
                }
                else
                {
                    _g.LoggerObj.WriteLogLine("(PLS)插件:" + oc.ObjectName + "移除失败");
                    return false;
                }
            }
        }
        return false;
    }
    public void ConfigPlus(string objName)
    {
        for (int i = 0; i < ObjectList.Count; i++)
        {
            ObjectClass oc = ((ObjectClass)ObjectList[i]);
            if (oc.ObjectName == objName)
            {
                ((ISSTPlus)oc.OBJ).ShowPlus();
            }
        }
    }
}