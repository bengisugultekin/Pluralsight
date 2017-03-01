using eManager.Domain;
using System.Web.Mvc;

namespace eManager.Web.Controllers
{
    //public class HomeController : Controller
    //{
    //    public string SayHello()
    //    {
    //        return "hello world";
    //    }


    //}
    public class HomeController : Controller
    {
        private IDepartmentDataSource _db;

        public HomeController(IDepartmentDataSource db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            var allDepartments = _db.Departments;

            return View(allDepartments);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}