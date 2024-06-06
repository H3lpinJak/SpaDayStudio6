using Microsoft.AspNetCore.Mvc;
using SpaDay6.Models;
using SpaDay6.ViewModels;

namespace SpaDay6.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Add()
        {
            AddUserViewModel addUserViewModel = new();
            return View(addUserViewModel);
        }

        [HttpPost]
        [Route("/user")]
        public IActionResult SubmitAddUserForm(AddUserViewModel addUserViewModel)
        {
            if (ModelState.IsValid)
            {
                if(addUserViewModel.Password == addUserViewModel.VerifyPassword)
                {
                    User newUser = new()
                {
                    Username = addUserViewModel.Username,
                    Password = addUserViewModel.Password,
                    Email = addUserViewModel.Email,
                };

                return View("Index", newUser);

                }
                else
                {
                    return View("Add", addUserViewModel);
                }
            }
            else
            {

                return View("Add", addUserViewModel);
            }

        }
    }
}
