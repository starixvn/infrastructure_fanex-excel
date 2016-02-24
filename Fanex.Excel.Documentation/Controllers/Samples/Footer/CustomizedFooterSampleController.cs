namespace Fanex.Grid.Documentation.Controllers.Samples.Header
{
    using Fanex.Excel;
    using Fanex.Excel.Documentation.Extensions;
    using Fanex.Excel.Documentation.Services;
    using System.Web.Mvc;

    public class CustomizedFooterSampleController : BaseSampleController
    {
        public CustomizedFooterSampleController()
        {
            this._service = new CustomizedFooterService();
        }
    }
}