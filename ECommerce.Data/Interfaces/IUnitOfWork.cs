using e_commerce.Aggregates.CustomerAgg;
using e_commerce.Aggregates.OrderAgg;

namespace ECommerce.Data.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<Customer> Customers { get; }
        IRepository<Order> Orders { get; }
        IRepository<OrderLineItem> OrderLineItems { get; }
        IRepository<Address> Addresses { get; }
        //IRepository<BillingRecord> BillingRecords { get; }
        //IRepository<BillingRecordItem> BillingRecordItems { get; }
        void Commit();
    }
}
