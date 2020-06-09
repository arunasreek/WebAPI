using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using Esmart.Infrastructure.DashboardUtility.Contract;
using Esmart.Infrastructure.Resources;

namespace Esmart.Infrastructure.DashboardUtility.Classes
{
    public class DashboardUtilityService : IDashboardUtilityService
    {
        public async Task<string> GetTableauDashboardURL(string dashboardURL)
        {
            var task = Task.Run(() =>
            {
                #region TableauTicket
                ASCIIEncoding enc = new ASCIIEncoding();
                string postData = "username=" + ResourceStrings.TableauUserName + "&target_site=" + ResourceStrings.SiteName;
                byte[] data = enc.GetBytes(postData);
                string tableauTicket = string.Empty;

                try
                {
                    HttpWebRequest req = (HttpWebRequest)WebRequest.Create(ResourceStrings.TableauServerUrl + "/trusted");
                    req.Method = "POST";
                    req.ContentType = ResourceStrings.TableauContentType;
                    req.ContentLength = data.Length;

                    // you can remove if you have proper Certificate installed in Server.
                    ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback
                    (
                        delegate { return true; }
                    );

                    Stream outStream = req.GetRequestStream();
                    outStream.Write(data, 0, data.Length);
                    outStream.Close();

                    HttpWebResponse res = (HttpWebResponse)req.GetResponse();
                    StreamReader inStream = new StreamReader(res.GetResponseStream(), enc);
                    tableauTicket = inStream.ReadToEnd();
                    inStream.Close();
                }
                catch (Exception ex)
                {                   
                    tableauTicket = ResourceStrings.TableauExceptionValue;
                }
                #endregion TableauTicket

                string tableauDashboardPath = string.Empty;

                if (tableauTicket != "-1")
                {
                    tableauDashboardPath = ResourceStrings.TableauServerUrl + "/trusted/" + tableauTicket + "/" + dashboardURL + "?:embed=yes&:toolbar=yes";                  
                }
                else
                {
                    tableauDashboardPath = ResourceStrings.TableauExceptionValue;
                }
                return tableauDashboardPath;
            });            
            return await task;
        }        
    }
}
