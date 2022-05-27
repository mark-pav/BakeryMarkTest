using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace BakeryMarkTest.Controllers
{
    [Authorize(Roles = "Admin")]
    public class EmployeesController : Controller
    {
        //private readonly UserManager<IdentityUser> _userManager;
        //public UserController(UserManager<IdentityUser> userManager)
        //{
        //    _userManager = userManager;
        //}
        //public async Task<IActionResult> Index()
        //{
        //    var currentUser = await _userManager.GetUserAsync(HttpContext.User);
        //    var otherUsers = await _userManager.Users.Where(a => a.Id != currentUser.Id).ToListAsync();
        //    return View();
        //}

        //public ViewResult Details(int? id, string name)
        //{
        //    ViewBag.products = await _context.MenuItem.ToListAsync();
        //    return View(ViewBag.products);
        //}

    }
}
