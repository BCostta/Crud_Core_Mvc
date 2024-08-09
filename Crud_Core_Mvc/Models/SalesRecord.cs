using Crud_Core_Mvc.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;
namespace Crud_Core_Mvc.Models
{
    public class SalesRecord
    {

        public int Id { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/M/yyyy}")]
        public DateTime Date { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd:MM/yyyy}")]
        public double Amount { get; set; }
        public SaleStatus Status { get; set; }
        public Seller Seller { get; set; }

        public SalesRecord() { }

        public SalesRecord(int id, DateTime date, double amount, SaleStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}
