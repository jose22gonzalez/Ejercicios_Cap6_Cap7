/*Hacer el programa que calcula el
promedio, calificación máxima y mínima
de un salón de clases usando el ArrayList.*/
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
    /// Interaction logic for Ejercicio1.xaml
    /// </summary>
    public partial class Ejercicio1 : Window
    {
       
        List<float> calificacion = new List<float>();
        public Ejercicio1()
        {
            InitializeComponent();
        }

        public void ClickButton_Agregar(object sender, RoutedEventArgs e)
        {
            
             int cali = Convert.ToInt32(Calificacion.Text);
             calificacion.Add(cali);
             Calificacion.Text = "";
        }

        public void ClickButton_Calcular(object sender, RoutedEventArgs e)
        {
            CalcularPromedio();
            Mayor_Menor();
        }

        public void CalcularPromedio()
        {
            float suma = 0;
            float promedio = 0;

            for(int i = 0; i < calificacion.Count; i++)
            {
                suma += calificacion[i];
            }

            promedio = suma / calificacion.Count;
            promedio1.Text = promedio.ToString();

            
        }

        public void Mayor_Menor()
        {
            float mayor = 0;
            float menor = 0;
            mayor = calificacion.Max();
            menor = calificacion.Min();

            mayor1.Text = mayor.ToString();
            menor1.Text = menor.ToString();
        }

    }
}
