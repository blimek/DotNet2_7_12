using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet2_7_12


//Napisz program, który pobierze numer dnia tygodnia i wyświetli jego
//nazwę
//Dane testowe : 4
//Rezultat w terminalu :
//Czwartek

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj dzień tygodnia jako liczbę");
            int day = Int32.Parse(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("mamy poniedziałek");
                    break;
                case 2:
                    Console.WriteLine("mamy wtorek");
                    break;
                case 3:
                    Console.WriteLine("mamy środę");
                    break;
                case 4:
                    Console.WriteLine("mamy czwartek");
                    break;
                case 5:
                    Console.WriteLine("mamy piątek");
                    break;
                case 6:
                    Console.WriteLine("mamy sobotę");
                    break;
                case 7:
                    Console.WriteLine("mamy niedziele");
                    break;
                default:
                    Console.WriteLine("nie ma takiego dnia tygodnia");
                    break;


            }
            Console.ReadLine();


        }
    }
}

