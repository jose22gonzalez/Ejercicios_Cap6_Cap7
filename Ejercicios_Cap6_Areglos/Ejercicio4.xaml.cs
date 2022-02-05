/*Modificar el programa de la escuela para
que utilice funciones.*/
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
    /// Interaction logic for Ejercicio4.xaml
    /// </summary>
    public partial class Ejercicio4 : Window
    {
        private int[] calificaciones = new int[5];
        private int indice = 0;
        public Ejercicio4()
        {
            InitializeComponent();
        }

        public void ClickButton_Agregar(object sender, RoutedEventArgs e)
        {
            int cali = Convert.ToInt32(Calificacion1.Text);
            
            if (indice <= calificaciones.Length)
            {
                calificaciones[indice] = cali;
                Calificacion1.Text = " ";
                indice = indice + 1;
            }
        }

        public void ClickButton_Calcular(object sender, RoutedEventArgs e)
        {
            Calcular_Promedio();
            Calificacion_Mayor();
            Calificacion_Menor();
        }

        public void Calcular_Promedio()
        {
            int suma = 0;
            float promedio = 0.0f;
            int control = 0;
        
            for (int i = 0; i < calificaciones.Length; i++)
            {
                suma += calificaciones[i];
                control = control + 1;
            }
            promedio = suma / control;
            promedio12.Text = promedio.ToString();

        }

        public void Calificacion_Mayor()
        {
            int mayor = 0;
            mayor = calificaciones.Max();
            mayor12.Text = mayor.ToString();
            
        }

        public void Calificacion_Menor()
        {
            int menor = 0;
            menor = calificaciones.Min();
            menor12.Text = menor.ToString();
        }
    }
}
