﻿using System;
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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=234238

namespace _21_App
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class PepePage : Page
    {
        private Random ran;
        private string[] uris = { "ms-appx:///Assets/pepe1.jpg", "ms-appx:///Assets/pepe2.jpg", "ms-appx:///Assets/pepe3.jpg", "ms-appx:///Assets/pepe4.jpg", "ms-appx:///Assets/pepe5.jpg", "ms-appx:///Assets/pepe6.jpg" };

        public PepePage()
        {
            this.InitializeComponent();
            ran = new Random();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string s = uris[ran.Next(1, uris.Length)];
            fotoPepe.Source = new BitmapImage(new Uri(s, UriKind.Absolute));
        }
    }
}
