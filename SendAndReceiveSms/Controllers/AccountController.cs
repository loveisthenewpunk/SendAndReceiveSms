using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using SendAndReceiveSms.Data;

namespace SendAndReceiveSms.Controllers
{
    public class AccountController : Controller
    {
        private CustomerRepository _customerRepository = null;

        public AccountController()
        {
            _customerRepository = new CustomerRepository();
        }

        public ActionResult Index()
        {
            var customers = _customerRepository.GetCustomer();
            return View(customers);
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            var customer = _customerRepository.GetCustomer(id.Value);
            return View();
        }
    }
}
