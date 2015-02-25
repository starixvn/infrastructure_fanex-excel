namespace Demo.Extensions
{
    using System.Web;
    using NPOI.SS.UserModel;

    public static class DemoExtension
    {
        public static void ResponseStreamExcel(this IWorkbook workbook, string fileName)
        {
            var response = HttpContext.Current.Response;
            response.Clear();
            response.ContentType = "application/vnd.ms-excel";
            response.AddHeader("Content-Disposition", string.Format("attachment; filename={0}.xls", fileName));
            workbook.Write(response.OutputStream);
        }
    }
}