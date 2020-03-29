using System.Web;
using System.Web.Optimization;

namespace NoiThatAdmin
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                      //"~/assets/js/jquery-1.10.2.min.js",
                      //"~/assets/js/jqueryui-1.10.3.min.js",
                      //"~/assets/js/bootstrap.min.js",
                      "~/assets/js/enquire.js",
                      "~/assets/js/jquery.cookie.js",
                      "~/assets/js/jquery.nicescroll.min.js",
                      "~/assets/plugins/codeprettifier/prettify.js",
                      "~/assets/plugins/easypiechart/jquery.easypiechart.min.js",
                      "~/assets/plugins/sparklines/jquery.sparklines.min.js",
                      "~/assets/plugins/form-toggle/toggle.min.js",
                      "~/assets/plugins/fullcalendar/fullcalendar.min.js",
                      "~/assets/plugins/form-daterangepicker/daterangepicker.min.js",
                      "~/assets/plugins/form-daterangepicker/moment.min.js",
                      "~/assets/plugins/charts-flot/jquery.flot.min.js",
                      "~/assets/plugins/charts-flot/jquery.flot.resize.min.js",
                      "~/assets/plugins/charts-flot/jquery.flot.orderBars.min.js",
                      "~/assets/plugins/pulsate/jQuery.pulsate.min.js",
                      "~/assets/demo/demo-index.js",
                      "~/assets/js/placeholdr.js",
                      "~/assets/js/application.js",
                      "~/assets/demo/demo.js"
                      ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/assets/css/styles.minc726.css",
                      "~/assets/demo/variations/default.css",
                      "~/assets/plugins/fullcalendar/fullcalendar.css",
                      "~/assets/plugins/form-markdown/css/bootstrap-markdown.min.css",
                      "~/assets/plugins/codeprettifier/prettify.css",
                      "~/assets/plugins/form-toggle/toggles.css"));

            bundles.Add(new StyleBundle("~/Content/bundleupload").Include(
                "~/Content/jQuery.FileUpload/css/jquery.fileupload.css",
               "~/Content/jQuery.FileUpload/css/jquery.fileupload-ui.css",
               "~/Content/blueimp-gallery2/css/blueimp-gallery.css",
                 "~/Content/blueimp-gallery2/css/blueimp-gallery-video.css",
                   "~/Content/blueimp-gallery2/css/blueimp-gallery-indicator.css"
               ));

            bundles.Add(new ScriptBundle("~/bundles/bundleupload").Include(
                     //<!-- The Templates plugin is included to render the upload/download listings -->
                     "~/Scripts/jQuery.FileUpload/vendor/jquery.ui.widget.js",
                       "~/Scripts/jQuery.FileUpload/tmpl.min.js",
                    //<!-- The Load Image plugin is included for the preview images and image resizing functionality -->
                    "~/Scripts/jQuery.FileUpload/load-image.all.min.js",
                    //<!-- The Canvas to Blob plugin is included for image resizing functionality -->
                    "~/Scripts/jQuery.FileUpload/canvas-to-blob.min.js",
                    //"~/Scripts/file-upload/jquery.blueimp-gallery.min.js",
                    //<!-- The Iframe Transport is required for browsers without support for XHR file uploads -->
                    "~/Scripts/jQuery.FileUpload/jquery.iframe-transport.js",
                    //<!-- The basic File Upload plugin -->
                    "~/Scripts/jQuery.FileUpload/jquery.fileupload.js",
                    //<!-- The File Upload processing plugin -->
                    "~/Scripts/jQuery.FileUpload/jquery.fileupload-process.js",
                    //<!-- The File Upload image preview & resize plugin -->
                    "~/Scripts/jQuery.FileUpload/jquery.fileupload-image.js",
                    //<!-- The File Upload audio preview plugin -->
                    "~/Scripts/jQuery.FileUpload/jquery.fileupload-audio.js",
                    //<!-- The File Upload video preview plugin -->
                    "~/Scripts/jQuery.FileUpload/jquery.fileupload-video.js",
                    //<!-- The File Upload validation plugin -->
                    "~/Scripts/jQuery.FileUpload/jquery.fileupload-validate.js",
                    //!-- The File Upload user interface plugin -->
                    "~/Scripts/jQuery.FileUpload/jquery.fileupload-ui.js",
                    //Blueimp Gallery 2 
                    "~/Scripts/blueimp-gallery2/js/blueimp-gallery.js",
                    "~/Scripts/blueimp-gallery2/js/blueimp-gallery-video.js",
                    "~/Scripts/blueimp-gallery2/js/blueimp-gallery-indicator.js",
                    "~/Scripts/blueimp-gallery2/js/jquery.blueimp-gallery.js"

                ));


            bundles.Add(new ScriptBundle("~/bundles/Blueimp-Gallerry2").Include(//Blueimp Gallery 2 
                                        "~/Scripts/blueimp-gallery2/js/blueimp-gallery.js",
                                        "~/Scripts/blueimp-gallery2/js/blueimp-gallery-video.js",
                                        "~/Scripts/blueimp-gallery2/js/blueimp-gallery-indicator.js",
                                        "~/Scripts/blueimp-gallery2/js/jquery.blueimp-gallery.js"));

        }
    }
}
