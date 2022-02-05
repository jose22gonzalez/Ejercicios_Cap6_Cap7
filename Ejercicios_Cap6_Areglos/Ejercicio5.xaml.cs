/*Crear un programa que pase un arreglo
jagged como parámetro a una función.*/
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

namespace Ejercicios_Cap6_Cap7.Ejercicios_Cap6_Areglos
{
    /// <summary>
    /// Interaction logic for Ejercicio5.xaml
    /// </summary>
    public partial class Ejercicio5 : Window
    {
        
        int[] numeros = new int[5];
        public Ejercicio5()
        {
            InitializeComponent();
        }
        
        public void ClickAgregar_Button(object sender, RoutedEventArgs e)
        {
            Agregar();

        }

        public void ClcikMostrar_Button(object sender, RoutedEventArgs e)
        {
            mostar();
        }

        public void Agregar()
        {
            
            int indice = 0;
            int num = Convert.ToInt32(numero.Text);

            if (indice <= numeros.Length)
            {
                numeros[indice] = num;
               
                numero.Text = "";
                indice = indice + 1;
            }
            

        }

        public void mostar()
        {
            for (int i = 0; i < numeros.Length; i++)
                {
                    MostrarArreglo.Items.Add(numeros[i]);
                }
        }

    }
}
