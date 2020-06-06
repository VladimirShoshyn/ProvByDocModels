using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProvBY.Models
{
    public class Contract
    {
        public string Name { get; set; }        
        [Required(ErrorMessage = "Необходим номер контракта")]
        public string Number { get; set; }
        [Required(ErrorMessage = "Необходима дата контракта")]
        public DateTime Date { get; set; }        
    }
}
