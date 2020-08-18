using System;
using System.Web;
using System.Web.Mvc;
using Umbraco.Core;
using Umbraco.Core.Logging;
using Umbraco.Core.Models;
using Umbraco.Web.Mvc;

namespace CreatorCms.Core.Controllers
{
    public class UploadController : SurfaceController
    {
        [HttpPost, ValidateAntiForgeryToken]
        public JsonResult Document(HttpPostedFileBase file)
        {
            if (file == null)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }

            bool result = false;
            try
            {
                //create media
                string mediaTypeAlias = file.ContentType.Contains("image") ? "Image" : "File";
                IMedia media = Services.MediaService.CreateMedia(file.FileName, 1054, mediaTypeAlias);
                //set file
                media.SetValue(Services.ContentTypeBaseServices, Constants.Conventions.Media.File, file.FileName, file.InputStream);
                //save
                Services.MediaService.Save(media);
                result = true;
            }
            catch (Exception e)
            {
                Logger.Error<UploadController>("Document", e);
            }

            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}
