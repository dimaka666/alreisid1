using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aleksanderreisid.Models
{
    public class Content
    {
        public int ID { get; set; }
        public string Label { get; set; }
        public string Text { get; set; }
        public int Page { get; set; }
        public bool Published { get; set; }
        public string MenuOptionName { get; set; }
    }
}