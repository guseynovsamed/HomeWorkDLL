using Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkPraktiki.Controllers
{
    public class ProductController
    {
        private readonly ProductService _productService;

        public ProductController()
        {
            _productService = new ProductService();
        }

        public void GetAllByCount()
        {
            foreach(var item in _productService.GetAllByCount(5))
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
