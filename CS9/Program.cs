using System;

namespace CS9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string exit = "exit";
            string tempString;

            while (true)
            {
                Console.WriteLine("Для продолжения нажмите 'Enter'. Для выхода введите " + exit);
                tempString = Console.ReadLine();

                if (tempString == exit)
                {
                    break;
                }
            }
        }
    }
}