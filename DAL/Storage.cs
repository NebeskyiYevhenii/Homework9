using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Storage
    {
        public Storage(int warehouseSize)
        {
            Product[] storage = new Product[warehouseSize];
        }
    }
}
