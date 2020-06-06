using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProvBY.Models
{
    public class Unit
    {
        [Required(ErrorMessage = "Необходимо наименование единицы измерения")]
        public string Name { get; set; }
        public string SmallName { get; set; }
        [Required(ErrorMessage = "Необходим код ОКЕЙ")]
        public string OKEIcode { get; set; }
        public string CIcode { get; set; }

    }
}
