using AppWithCrudMvc.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace AppWithCrudMvc.Controllers
{
    public class CrudOprtsController : Controller
    {
        // GET: CrudOprts
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CustomersInfo()
        {
            return View();
        }

        [HttpPost]
        public JsonResult getCustomersInfo()
        {
            //string json;

            //using (var reader = new StreamReader(Request.InputStream))
            //{
            //    json = reader.ReadToEnd();
            //}

            //var request = JsonConvert.DeserializeObject<DataTableParameters>(json);

            //string draw = request.Draw.ToString();
            //string start = request.Start.ToString();
            //string length = request.Length.ToString();
            //string search = request.Search.ToString();

            string draw = Request.Form["Draw"].ToLower();
            string start = Request.Form["Start"].ToLower();
            string length = Request.Form["Length"].ToLower();
            string search = Request.Form["Search"];

            List<CustomerInfo> customers = new List<CustomerInfo>();

            CustomerInfo customerDetails = new CustomerInfo();

            customerDetails.Id = 1;
            customerDetails.CustomerName = "SATHYA";
            customerDetails.DOB = "24/05/1997";
            customerDetails.CustomerAddress = "402-IND";
            customerDetails.PhoneNo = "123456789";
            customers.Add(customerDetails);

            var response = JsonConvert.SerializeObject(customers);

            var dataTableRes = new
            {
                draw = 1,
                data = customers,
                recordsTotal = customers.Count(),
                recordsFiltered = customers.Count(),
            };

            return Json(dataTableRes, JsonRequestBehavior.AllowGet);
        }
    }
}