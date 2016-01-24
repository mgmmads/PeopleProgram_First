using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People_Program
{
    static class Controller
    {
        static private List<Person> PersonList = new List<Person>();

        static public int GetNewPersonID()
        {
            return PersonList.Count + 1;
        }

        static public void CreateNewPerson(
            string firstName, string secondName, string lastName, 
            bool gender, string birthDate, string address, 
            string city, string country, string birthCountry)
        {
            Person newPerson = new Person(
                firstName, secondName, lastName, 
                gender, birthDate, address, 
                city, country, birthCountry);

            PersonList.Add(newPerson);
        }
    }
}
