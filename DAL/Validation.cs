using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Validation
    {
        public static int intValidation()
        {
            int value;
            while (!int.TryParse(Console.ReadLine(),out value))
            {
                Console.WriteLine("Введите цифру! ");
            }
            return value;
        }

        public static float floatValidation()
        {
            float value;
            while (!float.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("Введите цифру! ");
            }
            return value;
        }

        public static DateTime dateTimeValidation()
        {
            DateTime value;
            while (!DateTime.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("Введите дату в формате дд.мм.гггг");
            }
            return value;
        }
    }
}
