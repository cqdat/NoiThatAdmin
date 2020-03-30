using NoiThatAdmin.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;

namespace NoiThatAdmin.Controllers
{
    public class ProductImageController : Controller
    {
        FilesHelper h;
        string tempPath = "~/Upload/";
        string serverMapPath = "~/Media/Upload/";

        private string StorageRoot
        {
            get { return Path.Combine(HostingEnvironment.MapPath(serverMapPath)); }
        }

        private string UrlBase = "/Media/Upload/";
        String DeleteURL = "/ProductImage/DeleteFile/?file=";
        String DeleteType = "GET";
        public ProductImageController()
        {
            h = new FilesHelper(DeleteURL, DeleteType, StorageRoot, UrlBase, tempPath, serverMapPath);
        }

        // GET: ProductImage
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Upload()
        {
            int galleryid = 0;
            try
            {
                galleryid = Convert.ToInt32(Session["galleryid"]);
            }
            catch
            {
                galleryid = 1;
            }
            var resultList = new List<ViewDataUploadFilesResult>();

            var CurrentContext = HttpContext;

            h.UploadAndShowResults(CurrentContext, resultList, galleryid);

            JsonFiles files = new JsonFiles(resultList);



            bool isEmpty = !resultList.Any();
            if (isEmpty)
            {
                return Json("Error");
            }
            else
            {
                return Json(files);
            }
        }
        public JsonResult GetFileList()
        {
            var list = h.GetFileList();
            return Json(list, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public JsonResult DeleteFile(string file)
        {
            h.DeleteFile(file);
            return Json("OK", JsonRequestBehavior.AllowGet);
        }
    }
}