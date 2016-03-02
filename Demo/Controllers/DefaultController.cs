using Demo.Extensions;
using Demo.Services;
using Fanex.Excel;
using Newtonsoft.Json;
using System.Collections.Generic;
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

        public ActionResult Generate()
        {
            var gridOptions = this._service.GenerateData();
            var writer = new JsonTextWriter(HttpContext.Response.Output);
            var serializer = JsonSerializer.Create();
            serializer.Serialize(writer, gridOptions);
            writer.Flush();
            return null;
        }

        //public JsonNetResult Generate()
        //{
        //    var gridOptions = this._service.GenerateData();
        //    gridOptions.BodyRows[0].Columns[0].CustomAttributes = new Dictionary<string, string>(){
        //        { "UserName", "Agent01" },
        //        { "CustID", "100945"}
        //    };

        //    return new JsonNetResult(gridOptions);
        //}
    }
}
