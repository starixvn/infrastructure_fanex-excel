namespace Fanex.Grid.Documentation.Controllers.Samples.CustomizedOptions
{
    using Fanex.Excel;
    using Fanex.Excel.Documentation.Extensions;
    using Fanex.Excel.Documentation.Services;
    using System.Web.Mvc;

    public class FrozenColumnSampleController : Controller
    {
        private FrozenColumnService _service;

        public FrozenColumnSampleController()
        {
            this._service = new FrozenColumnService();
        }

        public JsonNetResult Generate()
        {
            return new JsonNetResult(this._service.GenerateData());
        }

        public ActionResult ExportExcel()
        {
            FanexExcel result = new FanexExcel(this._service.GenerateData());
            DemoExtension.ResponseStreamExcel(result.ToExcel2003(), "Excel");
            return new EmptyResult();
        }
    }
}