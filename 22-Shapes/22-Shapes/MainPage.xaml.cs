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
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace _22_Shapes
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Random ra = new Random();
        private int x = 0;
        private int y = 0;

        public MainPage()
        {
            this.InitializeComponent();
            
        }
        

        private void Canvas_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            Storyboard storyboard = new Storyboard();

            DoubleAnimation translateYAnimation = new DoubleAnimation();
            
            translateYAnimation.From = y;
            y = ra.Next(0, 600);
            translateYAnimation.To = y;
            translateYAnimation.Duration = new Duration(TimeSpan.FromMilliseconds(100));
            Storyboard.SetTarget(translateYAnimation, CirculoA); Storyboard.SetTargetProperty(translateYAnimation, "(Ellipse.RenderTransform).(TranslateTransform.Y)");
            storyboard.Children.Add(translateYAnimation);

            DoubleAnimation translateXAnimation = new DoubleAnimation();
            translateXAnimation.From = x;
            x = ra.Next(0, 600);
            translateXAnimation.To = x;
            translateXAnimation.Duration = new Duration(TimeSpan.FromMilliseconds(100));
            Storyboard.SetTarget(translateXAnimation, CirculoA); Storyboard.SetTargetProperty(translateXAnimation, "(Ellipse.RenderTransform).(TranslateTransform.X)");
            storyboard.Children.Add(translateXAnimation);
            storyboard.Begin();
        }
    }
}
