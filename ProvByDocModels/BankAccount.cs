using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProvBY.Models
{
    public class BankAccount
    {
        [Required]
        public string AccountNumber { get; set; }
        [Required]
        public string BankNumber { get; set; }
        public string BankAccountNumber { get; set; }
        [Required]
        public string BankCountry3Code { get; set; }
        public string BankName { get; set; }
        public string BankAdress { get; set; }
        public string BankPhone { get; set; }
    }
}
