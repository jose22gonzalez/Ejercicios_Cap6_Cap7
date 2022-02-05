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
using Ejercicios_Cap6_Cap7.Ejercicios_Cap6_Areglos;
using Ejercicios_Cap6_Cap7.Ejercicos_Cap7_Colecciones;


namespace Ejercicios_Cap6_Cap7
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

        public void Ejercicio1_2_3C6_MenuClick(object sender, RoutedEventArgs e)
        {
            Ejercicio1_2_3 e123 = new Ejercicio1_2_3();
            e123.Show();
        }

        public void Ejercicio4C6_MenuClick(object sender, RoutedEventArgs e)
        {
            Ejercicio4 e4 = new Ejercicio4();
            e4.Show();
        }

        public void Ejercicio5C6_MenuClick(object sender, RoutedEventArgs e)
        {
            Ejercicio5 e5 = new Ejercicio5();
            e5.Show();
        }

        //Ejercicios del capitulo 7
        public void Ejercico1C7_MenuClick(object sender, RoutedEventArgs e)
        {
            Ejercicio1 e1 = new Ejercicio1();
            e1.Show();
        }

        public void Ejercicio2C7_MenuClick(object sender, RoutedEventArgs e)
        {
            Ejercicio2 e2 = new Ejercicio2();
            e2.Show();
        }

        public void Ejercicio5C7_MenuClick(object sender, RoutedEventArgs e)
        {
            Ejercicio5_C6 ec5 = new Ejercicio5_C6();
            ec5.Show();
        }


        
    }
}
