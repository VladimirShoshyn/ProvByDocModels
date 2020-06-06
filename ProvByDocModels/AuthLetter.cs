using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProvBY.Models
{
    public class AuthLetter
    {
        [Required]
        public string Number { get; set; }
        public DateTime Date { get; set; }
        public DateTime? ExpDate { get; set; }
        public string Fio { get; set; }
        public string Doc { get; set; }
        public string Letter { get; set; }
    }
}
