using System;
using Homework.Enums;

namespace Homework.Models
{
    public class MoneyList
    {
        public Category Category { get; set; }
        public decimal Money { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public int Number { get; set; }
    }
}