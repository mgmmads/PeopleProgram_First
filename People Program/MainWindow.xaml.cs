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
            string missingInformation = "You are missing";

            string firstName = "";
            bool firstNameInput = true;
            string lastName = "";
            bool lastNameInput = true;
            bool gender = true;
            bool genderInput = true;

            if (firstName != "")
            {
                firstName = FirstNameTxb.Text;
            }
            else
            {
                firstNameInput = false;
                missingInformation += ", first name";
            }

            string secondName = SecondNameTxb.Text;

            if (lastName != "")
            {
                lastName = LastNameTxb.Text;
            }
            else
            {
                lastNameInput = false;
                missingInformation += ", last name";
            }

            if (GenderRbtnMale.IsChecked == false && GenderRbtnFemale.IsChecked == false
            {
                if (GenderRbtnMale.IsChecked == true && GenderRbtnFemale.IsChecked == false)
                {
                    gender = true;
                }
                else if (GenderRbtnMale.IsChecked == false && GenderRbtnFemale.IsChecked == true)
                {
                    gender = false;
                }
            }
            else
            {
                genderInput = false;
                missingInformation += ", gender";
            }

            string birthDate = BirthDateTxb.Text;
            string address = AddressTxb.Text;
            string city = CityTxb.Text;
            string country = CountryTxb.Text;
            string birthCountry = BirthCountryTxb.Text;

            if (firstName != "" && lastName != "" &&
                birthDate != "" && address != "" &&
                city != "" && country != "")
            {
                Controller.CreateNewPerson(
                    firstName, secondName, lastName,
                    gender, birthDate, address, city,
                    country, birthCountry);

                ClearTextBoxes();
                MessageBox.Show("New person added");
            }
            else if (firstName == "" && lastName == "" &&
                birthDate == "" && address == "" &&
                city == "" && country == "")
            {

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
