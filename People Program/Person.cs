using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People_Program
{
    class Person
    {
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public bool GenderMaleOrFemale { get; set; }
        public string BirthDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string CurrentCountry { get; set; }
        public string BirthCountry { get; set; }

        public string ReturnPerson()
        {
            return PersonID + ";" + FirstName + ";" +
                SecondName + ";" + LastName + ";" +
                GenderMaleOrFemale + ";" + BirthDate + ";" +
                Address + ";" + City + ";" + CurrentCountry + ";" +
                BirthCountry;
        }

        public Person(string iFirstName, string iSecondName, string iLastName,
            bool iGender, string iBirthDate, string iAddress,
            string iCity, string iCurrentCountry, string iBirthCountry)
        {
            PersonID = Controller.GetNewPersonID();
            FirstName = iFirstName;
            SecondName = iSecondName;
            LastName = iLastName;
            GenderMaleOrFemale = iGender;
            BirthDate = iBirthDate;
            Address = iAddress;
            City = iCity;
            CurrentCountry = iCurrentCountry;
            BirthCountry = iBirthCountry;
        }

        public Person(string iFirstName, string iLastName,
            bool iGender, string iBirthDate, string iAddress,
            string iCity, string iCurrentCountry)
            : this(iFirstName, "", iLastName, iGender, iBirthDate, iAddress, iCity, iCurrentCountry, "")
        {

        }

        public Person(string iFirstName, string iSecondName,
            string iLastName, bool iGender, string iBirthDate,
            string iAddress, string iCity, string iCurrentCountry)
            : this(iFirstName, iSecondName, iLastName, iGender, iBirthDate, iAddress, iCity, iCurrentCountry, "")
        {

        }

        public Person(string iFirstName, string iLastName,
            bool iGender, string iBirthDate, string iAddress,
            string iCity, string iCurrentCountry, string iBirthCountry)
            : this(iFirstName, "", iLastName, iGender, iBirthDate, iAddress, iCity, iCurrentCountry, iBirthCountry)
        {

        }
    }
}
