using System.Web;
using System.Web.Optimization;

namespace roy.keijsteren
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery-ui-{version}.js",
                        "~/Scripts/plugin.js",
                        "~/Scripts/jquery-min.js",
                        "~/Scripts/scripts.js"
                        ));


            bundles.Add(new ScriptBundle("~/bundles/devblog").Include(
                        "~/Scripts/syntax/shCore.css",
                        "~/Scripts/syntax/shThemeDefault.css",
                        "~/Content/font-awesome/css/font-awesome.css"
                ));

            bundles.Add(new ScriptBundle("~/bundles/devblogJS").Include(
                  "~/Scripts/syntax/shBrushCss.js",
                  //"~/Scripts/syntax/ShBrushJscript.js",
                  //"~/Scripts/syntax/shBrushPerl.js",
                  //"~/Scripts/syntax/shBrushPhp.js",
                  //"~/Scripts/syntax/shBrushPlain.js",
                  //"~/Scripts/syntax/shBrushPython.js",
                  //"~/Scripts/syntax/shBrushRuby.js",
                  //"~/Scripts/syntax/shBrushSql.js",
                  //"~/Scripts/syntax/shBrushVb.js",
                  //"~/Scripts/syntax/shBrushXml.js",
                  "~/Scripts/syntax/shCore.js"
                  ));


            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/plugin.css",
                      "~/Content/style.css",
                      "~/Content/site.css"));
        }
    }
}
