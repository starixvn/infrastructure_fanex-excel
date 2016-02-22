namespace Fanex.Excel.Documentation.App_Start
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Optimization;

    /// <summary>
    /// Bundle Configuration.
    /// </summary>
    public class BundleConfig
    {
        /// <summary>
        /// Registers the bundles.
        /// </summary>
        /// <param name="bundles">The bundle collections.</param>
        public static void RegisterBundles(BundleCollection bundles)
        {
            RegisterCommonBundles(bundles);
            RegisterSitesBundles(bundles);
        }

        /// <summary>
        /// Registers common bundles.
        /// </summary>
        /// <param name="bundles">The bundle collections.</param>
        private static void RegisterCommonBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/Libraries/jQuery/jquery-{version}.js",
                        "~/Scripts/Libraries/jQuery/jquery.cookie.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/Libraries/jQuery/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/Libraries/Modernizr/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                        "~/Scripts/Libraries/Bootstrap/bootstrap.js",
                        "~/Scripts/Libraries/Respond/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/materialdesign").Include(
                        "~/Scripts/Libraries/MaterialDesign/material.js",
                        "~/Scripts/Libraries/MaterialDesign/ripples.js",
                        "~/Scripts/Libraries/NoUISlider/jquery.nouislider.js"));

            bundles.Add(new ScriptBundle("~/bundles/highlightjs").Include(
                        "~/Scripts/Libraries/CodeHighlight/shCore.js",
                        "~/Scripts/Libraries/CodeHighlight/shBrushCss.js",
                        "~/Scripts/Libraries/CodeHighlight/shBrushJScript.js",
                        "~/Scripts/Libraries/CodeHighlight/shBrushXml.js",
                        "~/Scripts/Libraries/CodeHighlight/shBrushCSharp.js"));

            bundles.Add(new ScriptBundle("~/bundles/layoutjs").Include(
                        "~/Scripts/Libraries/Namespace/namespace.js",
                        "~/Scripts/Site.js",
                        "~/Scripts/Common.js",
                        "~/Scripts/Fanex.Grid/Fanex.Pagination.js",
                        "~/Scripts/Fanex.Grid/Fanex.Grid.js"));

            bundles.Add(new ScriptBundle("~/bundles/fanexgridlanguage").IncludeDirectory("~/Scripts/Fanex.Grid/Language", "*.js"));

            bundles.Add(new LessBundle("~/Content/bootstrapcss").Include(
                        "~/Content/Bootstrap/CSS/bootstrap.css"));

            bundles.Add(new LessBundle("~/Content/materialdesigncss").Include(
                        "~/Content/MaterialDesign/CSS/material-wfont.css",
                        "~/Content/MaterialDesign/CSS/ripples.min.css",
                        "~/Content/CustomizedControls/material-design.less"));

            bundles.Add(new LessBundle("~/Content/style").Include(
                        "~/Content/style.less",
                        "~/Content/CustomizedControls/tab.less",
                        "~/Scripts/Fanex.Grid/Fanex.Pagination.css",
                        "~/Scripts/Fanex.Grid/Fanex.Grid.css"));

            bundles.Add(new LessBundle("~/Content/highlightcss").Include(
                        "~/Content/CodeHighlight/shCore.css",
                        "~/Content/CodeHighlight/shCoreDefault.css"));
        }

        /// <summary>
        /// Registers sites' bundles.
        /// </summary>
        /// <param name="bundles">The bundle collections.</param>
        private static void RegisterSitesBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Bunldes/Scripts/Sitejs").Include(
                "~/Scripts/Site.js"));
        }
    }
}