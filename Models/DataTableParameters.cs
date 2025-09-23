using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppWithCrudMvc.Models
{
    public class DataTableParameters
    {
        public int Draw { get; set; }
        public int Start { get; set; }
        public int Length { get; set; }
        public Search Search { get; set; }
    }

    public class Search
    {
        public string Value { get; set; }
    }

}