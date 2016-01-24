using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace People_Program
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddPersonBtn_Click(object sender, RoutedEventArgs e)
        {
            ////#########################
            ////Testing DatePicker

            //string BirthDate = BirthDatePicker.Text;
            //TestPicker = BirthDatePicker;

            ////#########################


            //String to be printed if information is lacking
            string missingInformation = "You are missing:";

            //Temporary variables to hold information used
            //in creating a person + validation booleans
            string firstName = "";
            bool firstNameInput = true;
            string lastName = "";
            bool lastNameInput = true;
            bool gender = true;
            bool genderInput = true;
            string birthDate = "";
            bool birthDateInput = true;
            string address = "";
            bool addressInput = true;
            string city = "";
            bool cityInput = true;
            string country = "";
            bool countryInput = true;

            //Checks the information input from GUI
            //and returns FALSE if there's missing input
            if (FirstNameTxb.Text != "")
            {
                firstName = FirstNameTxb.Text;
            }
            else
            {
                firstNameInput = false;
                missingInformation += "\nFirst name";
            }

            string secondName = SecondNameTxb.Text;

            if (LastNameTxb.Text != "")
            {
                lastName = LastNameTxb.Text;
            }
            else
            {
                lastNameInput = false;
                missingInformation += "\nLast name";
            }

            if (GenderRbtnMale.IsChecked == true || GenderRbtnFemale.IsChecked == true)
            {
                if (GenderRbtnMale.IsChecked == true)
                {
                    gender = true;
                }
                else if (GenderRbtnFemale.IsChecked == true)
                {
                    gender = false;
                }
            }
            else
            {
                genderInput = false;
                missingInformation += "\nGender";
            }

            if (BirthDatePicker.Text != "")
            {
                birthDate = BirthDatePicker.Text;
            }
            else
            {
                birthDateInput = false;
                missingInformation += "\nBirth date";
            }

            if (AddressTxb.Text != "")
            {
                address = AddressTxb.Text;
            }
            else
            {
                addressInput = false;
                missingInformation += "\nAddress";
            }

            if (CityTxb.Text != "")
            {
                city = CityTxb.Text;
            }
            else
            {
                cityInput = false;
                missingInformation += "\nCity";
            }

            if (CountryTxb.Text != "")
            {
                country = CountryTxb.Text;
            }
            else
            {
                countryInput = false;
                missingInformation += "\nCountry";
            }

            string birthCountry = BirthCountryTxb.Text;

            //Validating whatever input from GUI to Person
            //is sufficient or lacking.
            if (firstNameInput == true && lastNameInput == true &&
                genderInput == true && birthDateInput == true &&
                addressInput == true && cityInput == true && countryInput == true)
            {
                Controller.CreateNewPerson(
                firstName, secondName, lastName,
                gender, birthDate, address, city,
                country, birthCountry);

                ClearTextBoxes();
                MessageBox.Show("New person created");
            }
            else
            {
                MessageBox.Show(missingInformation);
            }
            
        }

        private void ClearPersonBtn_Click(object sender, RoutedEventArgs e)
        {
            ClearTextBoxes();
        }
        private void ShowFirstPersonBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ShowNextPersonBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ClearTextBoxes()
        {
            FirstNameTxb.Text = "";
            SecondNameTxb.Text = "";
            LastNameTxb.Text = "";
            GenderRbtnFemale.IsChecked = false;
            GenderRbtnMale.IsChecked = false;
            AddressTxb.Text = "";
            CityTxb.Text = "";
            CountryTxb.Text = "";
            BirthCountryTxb.Text = "";
        }

    }
}
