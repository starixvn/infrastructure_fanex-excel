namespace Fanex.Grid.Documentation.Controllers.Samples.Header
{
    using Fanex.Excel;
    using Fanex.Excel.Documentation.Extensions;
    using Fanex.Excel.Documentation.Services;
    using System.Web.Mvc;

    public class ShowFooterSampleController : BaseSampleController
    {
        public ShowFooterSampleController()
        {
            this._service = new ShowFooterService();
        }
    }
}