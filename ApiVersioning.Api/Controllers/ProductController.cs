using System.Web.Mvc;
using ApiVersioning.Services;

namespace ApiVersioning.Api.Controllers
{
    public class ProductController : Controller
    {
        [HttpGet]
        [Route("ajax/product")]
        public JsonResult Index()
        {
            IProductService productService = new ProductService();
            var viewModel = productService.GetProduct();
            return Json(viewModel, JsonRequestBehavior.AllowGet);
        }
    }
}
