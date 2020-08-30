using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace Homework9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BasicItem> BasicGoodsList = new List<BasicItem>();
            BasicGoodsList = Menu.FillingInBasicGoods();


            Console.WriteLine("Введите размер склада: ");
            int sizeStorage = Validation.intValidation();
            Storage storage = new Storage(sizeStorage);

            //int i = 0;
            int numMenu = 1;
            while (numMenu != 0)
            {
                
                Console.WriteLine("Добавление товара на склад");
                Console.WriteLine("Введите название товара:");
                string nameProduct = Console.ReadLine();

                Console.WriteLine("Введите цену товара:");
                float price = Validation.floatValidation();

                Console.WriteLine("Выберите Базовый товар:");

                int count = 1;
                foreach (BasicItem element in BasicGoodsList)
                {
                    Console.WriteLine(count + ". " + element.name + " | срок годности: " + element.shelfLife);
                    count++;
                }
                int numBasicItem = Validation.intValidation();

                storage.Products.Add(new Product(nameProduct, price, BasicGoodsList[numBasicItem-1]));

                Console.Clear();
                Console.WriteLine("1. Добавить товар\n0. Выход");
                numMenu = Validation.intValidation();
            }



        }
    }
}
