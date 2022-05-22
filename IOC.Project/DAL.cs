using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC.Project
{
    public class DAL : IDAL
    {
        public List<Product> GetProducts()
        {
            return new List<Product>()
            {
                new Product(){Id =1, Name = "Kalem", Price = 100, Stock = 150},
                new Product(){Id =2, Name = "Kalem", Price = 100, Stock = 150},
                new Product(){Id =3, Name = "Kalem", Price = 100, Stock = 150},
                new Product(){Id =4, Name = "Kalem", Price = 100, Stock = 150}
            };


        }
        public int Hesapla()
        {
            return 100;
        }
    }
}
