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
            string firstName = FirstNameTxb.Text;
            string secondName = SecondNameTxb.Text = "";
            string lastName = LastNameTxb.Text = "";
            bool gender = true;
            if (GenderRbtnMale.IsChecked == true && GenderRbtnFemale.IsChecked == false)
            {
                gender = true;
            }
            else if (GenderRbtnMale.IsChecked == false && GenderRbtnFemale.IsChecked == true)
            {
                gender = false;
            }
            string birthDate = BirthDateTxb.Text;
            string address = AddressTxb.Text;
            string city = CityTxb.Text;
            string country = CountryTxb.Text;
            string birthCountry = BirthCountryTxb.Text;

            Controller.CreateNewPerson(
                firstName,secondName,lastName,
                gender,birthDate,address,city,
                country,birthCountry);
        }

        private void ClearPersonBtn_Click(object sender, RoutedEventArgs e)
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
        private void ShowFirstPersonBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ShowNextPersonBtn_Click(object sender, RoutedEventArgs e)
        {

        }


    }
}
