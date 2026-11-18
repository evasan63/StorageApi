using Microsoft.AspNetCore.Mvc;

namespace StorageApi.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
