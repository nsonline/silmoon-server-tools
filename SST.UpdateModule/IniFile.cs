using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading;

///  <summary>
///  读写ini文件的类
///  调用kernel32.dll中的两个api：WritePrivateProfileString，GetPrivateProfileString来实现对ini  文件的读写。
///
///  INI文件是文本文件,
///  由若干节(section)组成,
///  在每个带括号的标题下面,
///  是若干个关键词(key)及其对应的值(value)
///  
///[Section]
///Key=value
///
///  </summary>
public class IniFile
{
    ///  <summary>
    ///  ini文件名称（带路径)
    ///  </summary>
    private string filePath;

    //声明读写INI文件的API函数
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
    ///  类的构造函数
    ///  </summary>
    ///  <param  name="INIPath">INI文件名</param>  
    ///  
    public IniFile()
    {

    }

    ///  <summary>
    ///  类的构造函数
    ///  </summary>
    ///  <param  name="INIPath">INI文件名</param>  
    public IniFile(string INIPath)
    {
        filePath = INIPath;
    }

    ///  <summary>
    ///   写INI文件
    ///  </summary>
    ///  <param  name="Section">Section</param>
    ///  <param  name="Key">Key</param>
    ///  <param  name="value">value</param>
    public void WriteInivalue(string Section, string Key, string value)
    {
        WritePrivateProfileString(Section, Key, value, this.FilePath);

    }

    ///  <summary>
    ///    读取INI文件指定部分
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
