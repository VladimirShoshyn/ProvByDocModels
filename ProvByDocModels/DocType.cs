using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProvBY.Models
{
    public enum DocType
    {
        [Display(Name = "Счет на оплату. РБ.")]
        Schet = 1,
        [Display(Name = "Товарная накладная. РБ.")]
        TN = 2,
        [Display(Name = "Товарно-транспортная накладная. РБ.")]
        TTN = 3,
        [Display(Name = "Акт выполненных работ. РБ.")]
        Act = 4
    }
}
