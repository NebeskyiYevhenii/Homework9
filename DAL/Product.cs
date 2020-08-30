using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Product
    {
        public string name;
        public float price;
        public BasicItem basicItem;

        public Product (string name1, float price1, BasicItem basicItem1)
        {
            name = name1;
            price = price1;
            basicItem = basicItem1;
        }
    }
}
