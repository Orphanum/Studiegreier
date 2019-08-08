using System;
using System.Collections.Generic;

namespace Slektstre
{

    class Program
    {
        static readonly List<Person> list = new List<Person>();

        static void Main(string[] args)
        {
            bool programRunning = true;

            CreateList();
           

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
                    foreach (var p in list)
                    {
                        p.Show();
                    }
                }

                if (userInput.Contains("VIS"))
                {                    
                    var userInputID = userInput.Substring(4);
                    int x = Int32.Parse(userInputID);

                    for (var i = 0; i < list.ToArray().Length; i++)
                    {
                        if (list[i].ID.Equals(x))
                        {
                            list[i].Show();

                            var parent = list[i];

                            foreach (var p in list)
                            {

                                if (p.father == parent || p.mother == parent)
                                {
                                    Console.WriteLine("Barn:");
                                    p.Show();
                                }
                            }                                                    
                        }                        
                    }
                }
            }
        }


        public static void CreateList()
        {
            var sverreMagnus = new Person(1, "Sverre Magnus", null, 2005);
            var ingridAlexandra = new Person(2, "Ingrid Alexandra", null, 2004);
            var haakon = new Person(3, "Haakon Magnus", null, 1973);
            var metteMarit = new Person(4, "Mette-Marit", null, 1973);
            var marius = new Person(5, "Marius", "Borg Høiby", 1997);
            var harald = new Person(6, "Harald", null, 1937);
            var sonja = new Person(7, "Sonja", null, 1937);
            var olav = new Person(8, "Olav", null, 1903, 1991);

            sverreMagnus.father = haakon;
            sverreMagnus.mother = metteMarit;
            ingridAlexandra.father = haakon;
            ingridAlexandra.mother = metteMarit;
            marius.mother = metteMarit;
            haakon.father = harald;
            haakon.mother = sonja;
            harald.father = olav;

            list.Add(sverreMagnus);
            list.Add(ingridAlexandra);
            list.Add(haakon);
            list.Add(metteMarit);
            list.Add(marius);
            list.Add(harald);
            list.Add(sonja);
            list.Add(olav);
        }

        static void Hjelp()
        {
            Console.WriteLine("De tilgjengelige kommandoene er:");
            Console.WriteLine(" - liste: lister alle personer med id, fornavn, fødselsår og dødsår");
            Console.WriteLine("          lister også navn og id på mor og far om det er registrert.");
            Console.WriteLine("");
            Console.WriteLine(" - vis <id>: viser en bestemt person med mor, far og barn.");
        }
    }
}
