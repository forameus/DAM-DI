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
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace _21_App
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            Freim.Navigate(typeof(NicolasPage));
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Freim.Navigate(typeof(NicolasPage));
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            Freim.Navigate(typeof(PepePage));
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            Freim.Navigate(typeof(TrumpPage));
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            Freim.Navigate(typeof(BlackPage));
        }
    }
}
