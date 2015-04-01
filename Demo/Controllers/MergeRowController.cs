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
    public class MergeRowController : Controller
    {
        private MergeRowService _service;

        public MergeRowController()
        {
            this._service = new MergeRowService();
        }

        public ActionResult Index()
        {
            return View("~//Views//Demo//MergeRow//Index.cshtml");
        }

        public ActionResult ExportExcel()
        {
            FanexExcel result = new FanexExcel(this._service.GenerateData());
            DemoExtension.ResponseStreamExcel(result.ToExcel2003(), "Excel");
            return new EmptyResult();
        }
    }
}
