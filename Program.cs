using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("veuillez renseigner votre age : ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("etes vous un homme ou une femme ? ");
            string sexe = Console.ReadLine();

            if (age > 18)
            {
                Console.WriteLine($"vous etes {sexe} et vous etes majeur ");
            }

            else
            {
                Console.Write($"vous etes {sexe} et vous etes mineur ");
            }
            

            
            
        }
    }
}
