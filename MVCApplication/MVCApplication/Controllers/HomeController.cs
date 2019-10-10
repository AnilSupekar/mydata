using BusinessLayer.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApplication.Controllers
{
    public class HomeController : Controller
    {
        private IDataAccessServices _IDataAccessServices;
        public HomeController(IDataAccessServices IDataAccessServices)
        {
            this._IDataAccessServices = IDataAccessServices;
        }
        public ActionResult Index(string searchKey)
        {
            ViewBag.Keyword = searchKey;
            return View(_IDataAccessServices.getData(searchKey));
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

        public ActionResult Delete(int id)
        {
            _IDataAccessServices.deleteEmployee(id);
            return RedirectToAction("Index");
        }
    }
}