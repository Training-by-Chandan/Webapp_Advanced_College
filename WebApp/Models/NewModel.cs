using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class NewModel
    {
        public int id { get; set; }
        public List<string> str { get; set; }
        public List<NameClass> NM { get; set; }
    }

    public class NameClass
    {
        public int id { get; set; }
        public string Name { get; set; }
    }
}