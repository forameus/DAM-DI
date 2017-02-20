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
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace _24_Animaciones
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        private Storyboard storyboard = new Storyboard();
        private bool rotando;
        BitmapImage fotoAntes = new BitmapImage(new Uri("ms-appx:///Assets/before.jpg"));
        BitmapImage fotoDespues = new BitmapImage(new Uri("ms-appx:///Assets/bofeton.jpg"));

        public MainPage()
        {
            rotando = false;            
            this.InitializeComponent();
            Foto.Source = fotoAntes;
        }

        public void rotarClick(object sender, RoutedEventArgs e)
        {
            rotar();
        }


        public void rotar()
        {
            if (rotando)
            {
                Foto.Source = fotoAntes;
                storyboard.Stop();
                rotando = false;
            }
            else
            {
                Foto.Source = fotoDespues;
                DoubleAnimation animation = new DoubleAnimation();
                animation.From = 360.0;
                animation.To = 0.0;
                //animation.BeginTime = TimeSpan.FromSeconds(1);
                animation.RepeatBehavior = RepeatBehavior.Forever;
                Storyboard.SetTarget(animation, Foto);
                Storyboard.SetTargetProperty(animation, "(UIElement.Projection).(PlaneProjection.RotationY)");
                //rotation.Children.Clear();
                storyboard.Children.Add(animation);
                storyboard.Begin();
                rotando = true;
            }
        }

              
    }
}
