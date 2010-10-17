using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Xml;
using Silmoon.Utility;
using Silmoon.Configure;
using System.Windows.Forms;
using Silmoon.Security;

namespace DNSPodClient
{
    public class GBC : Silmoon.MySilmoon.SilmoonProductGBCInternat
    {
        public string Username;
        public string Password;
        public event HttpRemoteXmlResultHandler OnGetHTMLByPostCompleted;
        public IniFile Ini;
        public DNSPod _dnspod = new DNSPod();
        public CSEncrypt Encrypt = new CSEncrypt();

        public GBC()
        {
            InitProductInfo("DNSPodClient", "0.0.0.1");
            Ini = new IniFile(Application.StartupPath + "\\DNSPod.ini");
        }
        public void GetHTMLByPOST(string url, string data)
        {
            WebClient _wclit = new WebClient();
            _wclit.Headers.Add("Content-Type: application/x-www-form-urlencoded");
            _wclit.UploadStringCompleted += new UploadStringCompletedEventHandler(_wclit_UploadStringCompleted);
            _wclit.UploadStringAsync(new Uri(url), data);
            _wclit.Dispose();
        }
        void _wclit_UploadStringCompleted(object sender, UploadStringCompletedEventArgs e)
        {
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(e.Result);
            if (OnGetHTMLByPostCompleted != null) OnGetHTMLByPostCompleted(xml,e.Error);
        }
        
    }
    public delegate void HttpRemoteXmlResultHandler(XmlDocument xml,Exception error);
}