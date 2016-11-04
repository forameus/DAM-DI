using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace _01_HelloWorldUW_CS
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string res = "";
            Random r = new Random();

            //Crear arrays
            char[] vocales = "aeiou".ToCharArray();
            char[] consonantes = "bcdfhjlmnprstvz".ToCharArray();
            bool vocal = true;

            //Empiezo a meter letras
            res += Char.ToUpper((char)consonantes.GetValue(r.Next(0, consonantes.GetLength(0))));
            for (int i = 0; i < r.Next(5,15); i++)
            {
                if (vocal)
                {
                    res += (char)vocales.GetValue(r.Next(0, 5));
                    vocal = false;
                }
                else
                {
                    res += (char)consonantes.GetValue(r.Next(0, consonantes.GetLength(0)));
                    vocal = true;
                }
            }

            if (r.Next(0, 10) == 1)
                res = "Fernando";            

            textBlock.Text = res;
            t1.Text = res; t2.Text = res; t3.Text = res;t4.Text = res; t5.Text = res;
        }
    }
}
