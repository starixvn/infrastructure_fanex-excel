
using Fanex.Excel;
using Fanex.Excel.Documentation.Extensions;
using Fanex.Grid.Documentation.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fanex.Grid.Documentation.Controllers
{
    public class BaseSampleController : Controller
    {
        protected ISampleService _service;

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