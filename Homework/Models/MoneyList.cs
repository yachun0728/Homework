using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Homework.Models
{
    public class MoneyList
    {
        [Required]
        public string Category { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:N0}")]
        [Range(1,int.MaxValue)]
        public decimal Money { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date)]
        [Remote("Index","Validate",ErrorMessage = "日期不得大於今天")]
        public DateTime Date { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [MaxLength(100)]
        public int Number { get; set; }
    }
}