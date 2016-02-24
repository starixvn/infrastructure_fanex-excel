namespace Fanex.Grid.Documentation.Controllers
{
    using Fanex.Excel.Documentation.Extensions;
    using System.Web.Mvc;

    interface ISampleController
    {
        JsonNetResult Generate();

        ActionResult ExportExcel();
    }
}
