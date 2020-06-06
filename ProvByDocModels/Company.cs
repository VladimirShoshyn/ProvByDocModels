using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProvBY.Models
{
    public class Company
    {
        [Required(ErrorMessage = "Необходимо наименование компании")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Необходим регистрационный номер компании")]
        public string RegNumber { get; set; }
        public string AddRegNumber { get; set; }
        public string Addres { get; set; }
        public string Phone { get; set; }
        [Required(ErrorMessage = "Необходима страна регистрации (например BLR) компании")]
        public string RegCountry3Code { get; set; }
        public string WebSite { get; set; }
        public string Email { get; set; }
    }
}
