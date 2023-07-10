using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace EventosBoton
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("APRETASTEEEEEEEEEEEE
            Debug.WriteLine("Tocaste el BOTON");
            
            

        }

       /* private void Panel_Click(object sender, RoutedEventArgs e)
        {

            Debug.WriteLine("Le diste al STACKPANEL");

        }*/

        private void Panel_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Debug.WriteLine("Le diste al STACKPANEL");
        }
    }
}
