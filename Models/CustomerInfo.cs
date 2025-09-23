using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppWithCrudMvc.Models
{
    public class CustomerInfo
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string DOB { get; set; }
        public string CustomerAddress { get; set; }
        public string PhoneNo { get; set; }
        public string EmailAddress { get; set; }
    }
}