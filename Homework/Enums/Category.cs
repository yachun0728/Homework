using System.ComponentModel.DataAnnotations;

namespace Homework.Enums
{
    public enum Category
    {
        [Display(Name = "支出")]
        Expend = 0,

        [Display(Name = "收入")]
        Include
    }
}