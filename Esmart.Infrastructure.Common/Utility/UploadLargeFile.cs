using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Esmart.Infrastructure.Common.Utility
{
    public class UploadLargeFile
    {
        public bool UploadFile(string folderPath)
        {
            foreach (string file in HttpContext.Current.Request.Files)
            {
                var FileDataContent = HttpContext.Current.Request.Files[file];
                if (FileDataContent != null && FileDataContent.ContentLength > 0)
                {
                    //  take the input stream, and save it to a temp folder using the original file.part name posted
                    var stream = FileDataContent.InputStream;
                    var fileName = Path.GetFileName(FileDataContent.FileName);

                    //change path
                   // var UploadPath = HttpContext.Current.Server.MapPath("~/OrganisationLogo");
                   // Directory.CreateDirectory(UploadPath);
                   // string path = Path.Combine(folderPath);
                    try
                    {
                        if (System.IO.File.Exists(folderPath))
                            System.IO.File.Delete(folderPath);
                        using (var fileStream = System.IO.File.Create(folderPath))
                        {
                            stream.CopyTo(fileStream);
                        }
                        // Once the file part is saved, see if we have enough to merge it
                        MergeFileUtility UT = new MergeFileUtility();
                        UT.MergeFile(folderPath);
                    }
                    catch (IOException ex)
                    {
                        return false;
                    }
                }
            }
            return true;




        }
    }
}
