namespace Fanex.Excel.Documentation.Controllers
{
    using System.Collections.Generic;
    using System.Web.Mvc;
    using Fanex.Excel.Documentation.Models;

    public class SamplesController : Controller
    {
        private const string SamplePageUrl = "~/Samples/SamplePage?sampleName=";

        private static List<MenuItem> _sampleMenuList = new List<MenuItem>
            {
                new MenuItem { Name = "Default Options", Url = SamplePageUrl, ViewName = "DefaultOption" },
                new MenuItem 
                {
                    Name = "Customized Options",
                    ViewName = "CustomizedOptions",
                    SubMenus = new List<MenuItem>
                    {
                        new MenuItem { Name = "Frozen Columns", Url = SamplePageUrl, ViewName = "FrozenColumns" },
                        new MenuItem { Name = "Multiple Languages", Url = SamplePageUrl, ViewName = "MultipleLanguages" },
                        new MenuItem { Name = "Custom Height", Url = SamplePageUrl, ViewName = "CustomHeight" },
                        new MenuItem { Name = "Distinct Rows", Url = SamplePageUrl, ViewName = "DistinctRows" },
                        new MenuItem { Name = "Highlight Rows", Url = SamplePageUrl, ViewName = "HighlightRows" },
                        new MenuItem { Name = "Show Number Column", Url = SamplePageUrl, ViewName = "ShowNumberColumn" },
                        new MenuItem { Name = "Margin Right", Url = SamplePageUrl, ViewName = "MarginRight" },
                        new MenuItem { Name = "Hide Background Scroller", Url = SamplePageUrl, ViewName = "HideBackgroundScroller" },
                        new MenuItem { Name = "Fixed Width/Height", Url = SamplePageUrl, ViewName = "FixedWidthHeight" },
                        new MenuItem { Name = "Min Width/Height", Url = SamplePageUrl, ViewName = "MinWidthHeight" },
                        new MenuItem { Name = "Scroller Width", Url = SamplePageUrl, ViewName = "ScrollerWidth" },
                        new MenuItem { Name = "Highlight Frozen Width", Url = SamplePageUrl, ViewName = "HighlightFrozenWidth" }
                    }
                },
                new MenuItem 
                {
                    Name = "Customized Content",
                    ViewName = "CustomizedContent",
                    SubMenus = new List<MenuItem>
                    {
                        new MenuItem { Name = "Customized Column", Url = SamplePageUrl, ViewName = "CustomizedColumn" },
                        new MenuItem { Name = "Customized Row", Url = SamplePageUrl, ViewName = "CustomizedRow" },
                        new MenuItem { Name = "Customized Cell", Url = SamplePageUrl, ViewName = "CustomizedCell" },
                        new MenuItem { Name = "Custom Rendering", Url = SamplePageUrl, ViewName = "CustomRendering" },
                        new MenuItem { Name = "Append Rows Realtime", Url = SamplePageUrl, ViewName = "AppendRowsRealtime" }
                    }
                },
                new MenuItem 
                {
                    Name = "Header",
                    ViewName = "Header",
                    SubMenus = new List<MenuItem>
                    {
                        new MenuItem { Name = "Grouping", Url = SamplePageUrl, ViewName = "Grouping" },
                        new MenuItem { Name = "Customized", Url = SamplePageUrl, ViewName = "Customized" }
                    }
                },
                new MenuItem 
                {
                    Name = "Title",
                    ViewName = "Title",
                    SubMenus = new List<MenuItem>
                    {
                        new MenuItem { Name = "Title Text", Url = SamplePageUrl, ViewName = "TitleText" },
                        new MenuItem { Name = "Suppoted Buttons", Url = SamplePageUrl, ViewName = "SuppotedButtons" },
                        new MenuItem { Name = "Customized Buttons", Url = SamplePageUrl, ViewName = "CustomizedButtons" }
                    }
                },
                new MenuItem 
                {
                    Name = "Footer",
                    ViewName = "Footer",
                    SubMenus = new List<MenuItem>
                    {
                        new MenuItem { Name = "Show", Url = SamplePageUrl, ViewName = "Show" },
                        new MenuItem { Name = "Grouping", Url = SamplePageUrl, ViewName = "Grouping" },
                        new MenuItem { Name = "Customized", Url = SamplePageUrl, ViewName = "Customized" }
                    }
                },
                new MenuItem 
                {
                    Name = "Pager",
                    ViewName = "Pager",
                    SubMenus = new List<MenuItem>
                    {
                        new MenuItem { Name = "Default Pager", Url = SamplePageUrl, ViewName = "DefaultPager" },
                        new MenuItem { Name = "Pager With Footer", Url = SamplePageUrl, ViewName = "PagerWithFooter" },
                        new MenuItem { Name = "Server Side Pager", Url = SamplePageUrl, ViewName = "ServerSidePager" },
                        new MenuItem { Name = "Pager Events", Url = SamplePageUrl, ViewName = "PagerEvents" }
                    }
                },
                new MenuItem 
                {
                    Name = "Sort",
                    ViewName = "Sort",
                    SubMenus = new List<MenuItem>
                    {
                        new MenuItem { Name = "Default Client Side", Url = SamplePageUrl, ViewName = "DefaultClientSide" },
                        new MenuItem { Name = "Customized Client Side", Url = SamplePageUrl, ViewName = "CustomizedClientSide" },
                        new MenuItem { Name = "Sort Events", Url = SamplePageUrl, ViewName = "SortEvents" },
                        new MenuItem { Name = "Server Side", Url = SamplePageUrl, ViewName = "ServerSide" },
                        new MenuItem { Name = "Initial Sort Icon", Url = SamplePageUrl, ViewName = "InitialSortIcon" }
                    }
                },
                new MenuItem 
                {
                    Name = "Show/Hide Columns",
                    ViewName = "ShowHideColumns",
                    SubMenus = new List<MenuItem>
                    {
                        new MenuItem { Name = "Default Render", Url = SamplePageUrl, ViewName = "DefaultRender" },
                        new MenuItem { Name = "Real time Show/Hide", Url = SamplePageUrl, ViewName = "RealtimeShowHide" }
                    }
                },
                new MenuItem 
                {
                    Name = "Merging",
                    ViewName = "Merging",
                    SubMenus = new List<MenuItem>
                    {
                        new MenuItem { Name = "Columns", Url = SamplePageUrl, ViewName = "Columns" },
                        new MenuItem { Name = "Rows", Url = SamplePageUrl, ViewName = "Rows" },
                        new MenuItem { Name = "Both Columns and Rows", Url = SamplePageUrl, ViewName = "BothColumnsAndRows" },
                        new MenuItem { Name = "Correct Rows Height", Url = SamplePageUrl, ViewName = "CorrectRowsHeight" },
                    }
                },
                new MenuItem 
                {
                    Name = "Tree",
                    ViewName = "Tree",
                    SubMenus = new List<MenuItem>
                    {
                        new MenuItem { Name = "Default", Url = SamplePageUrl, ViewName = "Default" },
                        new MenuItem { Name = "Customized", Url = SamplePageUrl, ViewName = "Customized" }
                    }
                },
                new MenuItem { Name = "Text Truncate", Url = SamplePageUrl, ViewName = "TextTruncate" },
                new MenuItem
                {
                    Name = "Formatters",
                    ViewName = "Formatters",
                    SubMenus = new List<MenuItem>
                    {
                        new MenuItem { Name = "Date Time", Url = SamplePageUrl, ViewName = "DateTime" },
                        new MenuItem { Name = "Number", Url = SamplePageUrl, ViewName = "Number" }
                    }
                },
                new MenuItem
                {
                    Name = "Auto Resize Columns",
                    ViewName = "AutoResizeColumns",
                    SubMenus = new List<MenuItem>
                    {
                        new MenuItem { Name = "Default", Url = SamplePageUrl, ViewName = "Default" },
                        new MenuItem { Name = "Full Width", Url = SamplePageUrl, ViewName = "FullWidth" }
                    }
                },
                new MenuItem { Name = "Render Multiple Grids", Url = SamplePageUrl, ViewName = "RenderMultipleGrids" },
                new MenuItem
                {
                    Name = "Virtual Rendering",
                    ViewName = "VirtualRendering",
                    SubMenus = new List<MenuItem>
                    {
                        new MenuItem { Name = "Default", Url = SamplePageUrl, ViewName = "Default" },
                        new MenuItem { Name = "Customized", Url = SamplePageUrl, ViewName = "Customized" }
                    }
                }
            };

        public SamplesController()
        {
            ViewBag.TabName = "samples";
            ViewBag.IsShowInIframe = true;
        }

        // GET: Samples
        public ActionResult Index(string sampleName)
        {
            ViewBag.MenuList = _sampleMenuList;

            return View(model: sampleName);
        }

        public ActionResult SamplePage(string sampleName)
        {
            return View(string.Format("~/Views/Samples/{0}.cshtml", sampleName));
        }
    }
}