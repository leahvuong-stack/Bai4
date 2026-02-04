using Microsoft.AspNetCore.Mvc;

namespace Danh_sách_công_việc.Controllers
{
    public class TodoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
