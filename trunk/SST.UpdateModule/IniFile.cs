using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

///  <summary>
///  ��дini�ļ�����
///  ����kernel32.dll�е�����api��WritePrivateProfileString��GetPrivateProfileString��ʵ�ֶ�ini  �ļ��Ķ�д��
///
///  INI�ļ����ı��ļ�,
///  �����ɽ�(section)���,
///  ��ÿ�������ŵı�������,
///  �����ɸ��ؼ���(key)�����Ӧ��ֵ(value)
///  
///[Section]
///Key=value
///
///  </summary>
public class IniFile
{
    ///  <summary>
    ///  ini�ļ����ƣ���·��)
    ///  </summary>
    private string filePath;

    //������дINI�ļ���API����
    [DllImport("kernel32")]
    private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

    [DllImport("kernel32")]
    private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

    public string FilePath
    {
        get { return filePath; }
        set { filePath = value; }
    }

    ///  <summary>
    ///  ��Ĺ��캯��
    ///  </summary>
    ///  <param  name="INIPath">INI�ļ���</param>  
    ///  
    public IniFile()
    {

    }

    ///  <summary>
    ///  ��Ĺ��캯��
    ///  </summary>
    ///  <param  name="INIPath">INI�ļ���</param>  
    public IniFile(string INIPath)
    {
        filePath = INIPath;
    }

    ///  <summary>
    ///   дINI�ļ�
    ///  </summary>
    ///  <param  name="Section">Section</param>
    ///  <param  name="Key">Key</param>
    ///  <param  name="value">value</param>
    public void WriteInivalue(string Section, string Key, string value)
    {
        WritePrivateProfileString(Section, Key, value, this.FilePath);

    }

    ///  <summary>
    ///    ��ȡINI�ļ�ָ������
    ///  </summary>
    ///  <param  name="Section">Section</param>
    ///  <param  name="Key">Key</param>
    ///  <returns>String</returns>  
    public string ReadInivalue(string Section, string Key)
    {
        StringBuilder temp = new StringBuilder(255);
        int i = GetPrivateProfileString(Section, Key, "", temp, 255, this.FilePath);
        return temp.ToString();

    }
}
