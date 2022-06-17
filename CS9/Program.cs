using System;

namespace CS9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tryCount = 10;
            string userInput;
            string stopProgram;
            Console.WriteLine("Для запуска программы введите сообщение.");
            userInput = Console.ReadLine(); 
            stopProgram = "Для остановки программы введите exit"; 

            for (int i = 0; i < tryCount; i++)

            if (userInput != "exit")
            {
                Console.WriteLine(stopProgram);
                userInput = Console.ReadLine();
            }
            Console.WriteLine("Программа остановлена.");
        }
    }
}
