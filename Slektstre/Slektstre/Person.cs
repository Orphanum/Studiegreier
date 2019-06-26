using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        
    }
}
