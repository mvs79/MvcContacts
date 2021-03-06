﻿using System.Web;
using System.Web.Optimization;

namespace MvcContacts
{
    public class BundleConfig
    {
        // Weitere Informationen zu Bundling finden Sie unter "http://go.microsoft.com/fwlink/?LinkId=301862"
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/mvc").Include(
                         "~/Scripts/jquery-{version}.js",
                         "~/Scripts/jquery.validate*",
                         "~/Scripts/mvc.js",
                         "~/Scripts/modernizr-*"

                        ));
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Verwenden Sie die Entwicklungsversion von Modernizr zum Entwickeln und Erweitern Ihrer Kenntnisse. Wenn Sie dann
            // für die Produktion bereit sind, verwenden Sie das Buildtool unter "http://modernizr.com", um nur die benötigten Tests auszuwählen.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                       "~/Content/themes/base/core.css",
                       "~/Content/themes/base/resizable.css",
                       "~/Content/themes/base/selectable.css",
                       "~/Content/themes/base/accordion.css",
                       "~/Content/themes/base/autocomplete.css",
                       "~/Content/themes/base/button.css",
                       "~/Content/themes/base/dialog.css",
                       "~/Content/themes/base/slider.css",
                       "~/Content/themes/base/tabs.css",
                       "~/Content/themes/base/datepicker.css",
                       "~/Content/themes/base/progressbar.css",
                       "~/Content/themes/base/theme.css"));
        }
    }
    
}
