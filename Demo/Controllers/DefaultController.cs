using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fanex.Excel.Models;
using Fanex.Excel;
using Demo.Extensions;
using Demo.Services;

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
            return View("~//Views//Demo//Default.cshtml");
        }

        public ActionResult ExportExcel()
        {
            FanexExcel result = new FanexExcel(this._service.GenerateData());
            DemoExtension.ResponseStreamExcel(result.ToExcel2003(), "Excel");
            return new EmptyResult();
        }
    }
}
