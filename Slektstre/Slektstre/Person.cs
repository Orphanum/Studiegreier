using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Slektstre;


namespace Slektstre
{
    class Person
    {
        public int father;
        public int mother;
        public string firstName;
        public string lastName;
        public int birthYear;
        public int deathYear;
        public int ID;
  
        public Person(int Id, string FirstName = null, string LastName = null, int BirthYear = 0, int DeathYear = 0, int Father = 99, int Mother = 99)
        {
            ID = Id;
            firstName = FirstName;
            lastName = LastName;
            birthYear = BirthYear;
            deathYear = DeathYear;
            father = Father;
            mother = Mother;
        }

        public static void List(int args)
        {

            var list = Program.list;

            Console.WriteLine("");
            for (var i = 0; i < list.Length; i++)
            {
                if (args == list[i].ID)
                {
                    for (var j = 0; j < list.Length; j++)
                    {
                        if (j == list[i].ID)
                        {
                            // Writes out the basic information
                            Console.WriteLine("ID: " + list[j].ID);

                            if (list[i].firstName == null) Console.WriteLine("Fornavn: N/A");
                            else Console.WriteLine("Fornavn: " + list[j].firstName);

                            if (list[i].lastName == null) Console.WriteLine("Etternavn: N/A");
                            else Console.WriteLine("Etternavn: " + list[j].lastName);

                            if (list[i].birthYear == 0) Console.WriteLine("Fødselsår: N/A");
                            else Console.WriteLine("Fødselsår: " + list[j].birthYear);

                            if (list[i].deathYear == 0) Console.WriteLine("Dødsår: N/A");
                            else Console.WriteLine("Dødsår: " + list[j].deathYear);
                        }
                    }
                    // Parentage
                    for (var j = 0; j < list.Length; j++)
                    {
                        if (j == list[i].father) Console.WriteLine("Far: " + list[j].firstName + ". ID: " + list[j].ID);
                        if (j == list[i].mother) Console.WriteLine("Mor: " + list[j].firstName + ". ID: " + list[j].ID);
                    }

                    // Children
                    for (var y = 0; y < list.Length; y++)
                    {
                        if (args == list[y].father) Console.WriteLine("Barn: " + list[y].firstName + ". ID: " + list[y].ID);
                        if (args == list[y].mother) Console.WriteLine("Barn: " + list[y].firstName + ". ID: " + list[y].ID);
                    }
                }
            }
        }

    }
}
