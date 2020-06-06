using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProvBY.Models
{
    public class Product
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public Unit Unit { get; set; }
        public List<NameValue> Codes { get; set; }
        [Required]
        public bool IsService { get; set; }        
        public Guid ProvBYCode { get; set; }
    }
}
