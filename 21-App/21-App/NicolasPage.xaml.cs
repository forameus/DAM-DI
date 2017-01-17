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

// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=234238

namespace _21_App
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class NicolasPage : Page
    {
        public NicolasPage()
        {
            this.InitializeComponent();
        }

        
        private void Slider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            caraCage1.Height = Slider.Value * 3;
            caraCage2.Height = Slider.Value * 3;
            caraCage3.Height = Slider.Value * 3;
            caraCage4.Height = Slider.Value * 3;
            caraCage5.Height = Slider.Value * 3;
        }
    }
}
