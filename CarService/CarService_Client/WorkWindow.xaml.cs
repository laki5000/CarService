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

            if(data != null)
            {
                _data = data;

                TextBoxName.Text = _data.Name;
                TextBoxCarMake.Text = _data.Type;
                TextBoxLicensePlate.Text = _data.PlateNumber;
                TextBoxYear.Text = _data.ManufactureYear.ToString();
                TextBoxWorkCategory.Text = _data.WorkCategory;
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
            return true;
        }

        private void HandleButtonCreateClicked(object sender, RoutedEventArgs e)
        {
            if(ValidateData())
            {
                _data.Name = TextBoxName.Text;
                _data.Type = TextBoxCarMake.Text;
                _data.PlateNumber = TextBoxLicensePlate.Text;
                _data.ManufactureYear = int.Parse(TextBoxYear.Text);
                _data.WorkCategory = TextBoxWorkCategory.Text;
                _data.Description = TextBoxShortDescription.Text;
                _data.Seriousness = int.Parse(TextBoxSeverity.Text);
                _data.Status = "Felvett munka";

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
                _data.WorkCategory = TextBoxWorkCategory.Text;
                _data.Description = TextBoxShortDescription.Text;
                _data.Seriousness = int.Parse(TextBoxSeverity.Text);

                DataDataProvider.UpdateData(_data);

                DialogResult = true;
                Close();
            }
        }
    }
}
