using System.Collections.Generic;
using System.Linq;
using shopapp.data.Abstract;
using shopapp.entity;

namespace shopapp.data.Concrate.EfCore
{
    public class EfCoreProductRepository : EfCoreGenericRepository<Product, ShopContext>, IProductRepository
    {
        public List<Product> GetPopularProducts()
        {
            using(var context=new ShopContext())
            {  
              return context.Products.ToList();
            }
        }
    }
}