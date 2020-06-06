using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProvBY.Models
{
    public class TTN1by
    {
        [Required(ErrorMessage = "Необходим номер документа")]
        public string Number { get; set; }
        [Required(ErrorMessage = "Необходима дата документа")]
        public DateTime Date { get; set; }        
        public Company CargoSender { get; set; }        
        public Company CargoRecipient { get; set; }
        [Required(ErrorMessage = "Необходим грузополучатель ShipingCustomer")]
        public Company ShipingCustomer { get; set; }
        [Required(ErrorMessage = "Необходим продавец Seller")]
        public Company Seller { get; set; }
        [Required(ErrorMessage = "Необходим покупатель Buyer")]
        public Company Buyer { get; set; }        
        public Company VehicleOwner { get; set; }
        [Required(ErrorMessage = "Необходима валюта Currency")]
        public Currency Currency { get; set; }
        public Contract Contract { get; set; }
        public string Vehicle { get; set; }
        public string VehicleDriver { get; set; }
        public string VehicleAddon { get; set; }
        public string VehicleSheet { get; set; }
        public string LoadPlace { get; set; }
        public string UnloadPlace { get; set; }
        public string ChangeUnload { get; set; }
        public DateTime LoadArrival { get; set; }
        public DateTime LoadDeparture { get; set; }
        public DateTime UnloadArrival { get; set; }
        public DateTime UnloadDeparture { get; set; }
        public string LoadMethod { get; set; }
        public string UnloadMethod { get; set; }
        public string Coment { get; set; }
        public string Basis { get; set; }
        public string ShipAllow { get; set; }
        public string ShipMaker { get; set; }
        public string CargoTaker { get; set; }
        public string CargoTook { get; set; }
        public string SealNumber { get; set; }        
        public AuthLetter AuthLetter { get; set; }
        public List<NameValue> Codes { get; set; }
        [Required(ErrorMessage = "Необходима табличная часть Table")]
        public List<TTN1Table> Table { get; set; }
        public List<TTNPackListItem> PackList { get; set; }
    }
    public class TTN1Table
    {
        public int RowNumber { get; set; }
        public List<NameValue> Codes { get; set; }
        [Required(ErrorMessage = "Необходима продукция Table/Product")]
        public Product Product { get; set; }
        [Required(ErrorMessage = "Необходима единица измерения Table/Unit")]
        public Unit Unit { get; set; }
        [Required(ErrorMessage = "Необходимо количество Table/Quantity")]
        public decimal Quantity { get; set; }
        [Required(ErrorMessage = "Необходима цена Table/Price")]
        public decimal Price { get; set; }
        public decimal? VAT { get; set; }
        [Required(ErrorMessage = "Необходима сумма НДС Table/VATAmount")]
        public decimal VATAmount { get; set; }
        [Required(ErrorMessage = "Необходима сумма (всего с НДС) Table/Amount")]
        public decimal Amount { get; set; }
        public string Coment { get; set; }
        public Contract Contract { get; set; }
        public bool IsTare { get; set; }
        public int InPlaceQty { get; set; }
        public decimal Brutto { get; set; }
    }

    public class TTNPackListItem
    {
        public int RowNumber { get; set; }
        public List<NameValue> Codes { get; set; }
        public string PackName { get; set; }
        public Product Product { get; set; }
        public Unit Unit { get; set; }
        public decimal Qty { get; set; }
        public decimal QtyInOnePlace { get; set; }
    }
}
