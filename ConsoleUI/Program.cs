
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    
    class Program
    {
        static void Main(string[] args)
        {
            EfProductDal efProductDal = new EfProductDal();
            //added
            Product product1 = new Product{ 
                CategoryId=1,
                BrandId =1,
                Name ="Su",
                Price = 2,
                CreateDate = DateTime.UtcNow,
                Code = "WTR01",
                Active = true,
            };

            //listed
            foreach (var product in efProductDal.GetAll(p=>p.CategoryId==1))
            {
                Console.WriteLine(product.Name);
            }
        }

       
    }
}
