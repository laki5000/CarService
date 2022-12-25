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

namespace CarService_Client
{
    /// <summary>
    /// Interaction logic for Client.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            UpdateDataListBox();
        }

        private void List_SelectionChanged(object sender, SelectionChangedEventArgs args)
        {
            var selectedData = ClientListBox.SelectedItem as Data;

            if (selectedData != null)
            {
                var window = new WorkWindow(selectedData);
                if (window.ShowDialog() ?? false)
                {
                    UpdateDataListBox();
                }

                ClientListBox.UnselectAll();
            }
        }

        private void HandleSubmitButtonClicked(object sender, RoutedEventArgs e)
        {
            WorkWindow ww = new WorkWindow(null);
            if (ww.ShowDialog() ?? false)
            {
                UpdateDataListBox();
            }
        }
        private void UpdateDataListBox()
        {
            var AllData = DataDataProvider.GetAllData().ToList();
            ClientListBox.ItemsSource = AllData;

        }

        private void HandleRefreshButtonClicked(object sender, RoutedEventArgs e)
        {
            UpdateDataListBox();
        }

        //HandleFilterButtonClicked
        private void HandleOrderByButtonClicked(object sender, RoutedEventArgs e)
        {
            var AllData = DataDataProvider.GetAllData();

            switch (ComboBoxOrderBy.SelectedIndex)
            {
                case 0:
                    break;
                case 1: 
                    AllData = AllData.OrderBy(x => x.Name);
                    break;
                case 2:
                    AllData = AllData.OrderBy(x => x.Type);
                    break;
                case 3:
                    AllData = AllData.OrderBy(x => x.PlateNumber);
                    break;
                case 4:
                    AllData = AllData.OrderBy(x => x.ManufactureYear);
                    break;
                case 5:
                    AllData = AllData.OrderBy(x => x.WorkCategory);
                    break;
                case 6:
                    AllData = AllData.OrderBy(x => x.Description);
                    break;
                case 7:
                    AllData = AllData.OrderBy(x => x.Seriousness);
                    break;

                default: break;
            }

            if (ComboBoxAsc.SelectedIndex == 1)
            {
                AllData = AllData.Reverse();
            }

            ClientListBox.ItemsSource = AllData.ToList();



            //UpdateDataListBox();
        }

    }
}
