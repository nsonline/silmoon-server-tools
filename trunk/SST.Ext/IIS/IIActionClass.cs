using System;
using System.Collections.Generic;
using System.Text;
using Silmoon.Windows.Server.IIS;
using Silmoon.Security;
using Silmoon.Windows;
using Silmoon.IO.SmFile;

namespace SST.Ext.IIS
{
    internal class IISActionClass
    {
        IISManager _iisMgr;
        public IISActionClass(IISManager iisMgr)
        {
            _iisMgr = iisMgr;
        }
        public DeleteSiteResult DeleteWebSite(string siteID)
        {
            DeleteSiteResult result = new DeleteSiteResult();
            result.SystemUserExist = false;

            if (!_iisMgr.IsExistWebSite(siteID))
                result.Success = false;
            else
            {
                try
                {
                    WebSiteInfo wsinfo = _iisMgr.GetWebsiteInfo(siteID);
                    result.WebSiteName = wsinfo.SiteName;
                    SAM sam = new SAM();
                    if (wsinfo.AccessUser.IdentityString.IndexOf("IUSR_SMIISMgr") != -1 && sam.ExistIdentity(wsinfo.AccessUser.IdentityString))
                    {
                        try
                        {
                            result.SystemUsername = wsinfo.AccessUser.IdentityString;
                            result.SystemUserExist = true;
                            ACL.RemoveAccessRule(wsinfo.DirectoryPath, wsinfo.AccessUser.IdentityString);
                            sam.DeleteUserOrGroup(wsinfo.AccessUser.IdentityString);
                        }
                        catch (Exception ex) { result.Error = ex; }
                    }
                    _iisMgr.DeleteWebSite(siteID);
                    result.Success = true;
                }
                catch (Exception ex) { result.Error = ex; result.Success = true; }
            }
            return result;
        }
    }
    public struct DeleteSiteResult
    {
        public bool SystemUserExist;
        public string SystemUsername;
        public bool Success;
        public string WebSiteName;
        public Exception Error;
    }
}
