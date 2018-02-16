using System.Web.Mvc;

namespace ApiVersioning.Api.Controllers
{
    public class ProductController : Controller
    {
        [HttpGet]
        [Route("ajax/product")]
        public JsonResult Index()
        {
            return Json(new {success = true}, JsonRequestBehavior.AllowGet);
        }
    }
}
