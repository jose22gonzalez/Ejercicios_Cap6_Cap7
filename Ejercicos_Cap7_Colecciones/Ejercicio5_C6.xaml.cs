/*Hacer un programa que funcione como
una agenda telefónica y que guarde el
nombre de la persona y su número
telefónico.*/
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
    /// Interaction logic for Ejercicio5_C6.xaml
    /// </summary>
    public partial class Ejercicio5_C6 : Window
    {
         Hashtable dato = new Hashtable();
        public Ejercicio5_C6()
        {
            InitializeComponent();
        }

        public void ClickAgregar_Button(object sender, RoutedEventArgs e)
        {
            dato.Add(nombre.Text, numero.Text);
            nombre.Text = "";
            numero.Text = "";
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
