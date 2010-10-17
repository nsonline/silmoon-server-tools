using System;
using System.Collections.Generic;
using System.Text;

namespace SST.Client.Classes
{
    class OnShownRun
    {
        public GBC _g;
        public OnShownRun(GBC g)
        {
            _g = g;

            new RunOnceClass(_g);

            if ((int)_g.Reg.ReadKey("OpenCount") == 1)
                new Window.FirstWelcome(_g);

            if ((string)_g.Reg.ReadKey("Version") != _g.GetAppVersion)
            {
                new SST.Client.Window.NewVersionForm();
                _g.Reg.WriteKey("Version", _g.GetAppVersion, Microsoft.Win32.RegistryValueKind.String);
            }
        }
    }
}
