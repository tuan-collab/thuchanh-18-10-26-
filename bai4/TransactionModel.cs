using System;

namespace RevenueAnalytics
{
    public class TransactionModel
    {
        public string TransactionId { get; set; }
        public DateTime TransactionDate { get; set; }
        public string BranchName { get; set; }
        public string CustomerName { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; }
    }
}