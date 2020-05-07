using System.Web;
using System.Web.Optimization;

namespace DiagramApi
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {


            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));


            bundles.Add(new StyleBundle("~/bundles/apexchartcss").Include(
                      "~/Content/apexchart.css"));

            bundles.Add(new ScriptBundle("~/bundles/apexchart").Include(
                      "~/Scripts/apexchart.js"));

            bundles.Add(new ScriptBundle("~/bundles/vueapexchart").Include(
                      "~/Scripts/vueapexchart.js"));

            bundles.Add(new ScriptBundle("~/bundles/axios").Include(
                      "~/Scripts/axios.js"));

        }
    }
}
