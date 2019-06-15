using Microsoft.AspNetCore.Mvc;

namespace MissingSystemTextJsonResultExecutor.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
            => Json(new { message = "Test" });
    }
}
