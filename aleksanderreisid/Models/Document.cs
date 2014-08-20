using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aleksanderreisid.Models
{
    public class Document
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public int PageID { get; set; }
        public int Place { get; set; }
    }
}