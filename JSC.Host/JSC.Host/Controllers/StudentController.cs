/*
* Created by: Yevgeniy A. Matveichev
* Created: 15/12/2015
* Copyright © Johnny Svarog, 2015
*/

namespace JSC.Host.Controllers
{
    using System.Web.Http;
    using System.Web.Mvc;

    public class StudentController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}