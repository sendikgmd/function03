using System;

namespace MyFirstApp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int number = GetNumber();
            
            Console.WriteLine("Введенный символ "+ number   +" идентифицирован, как число.");
            Console.ReadKey();
        }
        static int GetNumber()
        {
            int number = 0;
            bool isProgramWork = true;

            while (isProgramWork)
            {
                Console.Write("Введите число: ");

                string inputUser = Console.ReadLine();

                if (int.TryParse(inputUser, out number))
                {
                    isProgramWork = false;
                }
                else
                {
                    Console.WriteLine("Введенное значение не является числом.");
                }
            }
            return number;
        }
    }
}