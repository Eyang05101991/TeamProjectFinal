using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeamProjectFinal.Models;

namespace TeamProjectFinal.Controllers
{
    public class MemberController : Controller
    {
        // GET: Member
        public ActionResult Subscribe()
        {
            return View();
        }

        [HttpPost]//object initilaization syntax
        //maps viewmodel to actualy database model. 
        public ActionResult Subscribe(SubscribeViewModel sub)
        {
            if (ModelState.IsValid)
            {
                Subscriber s = new Subscriber()
                {
                    FirstName = sub.FirstName,
                    Lastname = sub.Lastname,
                    EmailAddress = sub.EmailAddress
                };
                SubscribeDB.Subsribe(s);
                return RedirectToAction("Index", "Home");
            }
            //return model back to page with errors 
            return View(sub);
        }
    }
}