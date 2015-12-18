using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace JSC.Host.Controllers
{
    using JSC.Host.DomainModels.EntityModels;

    [Authorize]
    public class HomeController : Controller
    {
        private void TestConnectionToPostgreSql()
        {
            var status = new JSP_DicStatuses { Name_RU = "Принято", Name_EN = "Accepted", DateStart = DateTime.Now, };
            using (var context = new JscHostContainer())
            {
                context.DIC_EventSources.Add(status);
                context.SaveChanges();
            }
        }

        public ActionResult Index()
        {
            this.TestConnectionToPostgreSql();
            return this.View(new Student());
        }
    }
}

