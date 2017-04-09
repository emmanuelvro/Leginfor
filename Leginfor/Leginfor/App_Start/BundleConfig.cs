using System.Web;
using System.Web.Optimization;

namespace Leginfor
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                        "~/Scripts/wow.min.js",
                        "~/Scripts/jquery.scrollUp.min.js",
                        "~/Scripts/owl.carousel.min.js",
                        "~/Scripts/moment-with-locales.js",
                        "~/Scripts/bootstrap-datetimepicker.js",
                        "~/Scripts/*.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-1.11.3.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // preparado para la producción y podrá utilizar la herramienta de compilación disponible en http://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-2.8.3.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/bootstrap-datetimepicker.css",
                      "~/Content/font-awesome.min.css",
                      "~/Content/owl.carousel.css",
                      "~/Content/owl.theme.css",
                      "~/Content/owl.transitions.css",
                      "~/Content/jquery-ui.css",
                      "~/Content/meanmenu.min.css",
                      "~/Content/normalize.css",
                      "~/Content/main.css",
                      "~/Content/style.css",
                      "~/Content/responsive.css"));

            bundles.Add(new StyleBundle("~/Content/slider/css").Include(
                      "~/Content/custom-slider/css/*.css"));
            bundles.Add(new ScriptBundle("~/Content/slider/js").Include(
                      "~/Content/custom-slider/js/*.js",
                      "~/Content/custom-slider/*.js"));

            bundles.Add(new StyleBundle("~/Content/products/css").Include(
                      "~/Content/carr-products/css/turbotabs.css?ver=all",
                      "~/Content/carr-products/css/owl.carousel.css?ver=all",
                      "~/Content/carr-products/css/wc-box-public.css?ver=all",
                      "~/Content/carr-products/css/woocommerce-layout.css?ver=2.6.4",
                      "~/Content/carr-products/css/woocommerce-smallscreen.css?ver=2.6.4",
                      "~/Content/carr-products/css/woocommerce.css?ver=2.6.4",
                      "~/Content/carr-products/css/style.css?ver=2.5.3"));

            bundles.Add(new ScriptBundle("~/Content/products/js").Include(
                      "~/Content/carr-products/js/jquery.prettyPhoto.js?ver=all",
                      "~/Content/carr-products/js/jquery.prettyPhoto.init.js?ver=all",
                      "~/Content/carr-products/js/owl.carousel.min.js?ver=all",
                      "~/Content/carr-products/js/turbotabs.js?ver=all",
                      "~/Content/carr-products/js/wc-box-public.js?ver=all"));
        }
    }
}
