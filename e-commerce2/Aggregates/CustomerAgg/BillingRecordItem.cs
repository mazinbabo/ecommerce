//using e_commerce.BaseTypes;
//using System;

//namespace e_commerce.Aggregates.CustomerAgg
//{
//    public class BillingRecordItem : Entity
//    {
//        public string Name { get; private set; }
//        public string Description { get; private set; }
//        public decimal Amount { get; private set; }

//        public int BillingRecordId { get; set; }

//        public BillingRecord BillingRecord { get; set; }

//        private BillingRecordItem()
//        { }

//        public BillingRecordItem(string name, decimal amount)
//        {
//            if (name == null) throw new ArgumentNullException("name");

//            Name = name;
//            Amount = amount;
//        }

//        public BillingRecordItem(string name, string description, decimal amount) : this(name, amount)
//        {
//            UpdateDescription(description);
//        }

//        public void UpdateDescription(string description)
//        {
//            if (description == null) throw new ArgumentNullException("description");
//            Description = description;
//        }
//    }
//}