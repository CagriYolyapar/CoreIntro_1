using Microsoft.AspNetCore.Mvc;

namespace CoreIntro_1.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult CategoryList()
        {
            return View();
        }
    }
}
