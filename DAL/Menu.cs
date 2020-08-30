using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Menu
    {
        
        public static List<BasicItem> FillingInBasicGoods()
        {
            List<BasicItem> BasicGoodsList1 = new List<BasicItem>();
            int i = 1;
            int menuItem = 1;
            string nameType;
            int shelfLife;

            Console.Clear();
            Console.WriteLine("Введите типы товаров хранящиеся на складе");
            while (menuItem != 0)
            {
                
                Console.WriteLine("Введите тип №" + i);
                nameType = Console.ReadLine();
                //BasicGoodsList[i-1,0] = Console.ReadLine();
                
                Console.WriteLine("Введите срок годности товара: " + nameType);
                shelfLife = Validation.intValidation();
                //BasicGoodsList[i-1,1] = Console.ReadLine();
                BasicGoodsList1.Add(new BasicItem(nameType, shelfLife));
                i++;

                Console.Clear();
                Console.WriteLine("1. Добавить новый тип\n0. Выйти");
                menuItem = Validation.intValidation();
            }

            return BasicGoodsList1;
        }
    }
}