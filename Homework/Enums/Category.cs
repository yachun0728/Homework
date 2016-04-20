using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Homework.Enums
{
    public enum Category
    {
        [Description("支出")]
        支出 = 0,

        [Description("收入")]
        收入
    }
}