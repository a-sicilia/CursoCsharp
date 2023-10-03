using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DependencyProperties
{
    public partial class MainWindow : Window
    {
        //Creamos la propiedad
        public int MiProperty
        {
            get { return (int)GetValue(MiPropertyDependency);}

            set { SetValue(MiPropertyDependency, value); }


        }

        //Dependencia a la propiedad
        public static readonly DependencyProperty MiPropertyDependency = 
            DependencyProperty.Register("MiProperty",typeof(int),typeof(MainWindow),new PropertyMetadata(0));



        public MainWindow()
        {
            InitializeComponent();

            
        }
    }
}
