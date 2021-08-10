using System;

namespace Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            string continus = "yes";
            while (continus == "yes")
            {

                Console.Write("Enter the desired height (number):");
                int userInput = (int)double.Parse(Console.ReadLine());
                string outPut = "";
                while (userInput > 0)
                {
                    outPut += "*";
                    Console.WriteLine(outPut);
                    userInput--;
                }
                Console.Write("Continus (yes/no):");
                continus = Console.ReadLine();
            }
            Console.WriteLine("Good Bye");
        }
    }
}
