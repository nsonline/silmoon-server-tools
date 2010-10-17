using System;
using System.Collections.Generic;
using System.Text;

namespace SST.Common
{
    public interface ISSTPlus
    {
        string PlusName
        {
            get;
        }
        void InitPlus(GBC g);
        void ShowPlus();
        bool StopPlus();
        bool RemovePlus();
    }
    public interface ISSTPlus1
    {
        string PlusName
        {
            get;
        }
        void InitPlus(GBC g);
        void ShowPlus();
        bool StopPlus();
        bool RemovePlus();
    }
}
