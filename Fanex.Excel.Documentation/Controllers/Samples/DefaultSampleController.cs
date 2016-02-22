namespace Fanex.Grid.Documentation.Controllers.Samples
{
    using Fanex.Excel;
    using Fanex.Excel.Documentation.Extensions;
    using Fanex.Excel.Documentation.Services;
    using System.Web.Mvc;

    public class DefaultSampleController : Controller
    {
        private DefaultService _service;

        public DefaultSampleController()
        {
            this._service = new DefaultService();
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