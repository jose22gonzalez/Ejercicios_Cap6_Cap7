/* 
1. Agregar el cálculo del promedio para el programa con arreglo jagged.
2. Agregar el cálculo de la menor calificación para el programa con arreglo jagged.
3. Agregar el cálculo de la mayor calificación para el programa con arreglo jagged.
*/
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
using Ejercicios_Cap6_Cap7;

namespace Ejercicios_Cap6_Cap7.Ejercicios_Cap6_Areglos
{
    /// <summary>
    /// Interaction logic for Ejercicio1_2_3.xaml
    /// </summary>
    public partial class Ejercicio1_2_3 : Window
    {
        
      
       private int[] calificaciones = new int[5];
        private int indice = 0;

        public Ejercicio1_2_3()
        {

            InitializeComponent();

        }

         
        public void ClickButton_Agregar(object sender, RoutedEventArgs e)
        {
            int cali = Convert.ToInt32(Calificacion.Text);
            
            if (indice <= calificaciones.Length)
            {
                calificaciones[indice] = cali;
                Calificacion.Text = " ";
                indice = indice + 1;
            }
        }

        public void ClickButton_Calcular(object sender, RoutedEventArgs e)
        {
            Calcular_Promedio();
        }

        public void Calcular_Promedio()
        {
            int suma = 0;
            float promedio = 0.0f;
            int control = 0;
            int mayor = 0;
            int menor = 0;

            for (int i = 0; i < calificaciones.Length; i++)
            {
                suma += calificaciones[i];
                control = control + 1;
            }
            promedio = suma / control;
            promedio1.Text = promedio.ToString();

            mayor = calificaciones.Max();
            menor = calificaciones.Min();

            mayor1.Text = mayor.ToString();
            menor1.Text = menor.ToString();
        }
    }
}
