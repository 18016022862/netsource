using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TaskRule.DAL;

namespace TaskRule.Controllers
{
    public class ActController : Controller
    {
        //
        // GET: /Act/

        public ActionResult Index()
        {
            using (EFDBContext ef = new EFDBContext())
            {
                var m = ef.DBAct.ToList();
                return View(m);
            }
        }
    }
}
