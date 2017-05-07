using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class Teachers
    {
        public Teachers()
        {
            this.Subjects = new List<Subject>();
        }
        public int id { get; set; }
        public string TeachersName { get; set; }
        public string TeachersPhone { get; set; }
        public string TeachersAddress { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
    }
}