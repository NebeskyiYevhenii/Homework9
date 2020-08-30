using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ListBasicItem
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
                Console.Write("Введите тип №" + i + ": ");
                nameType = Console.ReadLine();
                
                Console.Write("Введите срок годности товара " + nameType + ": ");
                shelfLife = Validation.intValidation();

                BasicGoodsList1.Add(new BasicItem(nameType, shelfLife));
                i++;

                Console.Clear();
                Console.WriteLine("1. Добавить новый тип\n0. Завершить");
                menuItem = Validation.intValidation();
                Console.Clear();
            }
            return BasicGoodsList1;
        }
    }
}