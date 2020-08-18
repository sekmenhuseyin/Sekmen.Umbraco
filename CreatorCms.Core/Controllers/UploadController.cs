using System;
using System.Web;
using System.Web.Mvc;
using Umbraco.Core.Logging;
using Umbraco.Core.Models;
using Umbraco.Web.Mvc;
// ReSharper disable Mvc.ViewNotResolved

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

            try
            {
                string mediaTypeAlias = file.ContentType.Contains("image") ? "Image" : "File";
                IMedia media = Services.MediaService.CreateMedia(file.FileName, 1054, mediaTypeAlias);
                media.SetValue("umbracoFile", file);
                Services.MediaService.Save(media);

                return Json(true, JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                Logger.Error<UploadController>("Document", e);
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
    }
}
