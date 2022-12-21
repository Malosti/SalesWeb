using System;

namespace SalesWebMVC.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SalesRecord Stauts { get; set; }
        public Seller Seller { get; set; }

        public SalesRecord()
        {

        }

        public SalesRecord(int id, DateTime date, double amount, SalesRecord stauts, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Stauts = stauts;
            Seller = seller;
        }
    }
}
