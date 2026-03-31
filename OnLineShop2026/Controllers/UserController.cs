using Microsoft.AspNetCore.Mvc;
using OnLineShop2026.Models;

namespace OnLineShop2026.Controllers
{
    public class UserController : Controller
    {
        public IActionResult UserView()
        {
            User user = new User
            (
              Guid.NewGuid(),
               "AMINA",
              "2007",
               "example@gmail.com",
                "/images/img_cake.jpg"
            );
            return View(user);
        }

    }
}
