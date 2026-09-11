using Microsoft.AspNetCore.Mvc;
using MVCDemoD03.Context;

namespace MVCDemoD03.Controllers
{
    public class DepartmentController : Controller
    {
        /*------------------------------------------------------------------*/
        // Context
        private readonly AppDbContext db = new AppDbContext();
        /*------------------------------------------------------------------*/
        public IActionResult Index()
        {
            var departments = db.Departments.ToList();
            return View(departments);
        }
        /*------------------------------------------------------------------*/
    }
}