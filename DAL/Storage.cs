using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Storage
    {
        public int warehouseSize;
        public List<Product> Products = new List<Product>();

        public Storage(int warehouseSize1)
        {
            warehouseSize = warehouseSize1;
        }
    }
}
