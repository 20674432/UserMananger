using Microsoft.AspNetCore.Mvc;
using UserCRUD.Models;

namespace UserCRUD.Controllers
{
    public class LoginController : Controller
    {
        public readonly ApplicationDbContext _context;

        public LoginController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            
            var admin = _context.AdminTable.FirstOrDefault(u => u.Username == username);

            if (admin != null && admin.Admin_password == password) 
            {
                return RedirectToAction("Index", "Home");
            }

            ViewBag.Message = "Invalid password or username.";
            return View();
        }
    }
}
