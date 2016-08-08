using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace deal.ui.Controllers
{
    public class RequestController : BaseController
    {
        // GET: Request
        public ActionResult Index()
        {
            ViewBag.ServiceTypes = this.GetAll_ServiceType()
                                        .Select(i => new SelectListItem()
                                        {
                                            Text = i.ServiceTypeDescription,
                                            Value = i.ServiceTypeId.ToString()
                                        });
            return View();
        }

        public ActionResult History()
        {
            return View();
        }
    }
}