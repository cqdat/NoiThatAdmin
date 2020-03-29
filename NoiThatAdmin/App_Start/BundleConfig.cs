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
                      "~/assets/plugins/form-toggle/toggles.css",
                      "~/Content/Site.css"));
        }
    }
}
