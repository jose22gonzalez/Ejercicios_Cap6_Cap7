/*Hacer un programa que funcione como un
diccionario, con palabra y definición,
usando el Hashtable.*/
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
using System.Collections;

namespace Ejercicios_Cap6_Cap7.Ejercicos_Cap7_Colecciones
{
    /// <summary>
    /// Interaction logic for Ejercicio2.xaml
    /// </summary>
    public partial class Ejercicio2 : Window
    {
        Hashtable dato = new Hashtable();
        public Ejercicio2()
        {
            InitializeComponent();
        }

        public void ClickAgregar_Button(object sender, RoutedEventArgs e)
        {
            dato.Add(palabra.Text, significado.Text);
            palabra.Text = "";
            significado.Text = "";


        }

        public void ClcikMostrar_Button(object sender, RoutedEventArgs e)
        {
            Mostrar();
        }

        public void Mostrar()
        {
            
            foreach(DictionaryEntry  tablaHash in dato)
            {
                tabla.Items.Add(tablaHash.Key);
                tabla.Items.Add(tablaHash.Value);
            }
        }
    }
}
