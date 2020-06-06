using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Serialization;

namespace ProvBY.Models
{    
    public class Actby
    {        
            [Required]
            public string Number { get; set; }
            [Required]
            public DateTime Date { get; set; }
            [Required]
            public Company Seller { get; set; }            
            [Required]
            public Company Buyer { get; set; }
            [Required]
            public Currency Currency { get; set; }
            public Contract Contract { get; set; }
            public string Coment { get; set; }
            public string Basis { get; set; }
            public List<NameValue> Codes { get; set; }
            [Required]
            public List<ActTable> Table { get; set; }
    }
    public class ActTable
    {
        public int RowNumber { get; set; }
        public List<NameValue> Codes { get; set; }
        [Required]
        public Product Product { get; set; }
        [Required]
        public Unit Unit { get; set; }
        [Required]
        public decimal Quantity { get; set; }
        [Required]
        public decimal Price { get; set; }
        public decimal? VAT { get; set; }
        [Required]
        public decimal VATAmount { get; set; }
        [Required]
        public decimal Amount { get; set; }
        public string Coment { get; set; }
        public Contract Contract { get; set; }
    }
}
