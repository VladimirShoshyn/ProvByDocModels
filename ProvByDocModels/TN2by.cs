using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProvBY.Models
{
    public class TN2by
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
        public string ShipAllow { get; set; }
        public string ShipMaker { get; set; }
        public string CargoTaker { get; set; }
        public string CargoTook { get; set; }
        public AuthLetter AuthLetter { get; set; }
        public List<NameValue> Codes { get; set; }
        [Required]
        public List<Tn2Table> Table { get; set; }
        
    }
    public class Tn2Table
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
        public bool IsTare { get; set; }
    }
}
