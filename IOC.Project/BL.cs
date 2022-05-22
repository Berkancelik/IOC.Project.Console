using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC.Project
{
    public class BL
    {
        private IDAL _dal {get; set;}

        public BL()
        {
        }

        public List<Product> GetProducts()
        {
            return _dal.GetProducts();
        }
    }
}
