using Microsoft.AspNetCore.Mvc;
using RegisterAndLogin.Models;

namespace RegisterAndLogin.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProcessLogin(UserModel userModel)
        {
            if (userModel.UserName == "marvyn" && userModel.Password == "bigbucks")
            {
                return View("LoginSuccess", userModel);
            } else
            {
                return View("LoginFailure", userModel);
            }
            
        }
    }
}
