using System;
using System.ComponentModel.DataAnnotations;

namespace TradeJournalAPI.Models
{
    public class TradeJournal
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Symbol { get; set; }
        
        public DateTime? Entry_Date_1 { get; set; }
        public decimal? Entry_Price_1 { get; set; }
        public int? Quantity_1 { get; set; }
        
        public string Broker_Name { get; set; }
        public string Strategy { get; set; }
        
        public DateTime? Entry_Date_2 { get; set; }
        public decimal? Entry_Price_2 { get; set; }
        public int? Quantity_2 { get; set; }
        
        public DateTime? Entry_Date_3 { get; set; }
        public decimal? Entry_Price_3 { get; set; }
        public int? Quantity_3 { get; set; }
        
        public decimal? Stoploss { get; set; }
        
        public DateTime? Exit_Date_1 { get; set; }
        public decimal? Exit_Price_1 { get; set; }
        public int? Exit_Quantity_1 { get; set; }
        
        public DateTime? Exit_Date_2 { get; set; }
        public decimal? Exit_Price_2 { get; set; }
        public int? Exit_Quantity_2 { get; set; }
        
        public string Trade_Status { get; set; }
        public decimal? Profit_Loss { get; set; }
        public string Exit_Reason { get; set; }
    }
}