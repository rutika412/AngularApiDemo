using System.Web;
using System.Web.Optimization;

namespace TrainingWebsite
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            //bundles.Add(new ScriptBundle("~/bundle/angularapp").
            //    IncludeDirectory("~/Scripts/lib", "*.js").
            //    Include("~/Scripts/TrainingHouse.js").
            //    IncludeDirectory("~/Scripts/Controllers", "*.js").
            //    IncludeDirectory("~/Scripts/Factories", "*.js"));

            BundleTable.EnableOptimizations = false;
        }
    }
}
