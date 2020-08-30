using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Product
    {
        public int size;
        public string name;
        public float price;
        public BasicItem basicItem;
        public DateTime dateOfDelivery;

        public Product(int size1, string name1, float price1, BasicItem basicItem1, DateTime dateOfDelivery1)
        {
            size = size1;
            name = name1;
            price = price1;
            basicItem = basicItem1;
            dateOfDelivery = dateOfDelivery1;
        }

        public DateTime DelayDate
        {
            get
            {
                return dateOfDelivery.AddDays(basicItem.shelfLife);
            }
        }
    }
}

