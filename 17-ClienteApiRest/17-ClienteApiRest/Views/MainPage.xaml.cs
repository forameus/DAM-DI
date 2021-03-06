﻿using _17_ClienteApiRest.ViewModels;
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

namespace _17_ClienteApiRest
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public clsMainPageVM ViewModel { get; }

        public MainPage()
        {
            this.InitializeComponent();
            this.ViewModel = (clsMainPageVM) this.DataContext;            
        }

        public void btnGuardar_Click(Object sender, RoutedEventArgs e)
        {
            txtNombre.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            txtApellidos.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            txtFechaNac.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            txtFechaNac.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            txtDireccion.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            //lvPersonas.GetBindingExpression(ListView.ItemsSourceProperty).UpdateSource();
        }
    }
}
