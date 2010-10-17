using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Silmoon;
using System.Threading;
using Silmoon.Reflection;
using SST.Common;
using System.IO;

namespace SST.DLLManager
{
    public class DLLManager : SST.Common.ISSTPlus
    {
        GBC _g;
        private readonly string _plusName = "DLLManager";
        public DLLManager()
        {
        }
        public void InitPlus(GBC g)
        {
            _g = g;

            Thread _th = new Thread(InitInThread);
            _th.IsBackground = true;
            _th.Start();
        }
        void InitInThread()
        {
            ISSTPlus obj = null;
            try
            {
                obj = (ISSTPlus)new SST.Plus.NetworkMessage();
                _g.plusManager.AddPlus(obj);
            }
            catch (Exception e)
            {
                _g.LoggerObj.WriteLogLine("(DLL)���ز��" + obj.PlusName + "ʧ��");
                _g.ProtectRunAsClass("���ز������:" + obj.PlusName + "\r\n\r\n    " + "��Ϣ:\r\n        " + e.ToString());
            }
        }
        #region ISSTPlus ��Ա

        public bool StopPlus()
        {
            return false;
        }

        public void ShowPlus()
        {
            new PlusWindow(_g);
        }

        public bool RemovePlus()
        {
            return false;
        }

        public string PlusName
        {
            get { return _plusName; }
        }

        #endregion
    }
}
