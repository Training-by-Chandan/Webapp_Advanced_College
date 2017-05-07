using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class Subject
    {
        public int id { get; set; }
        public string SubjectName { get; set; }
        public int TeacherId { get; set; }
        [ForeignKey("TeacherId")]
        public virtual Teachers Teacher { get; set; }
        public bool IsActive { get; set; }

    }
}