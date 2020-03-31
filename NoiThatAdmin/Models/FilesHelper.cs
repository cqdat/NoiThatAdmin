using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Hosting;

namespace NoiThatAdmin.Models
{
    public class FilesHelper
    {
        string DeleteURL = null;
        string DeleteType = null;
        string StorageRoot = null;
        string UrlBase = null;
        string tempPath = null;
        //ex:"~/Files/something/";
        string serverMapPath = null;

        //DataEntity db = new DataEntity();

        public FilesHelper(string DeleteURL, string DeleteType, string StorageRoot, string UrlBase, string tempPath, string serverMapPath)
        {
            this.DeleteURL = DeleteURL;
            this.DeleteType = DeleteType;
            this.StorageRoot = StorageRoot;
            this.UrlBase = UrlBase;
            this.tempPath = tempPath;
            this.serverMapPath = serverMapPath;
        }

        public void DeleteFiles(string pathToDelete)
        {

            string path = HostingEnvironment.MapPath(pathToDelete);

            System.Diagnostics.Debug.WriteLine(path);
            if (Directory.Exists(path))
            {
                DirectoryInfo di = new DirectoryInfo(path);
                foreach (FileInfo fi in di.GetFiles())
                {
                    System.IO.File.Delete(fi.FullName);
                    System.Diagnostics.Debug.WriteLine(fi.Name);
                }

                di.Delete(true);
            }
        }

        public string DeleteFile(string file)
        {
            System.Diagnostics.Debug.WriteLine("DeleteFile");
            //    var req = HttpContext.Current;
            System.Diagnostics.Debug.WriteLine(file);

            string fullPath = Path.Combine(StorageRoot, file);
            System.Diagnostics.Debug.WriteLine(fullPath);
            System.Diagnostics.Debug.WriteLine(System.IO.File.Exists(fullPath));
            string thumbPath = "/" + file.Remove(file.Length - 4, 4) + ".80x80.jpg";
            string partThumb1 = Path.Combine(StorageRoot, "thumbs");
            string partThumb2 = Path.Combine(partThumb1, file.Remove(file.Length - 4, 4) + ".80x80.jpg");

            System.Diagnostics.Debug.WriteLine(partThumb2);
            System.Diagnostics.Debug.WriteLine(System.IO.File.Exists(partThumb2));
            if (System.IO.File.Exists(fullPath))
            {
                //delete thumb 
                if (System.IO.File.Exists(partThumb2))
                {
                    System.IO.File.Delete(partThumb2);
                }
                System.IO.File.Delete(fullPath);


                //GalleryDetail g = db.GalleryDetails.Where(q => q.ImageURL.Equals(file)).First();
                //db.GalleryDetails.Remove(g);
                //db.SaveChanges();

                string succesMessage = "Ok";

                return succesMessage;
            }
            //string pathimg = "media/upload/" + file;


            string failMessage = "Error Delete";
            return failMessage;
        }
        public JsonFiles GetFileList()
        {

            var r = new List<ViewDataUploadFilesResult>();

            string fullPath = Path.Combine(StorageRoot);
            if (Directory.Exists(fullPath))
            {
                DirectoryInfo dir = new DirectoryInfo(fullPath);
                foreach (FileInfo file in dir.GetFiles())
                {
                    int SizeInt = unchecked((int)file.Length);
                    r.Add(UploadResult(file.Name, SizeInt, file.FullName));
                }

            }
            JsonFiles files = new JsonFiles(r);

            return files;
        }

        public void UploadAndShowResults(HttpContextBase ContentBase, List<ViewDataUploadFilesResult> resultList, int? productid)
        {
            var httpRequest = ContentBase.Request;
            System.Diagnostics.Debug.WriteLine(Directory.Exists(tempPath));

            string fullPath = Path.Combine(StorageRoot);
            Directory.CreateDirectory(fullPath);
            // Create new folder for thumbs
            Directory.CreateDirectory(fullPath + "/thumbs/");

            foreach (string inputTagName in httpRequest.Files)
            {

                var headers = httpRequest.Headers;

                var file = httpRequest.Files[inputTagName];
                System.Diagnostics.Debug.WriteLine(file.FileName);

                if (string.IsNullOrEmpty(headers["X-File-Name"]))
                {
                    UploadWholeFile(ContentBase, resultList, productid);
                }
                else
                {
                    UploadPartialFile(headers["X-File-Name"], ContentBase, resultList, productid);
                }
            }
        }


        private void UploadWholeFile(HttpContextBase requestContext, List<ViewDataUploadFilesResult> statuses, int? productid)
        {
            string guid = "";
            var request = requestContext.Request;
            //GalleryDetail img;
            string URLthumb = "";
            for (int i = 0; i < request.Files.Count; i++)
            {
                var file = request.Files[i];
                string pathOnServer = Path.Combine(StorageRoot);
                string fileThumb = "";


                guid = Guid.NewGuid().ToString();

                var fullPath = Path.Combine(pathOnServer, Path.GetFileName(guid + "_" + file.FileName));

                file.SaveAs(fullPath);

                //Create thumb
                string[] imageArray = file.FileName.Split('.');
                if (imageArray.Length != 0)
                {
                    string extansion = imageArray[imageArray.Length - 1].ToString().ToLower();
                    if (extansion != "jpg" && extansion != "png") //Do not create thumb if file is not an image
                    {
                    }
                    else
                    {
                        var ThumbfullPath = Path.Combine(pathOnServer, "thumbs");
                        fileThumb = guid + "_" + file.FileName.Remove(file.FileName.Length - 4, 4) + ".80x80.jpg";
                        var ThumbfullPath2 = Path.Combine(ThumbfullPath, fileThumb);
                        using (MemoryStream stream = new MemoryStream(System.IO.File.ReadAllBytes(fullPath)))
                        {
                            var thumbnail = new WebImage(stream).Resize(80, 80);
                            thumbnail.Save(ThumbfullPath2, "jpg");
                            URLthumb = ThumbfullPath2;
                        }

                    }
                }

                //img = new GalleryDetail();
                //img.GalleryID = galleryid;
                //img.Title = file.FileName;
                //img.ImageURL = guid + "_" + file.FileName;
                //img.ImageThumb = fileThumb;
                //img.Name = file.FileName;
                //img.UrlBase = fullPath;
                //img.UrlThumb = URLthumb;
                //img.Created = DateTime.Now;
                //db.ImageUploads.Add(img);

                //db.GalleryDetails.Add(img);

                //db.SaveChanges();




                statuses.Add(UploadResult(guid + "_" + file.FileName, file.ContentLength, guid + "_" + file.FileName));
            }
        }



