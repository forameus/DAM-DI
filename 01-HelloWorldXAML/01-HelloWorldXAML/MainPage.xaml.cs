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

namespace _01_HelloWorldXAML
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private Button Boton3;

        public MainPage()
        {
            InitializeComponent();
            Boton3 = CrearBoton();
        }


        /// <summary>
        /// Crea un botón y lo pega en la página.
        /// </summary>
        /// <returns>Devuelve el botón creado.</returns>
        public Button CrearBoton()
        {
            Grid grid = miGrid;
            Button boton = new Button();
            boton.Name = "Boton3";
            boton.Content = "Boton3";
            boton.Background = new SolidColorBrush(Windows.UI.Colors.Blue);
            boton.HorizontalContentAlignment = Windows.UI.Xaml.HorizontalAlignment.Center;
            boton.VerticalContentAlignment = Windows.UI.Xaml.VerticalAlignment.Center;
            boton.Height = 70;
            boton.Width = 200;
            boton.FontFamily = new FontFamily("Verdana");
            boton.FontWeight = Windows.UI.Text.FontWeights.Bold;
            boton.FontSize = 16;
            boton.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Yellow);
            boton.VerticalAlignment = Windows.UI.Xaml.VerticalAlignment.Center;
            boton.HorizontalAlignment = Windows.UI.Xaml.HorizontalAlignment.Right;
            boton.Foreground = new SolidColorBrush(Windows.UI.Colors.White);

            grid.Children.Add(boton);

            boton.Click += btn_Click3;

            return boton;
        }

        void btn_Click1(object sender, RoutedEventArgs e)
        {
            Boton1.Background = new SolidColorBrush(Windows.UI.Colors.Gray);
            Boton2.Background = new SolidColorBrush(Windows.UI.Colors.Blue);
            Boton3.Background = new SolidColorBrush(Windows.UI.Colors.Blue);
            Texto.Text = "Has pulsado el botón 1";
        }

        void btn_Click2(object sender, RoutedEventArgs e)
        {
            Boton1.Background = new SolidColorBrush(Windows.UI.Colors.Blue);
            Boton2.Background = new SolidColorBrush(Windows.UI.Colors.Gray);
            Boton3.Background = new SolidColorBrush(Windows.UI.Colors.Blue);
            Texto.Text = "Has pulsado el botón 2";
        }

        void btn_Click3(object sender, RoutedEventArgs e)
        {
            Boton1.Background = new SolidColorBrush(Windows.UI.Colors.Blue);
            Boton2.Background = new SolidColorBrush(Windows.UI.Colors.Blue);
            Boton3.Background = new SolidColorBrush(Windows.UI.Colors.Gray);
            Texto.Text = "Has pulsado el botón 3";
        }
    }
}
