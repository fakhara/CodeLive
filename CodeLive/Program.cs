using System;
using System.Diagnostics.Metrics;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace CodeLive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Variabler​ Skapa variabler för namn och ålder och kombinera dessa till en hälsning. Använd Interpolation​.
            string namn = "Fakhara";
            int ålder = 30;

            string hälsning = $"Hej {namn}, du är {ålder} år gammal!";
            Console.WriteLine(hälsning);

            // 2.For loop​ En enkel loop som räknar från 1 till 5.​
            
            for (int i = 1; i <= 5; i++)
            {
               int result = i;
                Console.WriteLine(i);
            }

            Random random = new Random();
            int targetNumber = random.Next(1, 11);
            int guess = 0;

            Console.WriteLine("Gissa ett nummer mellan 1 och 10!");

            while (guess != targetNumber)
            {
                Console.Write("Din gissning: ");
                guess = int.Parse(Console.ReadLine());

                if (guess < targetNumber)
                    Console.WriteLine("För lågt!");
                else if (guess > targetNumber)
                    Console.WriteLine("För högt!");
                else
                    Console.WriteLine("Rätt gissat!");
            }
            // 4.Metoder​ Skapa en metod som beräknar summan av två tal och anropar den.​
                 
                  int tal1 = 5;
                  int tal2 = 10;

                  int summa = BeräknaSumma(tal1, tal2);
                  Console.WriteLine($"Summan av {tal1} och {tal2} är: {summa}");

            //5. Array​ Skapa en array med namn och skriv ut alla namn.​

            string[] namnArray = { "Anna", "Björn", "Cecilia", "David", "Elin" };

            //Skriv ut alla namn i arrayen
            Console.WriteLine("Namnen i arrayen är:");
            foreach (string Name in namnArray)
            {
                Console.WriteLine(Name);
            }

            //6. Listor​ Använd en lista för att lagra dina favorit maträtter.Skriv ut totalen​.

                List<string> favoritMatratter = new List<string>
                {
                     "Pizza",
                     "Sushi",
                     "Tacos",
                     "Pasta",
                     "Hamburgare"
                };

            //Skriv ut alla favoritmaträtter
            Console.WriteLine("Mina favoritMatratter:");
            foreach (string matratt in favoritMatratter)
            {
                Console.WriteLine(matratt); 
            }

            //Skriv ut totalen av favoritmaträtter
                 Console.WriteLine($"\n Totalt antal favoritmaträtter: {favoritMatratter.Count} ");

            //7. Enkla klasser​ Skapa en klass Person med egenskaperna Name och Age, och skapa en instans av klassen.​

            //Skapa en instans av Person-klassen
               Person person = new Person("Anna", 25);
            //Anropa metoden för att visa personens information
               person.VisaInfo();

            //8. Skapa ett interface IMovable med en metod Move, och implementera det i klassen Car.​

                Car car = new Car("Volvo");
                car.Move();

            //9. Arv (Inheritance)​ Skapa en basklass Animal och en subklass Dog som ärver Animal.Lambda!​

                     Dog dog = new Dog("Buddy");
           

                   // Lambda-uttryck som anropar Speak-metoden på Dog-objektet
                        Action speakAction = () => dog.Speak();

                  //Anropa Lambda-uttrycket
                   speakAction();

            //10. String​ Hämta ett namn från din user och skriv den till konsolen i versaler, gemener och sedan räkna antalet tecken​.

                // Hämta ett namn från användaren
                   Console.Write("Ange ditt namn:");
                   string name = Console.ReadLine();

                // Skriv ut namnet i versaler
                    Console.WriteLine("Versaler: " + name.ToUpper());

                // Skriv ut namet i gemener
                     Console.WriteLine("Gemenner: " + name.ToLower());

               // Räkna och skriv ut antalet tecken i namet
                      Console.WriteLine("Antal tecken: " + name.Length);

        }
        static int BeräknaSumma(int nummer1, int nummer2)
        {
            return nummer1 + nummer2;
        }
    }
}