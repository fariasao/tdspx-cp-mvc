using Microsoft.AspNetCore.Mvc;

namespace tdspx_cp_mvc.Controllers
{
    public class ClientesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
