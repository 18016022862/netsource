using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TaskRule.DAL;
namespace TaskRule.Controllers
{
    public class MemberController : Controller
    {
        //
        // GET: /Member/

        public ActionResult Index()
        {
            using (EFDBContext ef = new EFDBContext())
            {
                var m = ef.DBMemberBase.ToList();
                return View(m);
            }
        }

    }
}
