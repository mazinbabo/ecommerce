//using e_commerce.Aggregates.OrderAgg;
//using e_commerce.BaseTypes;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.Linq;

//namespace e_commerce.Aggregates.CustomerAgg
//{
//    public class BillingRecord : Entity
//    {

//        private readonly List<BillingRecordItem> _billingRecordItems;

//        public DateTime Date { get; private set; }
        
//        public string InvoiceId { get; private set; }
        
//        public PaymentStatus Status { get; set; }

//        public BillingRecordType Type { get; set; }


//        public string TransactionId { get; private set; }

//        public int OrderId { get; set; }
        
//        public Order Order { get; set; }

//        public int CustomerId { get; set; }

//        public Customer Customer { get; set; }

//        public IEnumerable<BillingRecordItem> BillingRecordItems
//        {
//            get { return _billingRecordItems; }
//        }

//        [Required]
//        public decimal Amount
//        {
//            get { return _billingRecordItems.Sum(x => x.Amount); }
//        }

//        private BillingRecord()
//        { }

//        public BillingRecord(DateTime billingDate, string invoiceId, BillingRecordType type)
//        {
//            if (billingDate == null) throw new ArgumentNullException("billingDate");

//            Date = billingDate;
//            SetInvoiceId(invoiceId);
//            Type = type;
//        }

//        public void AddBillingRecordItem(decimal amount, string name, string description = null)
//        {
//            _billingRecordItems.Add(description == null
//                ? new BillingRecordItem(name, amount)
//                : new BillingRecordItem(name, description, amount));
//        }

//        public void SetInvoiceId(string invoiceId)
//        {
//            if (string.IsNullOrWhiteSpace(invoiceId)) throw new ArgumentNullException("invoiceId");
//            InvoiceId = invoiceId;
//        }
//    }
//}