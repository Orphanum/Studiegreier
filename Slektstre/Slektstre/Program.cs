using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Slektstre
{

    class Program
    {
        public static Person[] list = new[]
        {
            new Person(0, "Sverre Magnus", null, 2005, 0, 2, 3),
            new Person(1, "Ingrid Alexandra", null, 2004, 0, 2, 3),
            new Person(2, "Haakon Magnus", null, 1973, 0 ,5 ,6 ),
            new Person(3, "Mette Marit", null, 1973),
            new Person(4, "Marius", "Borg Høiby", 1997, 0, 99, 3),
            new Person(5, "Harald", null, 1937, 0, 7),
            new Person(6, "Sonja", null, 1937),
            new Person(7, "Olav", null, 1903, 1991)
        };
        static void Main(string[] args)
        {
            bool programRunning = true;

            Console.WriteLine("Velkommen til slektstreprogrammet.");
            Console.WriteLine("skriv <hjelp> om du vil se de tilgjengelige kommandoene");


            while (programRunning)
            {
                

                var userInput = Console.ReadLine().ToUpper();
                if (userInput == "HJELP")
                {
                    Hjelp();
                }
                if (userInput == "LISTE")
                {
                    Show();
                }

                if (userInput.StartsWith("VIS"))
                {
                    var userInputID = userInput.Substring(4);
                    Person.List(int.Parse(userInputID));
                }
            }
        }


    
        static void Hjelp()
        {
            Console.WriteLine("De tilgjengelige kommandoene er:");
            Console.WriteLine(" - liste: lister alle personer med id, fornavn, fødselsår og dødsår");
            Console.WriteLine("          lister også navn og id på mor og far om det er registrert.");
            Console.WriteLine("");
            Console.WriteLine(" - vis <id>: viser en bestemt person med mor, far og barn.");
        }


        static void Show()
        {

            for (var i = 0; i < list.Length; i++)
            {
                Console.WriteLine("");

                // Writes out the basic information
                Console.WriteLine("ID: " + list[i].ID);
                if (list[i].firstName == null) Console.WriteLine("Fornavn: N/A");
                else Console.WriteLine("Fornavn: " + list[i].firstName);

                if (list[i].lastName == null) Console.WriteLine("Etternavn: N/A");
                else Console.WriteLine("Etternavn: " + list[i].lastName);

                if (list[i].birthYear == 0) Console.WriteLine("Fødselsår: N/A");
                else Console.WriteLine("Fødselsår: " + list[i].birthYear);

                if (list[i].deathYear == 0) Console.WriteLine("Dødsår: N/A");
                else Console.WriteLine("Dødsår: " + list[i].deathYear);


                // Writes out parentage
                if (list[i].father != 0)
                {
                    for (var j = 0; j < list.Length+1; j++)
                    {
                        if (j == list[i].father) Console.WriteLine("Far: " + list[j-1].firstName + ". ID: " + list[j - 1].ID);
                    }
                }
                if (list[i].mother != 0)
                {
                    for (var j = 0; j < list.Length + 1; j++)
                    {
                        if (j == list[i].mother) Console.WriteLine("Mor: " + list[j - 1].firstName + ". ID: " + list[j -1].ID);
                    }
                }
                Console.WriteLine("");
            }
        }
    }
}
