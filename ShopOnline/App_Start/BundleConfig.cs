using System.Web;
using System.Web.Optimization;

namespace ShopOnline
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/Layout/bootstrap.min.js",
                      "~/Scripts/Layout/jquery.scrollUp.min.js",
                      "~/Scripts/Layout/jquery.prettyPhoto.js",
                      "~/Scripts/Layout/main.js",
                      "~/Scripts/respond.js"));
            bundles.Add(new ScriptBundle("~/bundles/slider").Include(
                      "~/Scripts/Layout/~/Scripts/jquery-1.10.2.js",
                      "~/Scripts/Layout/~/Scripts/Slider/jssor.slider.mini.js.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/Layout/bootstrap.min.css",
                      "~/Content/Layout/font-awesome.min.css",
                      "~/Content/Layout/prettyPhoto.css",
                      "~/Content/Layout/animate.css",
                      "~/Content/Layout/main.css",
                      "~/Content/Layout/responsive.css",
                      "~/Content/nn-styles.css"));
        }
    }
}
