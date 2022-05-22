using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC.Project
{
    public class BL
    {
        private DAL _dal {get; set;}

        public BL()
        {
        }

        public List<Prodcut> GetProducts()
        {
            return _dal.GetProducts();
        }
    }
}
