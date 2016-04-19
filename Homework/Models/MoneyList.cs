using System;

namespace Homework.Models
{
    public class MoneyList
    {
        public string Category { get; set; }
        public decimal Money { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public int Number { get; set; }
    }
}