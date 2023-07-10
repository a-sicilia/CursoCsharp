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

namespace InterfazGrafica
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Grid grid = new Grid();
            this.Content = grid;

            Button boton = new Button();
            boton.Width = 150;
            boton.Height = 50;
            //boton.Content = "Apretá";

            WrapPanel wrap = new WrapPanel();

            TextBlock txt1 = new TextBlock();
            TextBlock txt2 = new TextBlock();
            TextBlock txt3 = new TextBlock();


            txt1.FontSize = 20;
            txt2.FontSize = 20;
            txt3.FontSize = 25;

            txt1.Foreground = Brushes.Blue;
            txt2.Foreground = Brushes.Red;
            txt3.Foreground = Brushes.Yellow;

            txt1.FontFamily = new FontFamily("Comics sans");
                
            txt1.Text = "Hacé";
            txt2.Text = "Click";
            txt3.Text = "Aquí";

            wrap.Children.Add(txt1);
            wrap.Children.Add(txt2);
            wrap.Children.Add(txt3);

            boton.Content = wrap;
            grid.Children.Add(boton);
        }
    }
}
