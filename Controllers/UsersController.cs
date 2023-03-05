using Microsoft.AspNetCore.Mvc;
using KCliffordMVCAPP.Models;

namespace KCliffordMVCAPP.Controllers
{
    public class UsersController : Controller
    {
        UsersContext uc = new();
        public IActionResult KCView()
        {
            return View(uc.KcliffordTables.ToList());
        }
    }
}
