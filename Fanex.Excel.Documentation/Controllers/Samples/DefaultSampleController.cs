namespace Fanex.Grid.Documentation.Controllers.Samples
{
    using Fanex.Excel;
    using Fanex.Excel.Documentation.Extensions;
    using Fanex.Excel.Documentation.Services;
    using System.Web.Mvc;

    public class DefaultSampleController : BaseSampleController
    {
        public DefaultSampleController()
        {
            this._service = new DefaultService();
        }
    }
}