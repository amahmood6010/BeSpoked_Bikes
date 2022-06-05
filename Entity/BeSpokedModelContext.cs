using System;
using System.Linq;
using System.Threading.Tasks;using System.Data.Entity;
using System.Collections.Generic;

namespace BeSpoked_Bikes
{
    public class BeSpokedModelContext : DbContext
    {
        public BeSpokedModelContext()
            : base ("Server=DESKTOP-98D8SEE;Database=BeSpokedBick;Integrated Security=True;")
        { }

        public BeSpokedModelContext(string nameOrConnectionString) :base  (nameOrConnectionString)
        {
            this.Database.Connection.ConnectionString = nameOrConnectionString;
        }

        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Salespersons> Salespersons { get; set; }
        public virtual DbSet<Sales> Sales { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Discounts> Discounts { get; set; }

        public List <Products> GetProducts ()
        {
            var query = (from be in Products select be).ToList();

            return query;
        }

        public Products GetProductsById(long id)
        {
            var query = this.Products.Where(be => be.Id == id).FirstOrDefault();
            return query;
        }

        public List<Salespersons> GetSalesPersons()
        {
            var query = (from be in Salespersons select be).ToList();

            return query;
        }

        public Salespersons GetSalesPersonsById(long id)
        {
            var query = this.Salespersons.Where(be => be.Id == id).FirstOrDefault();

            return query;
        }

        public List<Sales> GetSales()
        {
            var query = (from be in Sales select be).ToList();

            return query;
        }

        public List<Sales> GetSalesByDateRange(DateTime fromDate, DateTime toDate)
        {
            
            var query = this.Sales.Where(be => be.Sales_Date >= fromDate && be.Sales_Date <= toDate).ToList();

            return query;
        }

        public List<Sales> GetSalesBySalesPersonIdAndDateRange(long salePersonid, DateTime fromDate, DateTime toDate)
        {
            var query = this.Sales.Where(be => be.SalespersonId == salePersonid && (be.Sales_Date >= fromDate && be.Sales_Date <= toDate)).ToList();

            return query;
        }

        public List<Customers> GetCustomers()
        {
            var query = (from be in Customers select be).ToList();

            return query;
        }

        public Customers GetCustomersById( long id )
        {

            var query = this.Customers.Where(be => be.Id == id).FirstOrDefault();             

            return query;
        }
                

        public Discounts GetRecentDiscountByProductId(long id)
        {
            var discountQuery = new Discounts();
            var query = this.Discounts.Where(be => be.End_Date >= DateTime.UtcNow && be.Begin_Date <= DateTime.UtcNow && be.ProductId==id).ToList();
            if (query.Count > 0)
            {
                discountQuery = query.OrderByDescending(x => x.Id).FirstOrDefault();                 
            }

            return discountQuery;
        }

    }
}
