using System.Web;
using System.Web.Optimization;

namespace MvcApp.App_Start
{
    public class BundleConfig
    {

        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
           "~/Assets/js/jquery.min.js",
           "~/assets/js/jquery.datatables.min.js"
           ));
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
          "~/Assets/js/bootstrap.min.js",
          "~/assets/js/bootstrap-dialog.min.js",
          "~/assets/js/datatables.bootstrap.min.js",
          "~/assets/js/run_prettify.min.js"
          ));
            bundles.Add(new ScriptBundle("~/bundles/main").Include(
           "~/assets/js/main.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Assets/css/bootstrap-dialog.min.css",
                      "~/Assets/css/dataTables.bootstrap4.min.css",
                      "~/Assets/css/style.css",
                      "~/Assets/css/bootstrap-theme.min.css",
                      "~/Assets/css/bootstrap.min.css"
                      ));



      }
    }
}