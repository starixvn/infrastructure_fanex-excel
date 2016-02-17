using Demo.Extensions;
using Demo.Services;
using Fanex.Excel;
using System.Web.Mvc;

namespace Demo.Controllers
{
    public class DefaultController : Controller
    {
        private DefaultService _service;

        public DefaultController()
        {
            this._service = new DefaultService();
        }

        public ActionResult Index()
        {
            return View("~//Views//Demo//Default//Index.cshtml");
        }

        public ActionResult ExportExcel()
        {
            FanexExcel result = new FanexExcel(this._service.GenerateData());
            DemoExtension.ResponseStreamExcel(result.ToExcel2003(), "Excel");
            return new EmptyResult();
        }

        public JsonNetResult Generate()
        {
            return new JsonNetResult(this._service.GenerateData());
        }
    }
}
