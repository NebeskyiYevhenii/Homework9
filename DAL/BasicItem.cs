using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BasicItem
    {
        public string name;
        public int shelfLife;

        public BasicItem(string name1, int shelfLife1)
            {
                name = name1;
                shelfLife = shelfLife1;
            }
    }
}
