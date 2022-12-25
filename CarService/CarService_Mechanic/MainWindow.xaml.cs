using CarService_Common.Models;
using CarService_Mechanic.DataProviders;
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

namespace CarService_Mechanic
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

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            Data data = new Data();
            data.Name = "Elso";
            data.Type = "Tipus";
            data.PlateNumber = "Tipus";
            data.ManufactureYear = 2002;
            data.WorkCategory = "Kat";
            data.Description = "Des";
            data.Seriousness = 5;
            DataDataProvider.CreateData(data);
        }
    }
}
