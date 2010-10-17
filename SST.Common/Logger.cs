using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;

public class Logger : MarshalByRefObject
{
    GBC _g;
    public event LogEventHander OnLogRecording;
    ArrayList _logArr = new ArrayList();
    ArrayList _stringLogArr = new ArrayList();

    public ArrayList StringLogArray
    {
        get { return _stringLogArr; }
        set { _stringLogArr = value; }
    }
    string LogPath;

    public Logger(GBC g)
    {
        _g = g;
        LogPath = _g.Pathinfo.LogPath;
    }

    public void WriteLogLine(string s)
    {
        _logArr.Add("[" + DateTime.Now + "]:" + s + "\r\n");
        _stringLogArr.Add("[" + DateTime.Now + "]:" + s + "\r\n");

        if (OnLogRecording != null) OnLogRecording((string[])_stringLogArr.ToArray(typeof(string)), s, 10);
    }
    public void WriteLogLine(string s, int logLevel)
    {
        _logArr.Add("[" + DateTime.Now + "]:" + s + "\r\n");
        _stringLogArr.Add("[" + DateTime.Now + "]:" + s + "\r\n");

        if (OnLogRecording != null) OnLogRecording((string[])_stringLogArr.ToArray(typeof(string)), s, logLevel);
    }
    public void WrtieLogFile()
    {
        if (_logArr != null)
        {
            if (_logArr.Count != 0)
            {
                string[] sArr = (string[])_logArr.ToArray(typeof(string));
                try
                {
                    foreach (string s in sArr)
                        File.AppendAllText(_g.Pathinfo.LogPath, s);
                }
                catch
                {
                    try
                    {
                        foreach (string s in sArr)
                            File.AppendAllText(_g.Pathinfo.LogPath, s);
                    }
                    catch { }
                }
                _logArr.Clear();
            }
        }
    }
}
public delegate void LogEventHander(string[] logArr,string newLine,int logLevel);