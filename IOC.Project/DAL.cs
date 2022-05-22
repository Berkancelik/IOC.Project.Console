using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC.Project
{
    public class DAL
    {
        public List<Prodcut> GetProducts()
        {
            return new List<Prodcut>()
            {
                new Prodcut(){Id =1, Name = "Kalem", Price = 100, Stock = 150},
                new Prodcut(){Id =2, Name = "Kalem", Price = 100, Stock = 150},
                new Prodcut(){Id =3, Name = "Kalem", Price = 100, Stock = 150},
                new Prodcut(){Id =4, Name = "Kalem", Price = 100, Stock = 150}
            };
        }
    }
}
