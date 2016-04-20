using System;
using System.ComponentModel.DataAnnotations;
using Homework.Enums;

namespace Homework.Models
{
    public class MoneyList
    {
        public string Category { get; set; }

        [DisplayFormat(DataFormatString = "{0:N0}")]
        public decimal Money { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public int Number { get; set; }
        public Category CategoryEnum { get; set; }
    }
}