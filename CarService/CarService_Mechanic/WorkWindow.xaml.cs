using CarService_Common.Models;
using CarService_Mechanic.DataProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace CarService_Mechanic
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

            _data = data;

            TextBoxName.Text = _data.Name;
            TextBoxCarMake.Text = _data.Type;
            TextBoxLicensePlate.Text = _data.PlateNumber;
            TextBoxYear.Text = _data.ManufactureYear.ToString();
            TextBoxWorkCategory.Text = _data.WorkCategory;
            TextBoxShortDescription.Text = _data.Description;
            TextBoxSeverity.Text = _data.Seriousness.ToString();

            ButtonUpdate.Visibility = Visibility.Visible;

            if(_data.Status.Equals("Opened"))
            {
                StatusComboBox.SelectedIndex = 0;
            }
            else if (_data.Status.Equals("In Progress"))
            {
                StatusComboBox.SelectedIndex = 1;
            }
            else if (_data.Status.Equals("Completed"))
            {
                StatusComboBox.SelectedIndex = 2;
            }
        }

        private void HandleButtonUpdateClicked(object sender, RoutedEventArgs e)
        {
            _data.Status = StatusComboBox.Text.ToString();
            DataDataProvider.UpdateData(_data);

            DialogResult = true;
            Close();
        }
    }
}
