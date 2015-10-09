using System.Web;
using System.Web.Optimization;

namespace Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new StyleBundle("~/css/all.css")
                .Include("~/content/font-awesome.css")
                .Include("~/content/bootstrap.css")
                .Include("~/content/sb-admin.css")
                .Include("~/content/layout.css"));


            bundles.Add(new ScriptBundle("~/scripts/all.js")
                .Include("~/scripts/jquery-{version}.js")
                .Include("~/scripts/bootstrap.js")
                .Include("~/scripts/respond.js")
                .Include("~/scripts/angular.js")
                .Include("~/app/app.js")
                .IncludeDirectory("~/app/", "*.js", true)
                );
        }
    }
}
