using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class ProductService
    {
        private Product[] GetAll()
        {
            return new Product[]
            {
                new Product{Id =  1, Name ="Iphone5",Price=500,Color="Silver", Count=6},
                new Product{Id = 2,Name = "Iphone6",Price = 700, Color = "Spacegray", Count=10},
                new Product{Id = 3,Name = "Iphone 7", Price= 950, Color = "Red", Count = 4},
                new Product{Id = 4,Name = "Iphone 8",Price = 1020, Color = "Gold", Count= 2}

            };
        }



        public Product[] GetAllByCount( int count)
        {
            Product[] products = GetAll();

            return products.Where(m=>m.Count>count).ToArray();
        }
    }
}
