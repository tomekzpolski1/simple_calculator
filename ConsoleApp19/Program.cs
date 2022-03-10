using System;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("podaj liczbę1:");
            double liczba1 = double.Parse(Console.ReadLine());
            Console.WriteLine("podaj liczbę2:");
            double liczba2 = double.Parse(Console.ReadLine());
            Console.WriteLine("podaj działanie (+,-,*,/):");
            double wynik;
            string znak = Console.ReadLine();
            switch (znak)
            {
                case "+":
                wynik = liczba1 + liczba2;
                    Console.WriteLine("Wynik dodawania to {0}",wynik);
                    break;
                case "-":
                    wynik = liczba1 - liczba2;
                    Console.WriteLine("Wynik odejmowania to {0}", wynik);
                    break;
                case "*":
                    wynik = liczba1 * liczba2;
                    Console.WriteLine("Wynik mnożenia to {0}", wynik);
                    break;
                case "/":
                    wynik = liczba1 / liczba2;
                    Console.WriteLine("Wynik dzielenia to {0}", wynik);
                    break;
                default:
                    Console.WriteLine("Podaj poprawny znak działania");
                    break;
            }
          

        }
    }
}
