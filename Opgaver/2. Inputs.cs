using System;
using System.Globalization;

namespace Opgaver
{
    public class Inputs
    {
        public static void Run()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Velkommen til opgaver omkring Expressions, Operators og Inputs!");
            String1();
            Int1();
            Double1();
            Bool1();

            // Mini-projekter til inspiration:
            MiniProjekt1();
            MiniProjekt2();
        }

        public static void String1()
        {
            Console.WriteLine(
                "Lav et program som gemmer et input som en string og skriver strengen ud i konsollen"
            );

            Console.WriteLine("Indtast en streng: ");
            // Lav opgaven herunder!
            string? input = Console.ReadLine();
            Console.WriteLine(input); 
        }

        public static void Int1()
        {
            Console.WriteLine(
                "Lav et program som gemmer et input som et tal og skriver tallet ud i konsollen"
            );

            int tal;
            while (true)
            {
                Console.Write("Indtast et tal: ");
                string? input = Console.ReadLine();

                if (int.TryParse(input, out tal))
                    break;

                Console.WriteLine("Ugyldigt input — indtast et heltal.");
            }

            Console.WriteLine(tal);
        }

        public static void Double1()
        {
            Console.WriteLine(
                "Lav et program som gemmer et input som et decimaltal og skriver tallet ud i konsollen"
            );

            double decimaltal;
            while (true)
            {
                Console.Write("Indtast et decimaltal: ");
                string input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input) &&
                    double.TryParse(input, NumberStyles.Float | NumberStyles.AllowThousands, CultureInfo.CurrentCulture, out decimaltal))
                {
                    break;
                }

                Console.WriteLine("Ugyldigt decimaltal. Prøv igen.");
            }

            Console.WriteLine(decimaltal);
        }

        public static void Bool1()
        {
            Console.WriteLine(
                "Lav et program som gemmer et input som en sandhedsværdi og skriver værdien ud i konsollen"
            );

            Console.WriteLine("Indtast en sandhedsværdi (sandt/falsk): ");
            // Lav opgaven herunder!
            string? input = Console.ReadLine();
                        bool sandhedsværdi = input?.ToLower() == "sandt"; 
            Console.WriteLine(sandhedsværdi);
        }

        // Mini-projekt: Personlig profil (skabelon)
        public static void MiniProjekt1()
        {
            Console.WriteLine("\nMini-projekt: Personlig profil (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine("Lav et program, hvor brugeren indtaster sit navn, alder og hjemby.");
            Console.WriteLine(
                "Gem oplysningerne i variabler og udskriv en præsentationstekst, der bruger alle oplysningerne."
            );
            Console.WriteLine("Eksempel: Hej, jeg hedder X, er X år gammel og kommer fra X!");
            // Lav opgaven herunder! 

            
                Console.WriteLine("\nMini-projekt: Personlig profil");
                Console.Write("Indtast dit navn: ");
                string name = Console.ReadLine() ?? "";

                int age;
                while (true)
                {
                    Console.Write("Indtast din alder: ");
                    string? input = Console.ReadLine();
                    if (int.TryParse(input, out age)) break;
                    Console.WriteLine("Ugyldigt input — indtast et heltal.");
                }

                Console.Write("Indtast din hjemby: ");
                string city = Console.ReadLine() ?? "";

                Console.WriteLine($"Hej, jeg hedder {name}, er {age} år gammel og kommer fra {city}!");
        }

        // Mini-projekt 2: BMI-beregner (skabelon)
        public static void MiniProjekt2()
        {
            Console.WriteLine("\nMini-projekt 2: BMI-beregner (skabelon)");
            Console.WriteLine("Opgave:");
            Console.WriteLine(
                "Lav et program, hvor brugeren indtaster sin vægt (i kg) og højde (i meter)."
            );
            Console.WriteLine("Programmet skal beregne brugerens BMI og udskrive resultatet.");
            Console.WriteLine(
                "Tip: BMI beregnes som vægt divideret med højde i anden (BMI = vægt / (højde * højde))."

                ); 
            int vægt;
            while (true)
            {
                Console.Write("Indtast din vægt i kg: ");
                string? input = Console.ReadLine();
                if (int.TryParse(input, out vægt)) break;
                Console.WriteLine("Ugyldigt input — indtast et heltal og i kg.");
            }
            int højde;
            while (true)
            {
                Console.Write("Indtast din højde i meter: ");
                string? input = Console.ReadLine();
                if (int.TryParse(input, out højde)) break;
                Console.WriteLine("Ugyldigt input — indtast et heltal og i meter.");
            }
            Console.WriteLine("Din BMI er: " + (vægt / (højde * højde))

            );
        }
    }
}
