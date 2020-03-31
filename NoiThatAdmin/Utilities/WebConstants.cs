using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace NoiThatAdmin.Utilities
{
    public class WebConstants
    {
        public static string ImgProduct = ConfigurationManager.AppSettings["ImagesBasePath"];
        public static string ImgProductThumbs = "~/Photos/Products/_thumbs";

        public static string ImgProductShow = "Photos/Products";
        public static string ImgProductThumbsShow = "Photos/Products/_thumbs";

        public static string DatetimeFormatVI = "dd/MM/yyyy";
    }
}