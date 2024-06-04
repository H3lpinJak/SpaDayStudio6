using Microsoft.AspNetCore.Mvc;

namespace SpaDay6.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Add()
        {
            return View();
        }

        public IActionResult SubmitAddUserForm()
        {
            return View();
        }
    }
}
