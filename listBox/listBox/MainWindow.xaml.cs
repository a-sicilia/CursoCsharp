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

namespace listBox
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Poblaciones> listPobl=new List<Poblaciones>();

            listPobl.Add(new Poblaciones() { Poblacion1="Lanus", Poblacion2="Banfield",temp1=15, temp2=18, difTemp=3});
            listPobl.Add(new Poblaciones() { Poblacion1 = "Avella", Poblacion2 = "Lomas", temp1 = 20, temp2 = 25, difTemp =5});
            listPobl.Add(new Poblaciones() { Poblacion1 = "Glew", Poblacion2 = "Martinez", temp1 = 30, temp2 = 35, difTemp =50});
            listPobl.Add(new Poblaciones() { Poblacion1 = "Belgrano", Poblacion2 = "Palomar", temp1 = 5, temp2 = 10 , difTemp = 5 });


            listaPoblaciones.ItemsSource = listPobl;

        }

        private void boton_Click(object sender, RoutedEventArgs e)
        {
            try { 
            MessageBox.Show((listaPoblaciones.SelectedItem as Poblaciones).Poblacion1 + " " +
                (listaPoblaciones.SelectedItem as Poblaciones).temp1 + " " +
                (listaPoblaciones.SelectedItem as Poblaciones).Poblacion2 + " " +
                (listaPoblaciones.SelectedItem as Poblaciones).temp2 + " " 
                ) ;
            }catch(Exception ex)
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void TextBlock_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                MessageBox.Show((listaPoblaciones.SelectedItem as Poblaciones).Poblacion1 + " " +
                    (listaPoblaciones.SelectedItem as Poblaciones).temp1 + " " +
                    (listaPoblaciones.SelectedItem as Poblaciones).Poblacion2 + " " +
                    (listaPoblaciones.SelectedItem as Poblaciones).temp2 + " "
                    );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione una fila");
            }
        }
    }


    public class Poblaciones
    {
        public string Poblacion1 { get; set; }
        public int temp1 { get; set; }
        public string Poblacion2 { get; set; }
        public int temp2 { get; set; }

        public int difTemp { 
            get;
            set;
        }

    }
}
