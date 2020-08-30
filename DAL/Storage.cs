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
        public int fullness;
        public List<Product> Products = new List<Product>();

        public Storage(int warehouseSize1)
        {
            warehouseSize = warehouseSize1;
        }
        public int CompletenessСheck
        {
            get
            {
                int sum = 0;
                foreach (Product product in Products)
                {
                    sum = sum + product.size;
                }
                return sum;
            }
        }
    }
}
