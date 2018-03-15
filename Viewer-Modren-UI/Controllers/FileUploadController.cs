using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GroupDocs.Viewer.Handler;
using Viewer_Modren_UI.Helpers;
using GroupDocs.Viewer.Domain;
using System.Net.Http;

namespace Viewer_Modren_UI.Controllers
{
    [RoutePrefix("file/upload")]
    public class FileUploadController : Controller
    {
        [HttpPost]
        [Route("")]
        public void Get()
        {
            try
            {
                var httpRequest = HttpContext.Request;
                if (httpRequest.Files.Count > 0)
                {
                    foreach (string file in httpRequest.Files)
                    {
                        var postedFile = httpRequest.Files[file];
                        var filePath = Utils._storagePath + "\\" + postedFile.FileName;
                        postedFile.SaveAs(filePath);
                    }
                }
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }
    }
}