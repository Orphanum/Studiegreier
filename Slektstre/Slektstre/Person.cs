using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Slektstre;


namespace Slektstre
{
   public class Person
    {
        public Person father;
        public Person mother;
        public string firstName;
        public string lastName;
        public int birthYear;
        public int deathYear;
        public int ID;
  
        public Person(int Id, string FirstName = null, string LastName = null, int BirthYear = 0, int DeathYear = 0, Person Father = null, Person Mother = null)
        {
            ID = Id;
            firstName = FirstName;
            lastName = LastName;
            birthYear = BirthYear;
            deathYear = DeathYear;
            father = Father;
            mother = Mother;
        }

        public void Show()
        {
            Console.WriteLine("");

            Console.WriteLine("ID: " + ID);

            if (firstName == null) Console.WriteLine("Fornavn: N/A");
            else Console.WriteLine("Fornavn: " + firstName);

            if (birthYear == 0) Console.WriteLine("Fødselsdato: N/A");
            else Console.WriteLine("Fødselsdato: " + birthYear);

            if (deathYear == 0) Console.WriteLine("Dødsår: N/A");
            else Console.WriteLine("Dødsår: " + deathYear);

            if (father == null) Console.WriteLine("Far: N/A");
            else Console.WriteLine("Far: " + father.firstName + ", ID: " + father.ID);

            if (mother == null) Console.WriteLine("Mor: N/A");
            else Console.WriteLine("Mor: " + mother.firstName + ", ID: " + mother.ID);

            Console.WriteLine("");





        }

    }
}
