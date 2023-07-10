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

namespace CheckYComboBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Capitales> capi = new List<Capitales>();
            capi.Add(new Capitales { NombreCapital="Lanus"});
            capi.Add(new Capitales { NombreCapital = "Banfield" });
            capi.Add(new Capitales { NombreCapital = "Lomas" });
            capi.Add(new Capitales { NombreCapital = "Longchamps" });
            capi.Add(new Capitales { NombreCapital = "Microcentro" });

            Ciudades.ItemsSource = capi;
        }

        private void checkTodasCapi_Checked(object sender, RoutedEventArgs e)
        {
            Lanus.IsChecked = true;
            Banfield.IsChecked = true;
            Lomas.IsChecked = true;
            Longchamps.IsChecked = true;
            Microcentro.IsChecked = true;
        }

        private void checkTodasCapi_Unchecked(object sender, RoutedEventArgs e)
        {
            Lanus.IsChecked = false;
            Banfield.IsChecked = false;
            Lomas.IsChecked = false;
            Longchamps.IsChecked = false;
            Microcentro.IsChecked = false;
        }

        private void Individual_Checked(object sender, RoutedEventArgs e)
        {
            if (Lanus.IsChecked==true && Banfield.IsChecked == true && Lomas.IsChecked == true
                && Longchamps.IsChecked == true && Microcentro.IsChecked == true)
            {
                checkTodasCapi.IsChecked = true;
            }
            else{ checkTodasCapi.IsChecked = null; }
        }
      

        private void Individual_Unchecked(object sender, RoutedEventArgs e)
        {
            if (Lanus.IsChecked == false && Banfield.IsChecked == false && Lomas.IsChecked == false
                && Longchamps.IsChecked == false && Microcentro.IsChecked == false)
            {
                checkTodasCapi.IsChecked = false;
            }
            else{ checkTodasCapi.IsChecked = null; }
        }
    }

    public class Capitales
    {
        public string NombreCapital { get; set; }
    }
}
