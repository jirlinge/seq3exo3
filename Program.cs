using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;

            Console.WriteLine("veuillez entrer la premiere valeur");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("veuillez entrer la deuxieme valeur");
            number2 = Convert.ToInt32(Console.ReadLine());


            int sum1 = number1 + 33;
            int increm = ++number2;
            int result = sum1 / increm;

            Console.WriteLine("le resultat de l'opération est "+result);
            

            
            
        }
    }
}
