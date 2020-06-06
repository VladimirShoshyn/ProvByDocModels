using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProvBY.Models
{
    public class Currency
    {
        [Required(ErrorMessage = "Необходим строковой код валюты")]
        public string StrCode { get; set; }
        [Required(ErrorMessage = "Необходим цифровой код валюты")]
        public int DigitCode { get; set; }
        public string Name { get; set; }
    }
}