        private void UploadPartialFile(string fileName, HttpContextBase requestContext, List<ViewDataUploadFilesResult> statuses, int? productid)
        {
            var request = requestContext.Request;
            if (request.Files.Count != 1) throw new HttpRequestValidationException("Attempt to upload chunked file containing more than one fragment per request");
            var file = request.Files[0];
            var inputStream = file.InputStream;
            string patchOnServer = Path.Combine(StorageRoot);
            var fullName = Path.Combine(patchOnServer, Path.GetFileName(file.FileName));
            var ThumbfullPath = Path.Combine(fullName, Path.GetFileName(file.FileName + ".80x80.jpg"));
            ImageHandler handler = new ImageHandler();

            var ImageBit = ImageHandler.LoadImage(fullName);
            handler.Save(ImageBit, 80, 80, 10, ThumbfullPath);
            using (var fs = new FileStream(fullName, FileMode.Append, FileAccess.Write))
            {
                var buffer = new byte[1024];

                var l = inputStream.Read(buffer, 0, 1024);
                while (l > 0)
                {
                    fs.Write(buffer, 0, l);
                    l = inputStream.Read(buffer, 0, 1024);
                }
                fs.Flush();
                fs.Close();
            }
            statuses.Add(UploadResult(file.FileName, file.ContentLength, file.FileName));
        }
        public ViewDataUploadFilesResult UploadResult(string FileName, int fileSize, string FileFullPath)
        {
            //string getType = System.Web.MimeMapping.GetMimeMapping(FileFullPath);
            string[] imageArray = FileName.Split('.');
            string getType = imageArray[imageArray.Length - 1];


            var result = new ViewDataUploadFilesResult()
            {
                name = FileName,
                size = fileSize,
                type = getType,
                url = UrlBase + FileName,
                deleteUrl = DeleteURL + FileName,
                thumbnailUrl = CheckThumb(getType, FileName),
                deleteType = DeleteType,
            };
            return result;
        }


        public string CheckThumb(string type, string FileName)
        {
            //var splited = type.Split('/');
            //if (splited.Length == 2)
            //{
            string extansion = type;//splited[1];
            if (extansion.Equals("jpeg") || extansion.Equals("jpg") || extansion.Equals("png") || extansion.Equals("gif"))
            {
                string thumbnailUrl = UrlBase + "/thumbs/" + FileName.Remove(FileName.Length - 4, 4) + ".80x80.jpg";
                return thumbnailUrl;
            }
            else
            {
                //if (extansion.Equals("octet-stream")) //Fix for exe files
                //{
                //    return "/Content/Free-file-icons/48px/exe.png";
                //}
                //if (extansion.Contains("zip")) //Fix for exe files
                //{
                //    return "/Content/Free-file-icons/48px/zip.png";
                //}

                string thumbnailUrl = "/Content/Free-file-icons/48px/" + extansion + ".png";
                return thumbnailUrl;
            }
            //}
            //else
            //{
            //    return UrlBase + "/thumbs/" + FileName + ".80x80.jpg";
            //}

        }
        /// <summary>
        /// Method Chuẩn.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="FileName"></param>
        /// <returns></returns>
        public string CheckThumb2(string type, string FileName)
        {
            var splited = type.Split('/');
            if (splited.Length == 2)
            {
                string extansion = splited[1];
                if (extansion.Equals("jpeg") || extansion.Equals("jpg") || extansion.Equals("png") || extansion.Equals("gif"))
                {
                    string thumbnailUrl = UrlBase + "/thumbs/" + FileName + ".80x80.jpg";
                    return thumbnailUrl;
                }
                else
                {
                    if (extansion.Equals("octet-stream")) //Fix for exe files
                    {
                        return "/Content/Free-file-icons/48px/exe.png";
                    }
                    if (extansion.Contains("zip")) //Fix for exe files
                    {
                        return "/Content/Free-file-icons/48px/zip.png";
                    }

                    string thumbnailUrl = "/Content/Free-file-icons/48px/" + extansion + ".png";
                    return thumbnailUrl;
                }
            }
            else
            {
                return UrlBase + "/thumbs/" + FileName + ".80x80.jpg";
            }

        }
        public List<string> FilesList()
        {

            List<string> Filess = new List<string>();
            string path = HostingEnvironment.MapPath(serverMapPath);
            System.Diagnostics.Debug.WriteLine(path);
            if (Directory.Exists(path))
            {
                DirectoryInfo di = new DirectoryInfo(path);
                foreach (FileInfo fi in di.GetFiles())
                {
                    Filess.Add(fi.Name);
                    System.Diagnostics.Debug.WriteLine(fi.Name);
                }

            }
            return Filess;
        }
    }
}