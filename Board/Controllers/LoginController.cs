using Board.Models;
using Microsoft.AspNetCore.Mvc;

namespace Board.Controllers
{
    public class LoginController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}