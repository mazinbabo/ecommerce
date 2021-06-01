
using e_commerce.Aggregates.CustomerAgg;
using e_commerce.Aggregates.OrderAgg;
using e_commerce.Aggregates.ProductAgg;
using ECommerce.Data.Interfaces;
using ECommerce.Data.Repositories;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {

        private EcommerceContext _dbContext;
        private Repository<Customer> _customers;
        private Repository<Order> _orders;
        private Repository<OrderLineItem> _orderLineItem;
        private Repository<Address> _addresses;
        private Repository<Product> _product;
        //private Repository<BillingRecord> _billingRecords;
        //private Repository<BillingRecordItem> _billingRecordItem;


        public UnitOfWork()
        {
            _dbContext = new EcommerceContext();
        }

        public IRepository<Customer> Customers
        {
            get
            {
                return _customers ??
                    (_customers = new Repository<Customer>(_dbContext));
            }
        }

        public IRepository<Order> Orders
        {
            get
            {
                return _orders ??
                    (_orders = new Repository<Order>(_dbContext));
            }
        }

        public IRepository<OrderLineItem> OrderLineItems
        {
            get
            {
                return _orderLineItem ??
                    (_orderLineItem = new Repository<OrderLineItem>(_dbContext));
            }
        }

        public IRepository<Address> Addresses
        {
            get
            {
                return _addresses ??
                    (_addresses = new Repository<Address>(_dbContext));
            }
        }

        public IRepository<Product> Products
        {
            get
            {
                return _product ??
                    (_product = new Repository<Product>(_dbContext));
            }
        }

        //public IRepository<BillingRecord> BillingRecords
        //{
        //    get
        //    {
        //        return _billingRecords ??
        //            (_billingRecords = new Repository<BillingRecord>(_dbContext));
        //    }
        //}

        //public IRepository<BillingRecordItem> BillingRecordItems
        //{
        //    get
        //    {
        //        return _billingRecordItem ??
        //            (_billingRecordItem = new Repository<BillingRecordItem>(_dbContext));
        //    }
        //}

        public void Commit()
        {
            _dbContext.SaveChanges();
        }
    }
}
