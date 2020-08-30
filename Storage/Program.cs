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
            Console.WriteLine("Введите размер склада: ");
            int sizeStorage = Validation.intValidation();
            Storage storage = new Storage(sizeStorage);

            List<BasicItem> BasicGoodsList = new List<BasicItem>();
            BasicGoodsList = ListBasicItem.FillingInBasicGoods();

            int numMenu = 1;
            while (numMenu != 0)
            {

                Console.WriteLine("Добавление товара на склад");
                Console.Write("Введите кол-во товара: ");
                int itemQuantity = Validation.intValidation();

                while (storage.CompletenessСheck + itemQuantity > storage.warehouseSize)
                {
                    Console.WriteLine($"Склад переполнен. Влезет не больше {storage.warehouseSize - storage.CompletenessСheck}");
                    Console.Write("Введите кол-во товара: ");
                    itemQuantity = Validation.intValidation();
                }


                Console.Write("Введите название товара: ");
                string nameProduct = Console.ReadLine();

                Console.Write("Введите цену товара: ");
                float price = Validation.floatValidation();

                Console.WriteLine("Выберите Базовый товар:");
                int count = 1;
                foreach (BasicItem element in BasicGoodsList)
                {
                    Console.WriteLine(count + ". " + element.name + " | срок годности: " + element.shelfLife);
                    count++;
                }
                int numBasicItem = Validation.intValidation();
                while (numBasicItem > count-1 || numBasicItem < 1)
                {
                    Console.WriteLine("Ошибка! Повторите выбор базового товара");
                    numBasicItem = Validation.intValidation();
                }
                    


                Console.Write("Введите дату поставки в формате дд.мм.гггг: ");
                DateTime dateOfDelivery = Validation.dateTimeValidation();

                storage.Products.Add(new Product(itemQuantity, nameProduct, price, BasicGoodsList[numBasicItem-1], dateOfDelivery));

                Console.WriteLine("1. Добавить товар\n0. Выход");
                numMenu = Validation.intValidation();
                Console.Clear();
            }

            Console.Clear();
            int i = 1;
            foreach (Product element in storage.Products)
            {
                Console.WriteLine($"{i}. Название товара: {element.name}\nКол-во: {element.size}\nЦена товпра: {element.price}\nДата поставки {element.dateOfDelivery}\nТип товара: {element.basicItem.name}\nСрок годности: {element.basicItem.shelfLife}\nДата списания: {element.DelayDate}");
                Console.WriteLine("--------------------------------------------------------------------------------");
                i++;
            }
            Console.ReadKey();
        }
    }
}
