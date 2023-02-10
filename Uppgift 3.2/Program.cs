using System;
using System.Security.Cryptography.X509Certificates;

namespace uppgift3_2
{
    class uppgift3_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Har du ¨gått ut gymnasiet?");
            Console.WriteLine("J=ja  N=nej");
            string x = Console.ReadLine();

            Console.WriteLine("Hur gammal är du?");
            int ålder = Convert.ToInt32(Console.ReadLine());

            if (ålder >22 || x == "n")
                    {
                Console.WriteLine("Vi letar tyvärr efter annan personal just nu.");
            }
            else
            {
                Console.WriteLine("Vi vill gärna anställa dig.");
            }
        }
    }
}