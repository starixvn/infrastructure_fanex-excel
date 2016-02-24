namespace Fanex.Grid.Documentation.Controllers.Samples.CustomizedOptions
{
    using Fanex.Excel;
    using Fanex.Excel.Documentation.Extensions;
    using Fanex.Excel.Documentation.Services;
    using System.Web.Mvc;

    public class DistinctRowsSampleController : BaseSampleController
    {
        public DistinctRowsSampleController()
        {
            this._service = new DistinctRowsService();
        }
    }
}