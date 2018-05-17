using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SeminarWeb.Models
{
    public class NewSeminars
    {
        [Required]                  //поле обязательно должно быть
        [StringLength(20, MinimumLength = 3)]
        [RegularExpression(@"(\S)+", ErrorMessage = "white space is not allowedr")]
        [Display(Name = "Тема семинара")]
        public string SeminarsTheme { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3)]
        [RegularExpression(@"(\S)+", ErrorMessage = "white space is not allowedr")]
        [Display(Name = "Описание")]
        public string SeminarsInside { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3)]
        [RegularExpression(@"(\S)+", ErrorMessage = "white space is not allowedr")]
        [Display(Name = "Ведущий")]
        public string SeminarsTeachName { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3)]
        [RegularExpression(@"(\S)+", ErrorMessage = "white space is not allowedr")]
        [Display(Name = "Время начала")]
        public DateTime SeminarsTimeStart { get; set; }

        public int SeminarId { get; set; }
    }

}