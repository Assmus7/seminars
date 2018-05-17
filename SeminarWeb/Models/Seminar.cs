using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SeminarWeb.Models
{
    public class Seminar
    {
        [Display(Name = "Тема")]
        public string Subject { get; set; }

        [Display(Name = "Описание")]
        public string Description { get; set; }

        [Display(Name = "Ведущий")]
        public string Presenter { get; set; }

        [Display(Name = "Время начала")]
        public DateTime Time { get; set; }
    }
}