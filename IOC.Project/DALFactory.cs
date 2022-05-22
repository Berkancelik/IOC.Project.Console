using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC.Project
{
    public class DALFactory
    {
        public static DAL GetDal()
        {
            return new DAL();   
        }
    }
}
