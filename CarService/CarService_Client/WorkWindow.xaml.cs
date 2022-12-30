using CarService_Client.DataProviders;
using CarService_Common.Models;
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
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace CarService_Client
{
    /// <summary>
    /// Interaction logic for WorkWindow.xaml
    /// </summary>
    public partial class WorkWindow : Window
    {
        private readonly Data _data;
        public WorkWindow(Data data)
        {
            InitializeComponent();

            if (data != null)
            {
                _data = data;

                TextBoxName.Text = _data.Name;
                TextBoxCarMake.Text = _data.Type;
                TextBoxLicensePlate.Text = _data.PlateNumber;
                TextBoxYear.Text = _data.ManufactureYear.ToString();
                ComboBoxWorkCategory.Text = _data.WorkCategory;
                TextBoxShortDescription.Text = _data.Description;
                TextBoxSeverity.Text = _data.Seriousness.ToString();

                ButtonCreate.Visibility = Visibility.Collapsed;
                ButtonUpdate.Visibility = Visibility.Visible;
            }
            else
            {
                _data = new Data();
                ButtonCreate.Visibility = Visibility.Visible;
                ButtonUpdate.Visibility = Visibility.Collapsed;
            }
        }


        private bool ValidateData()
        {
            //TODO
            if (ValidateString(TextBoxName.Text) && ValidateString(TextBoxCarMake.Text))
            {
                if (ValidateNumber(TextBoxYear.Text) && ValidateNumber(TextBoxSeverity.Text))
                {
                    if (ValidateLicensePlate(TextBoxLicensePlate.Text) && ValidateSeverity(TextBoxSeverity.Text))
                    {
                        return true;
                    }
                }
            }

            return false;
        }



        private void HandleButtonCreateClicked(object sender, RoutedEventArgs e)
        {
            if (ValidateData())
            {
                _data.Name = TextBoxName.Text;
                _data.Type = TextBoxCarMake.Text;
                _data.PlateNumber = TextBoxLicensePlate.Text;
                _data.ManufactureYear = int.Parse(TextBoxYear.Text);
                _data.WorkCategory = ComboBoxWorkCategory.Text;
                _data.Description = TextBoxShortDescription.Text;
                _data.Seriousness = int.Parse(TextBoxSeverity.Text);
                _data.Status = "Open";
                _data.WorkHourEstimation = 1;

                DataDataProvider.CreateData(_data);

                DialogResult = true;
                Close();
            }
        }

        private void HandleButtonUpdateClicked(object sender, RoutedEventArgs e)
        {
            if (ValidateData())
            {
                _data.Name = TextBoxName.Text;
                _data.Type = TextBoxCarMake.Text;
                _data.PlateNumber = TextBoxLicensePlate.Text;
                _data.ManufactureYear = int.Parse(TextBoxYear.Text);
                _data.WorkCategory = ComboBoxWorkCategory.Text;
                _data.Description = TextBoxShortDescription.Text;
                _data.Seriousness = int.Parse(TextBoxSeverity.Text);

                DataDataProvider.UpdateData(_data);

                DialogResult = true;
                Close();
            }
        }

        public static bool ValidateString(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("The field cannot be empty!");
                return false;
            }
            if (string.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show("The field cannot be whitespace!");
                return false;
            }

            string[] SpecialCharacters = { "!", "?", "_", "-", ":", ";", "#" };

            if (SpecialCharacters.Any(text.Contains))
            {
                //stringArray.Any(stringToCheck.Contains)
                MessageBox.Show("The field cannot contain special characters!");
                return false;
            }

            return true;
        }

        public static bool ValidateNumber(string text)
        {
            if (!text.ToString().All(c => char.IsDigit(c)))
            {
                MessageBox.Show("The field Year and Severity can only contain numbers!");
                return false;
            }

            return true;
        }

        public static bool ValidateLicensePlate(string text)
        {
            if (text.Contains('-'))
            {
                string[] pieces = text.Split("-");

                if (pieces.Length == 2 && pieces[0].Length == 3 &&
                    pieces[0].All(c => char.IsLetter(c)) && pieces[1].Length == 3 && pieces[1].All(c => char.IsDigit(c)))
                {
                    return true;
                }
            }

            MessageBox.Show("The license plate format must be XXX-000!");
            return false;
        }

        public static bool ValidateSeverity(string text)
        {
            if (ValidateNumber(text))
            {
                int number = int.Parse(text);

                if (number > 0 && number < 11)
                {
                    return true;
                }
            }

            MessageBox.Show("The severity must be a number between 1 and 10");
            return false;
        }
    }
}