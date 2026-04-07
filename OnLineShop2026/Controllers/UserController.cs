using Microsoft.AspNetCore.Mvc;
using OnLineShop2026.Models;
using OnLineShop2026.Data;
namespace OnLineShop2026.Controllers
{
    public class UserController : Controller 
    {
      /*  public IActionResult UserView()
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
      */
      private UserRepository userRepository=new UserRepository();   
      public IActionResult Index()
        {
            var users=userRepository.GetAll();
            return View(users);
        }
    }
}
