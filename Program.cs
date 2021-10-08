using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Моделирование_процесса_растворения_твердых_тел
{
    class Program
    {
        static void Main(string[] args)
        {
            int FieldSize = EnterValues("Введите размер квадратного поля");
            Point[,] Field = new Point[30, 30];
            for (int i =0; i < Field.GetLength(1); i++)
                for (int j = 0; j < Field.GetLength(0); j++)
                {
                    Field[j, i] = new Point(concentration:500);
                }
            
        }
        static int EnterValues(string message)
        {
            Console.WriteLine(message);
            int number;
            string input = Console.ReadLine();
            while (!int.TryParse(input, out number))
            {
                Console.Clear();
                Console.WriteLine("Некорректный ввод");
                Console.WriteLine(message);
                input = Console.ReadLine();
            }
            Console.Clear();
            return number;
        }
    }
}
