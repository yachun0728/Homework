using System;
using System.ComponentModel.DataAnnotations;

namespace Homework.Areas.Backend.Models
{
    public class SearchList
    {
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
    }
}