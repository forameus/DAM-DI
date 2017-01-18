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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace _21_App
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class TrumpPage : Page
    {
        private string[] uris = { "ms-appx:///Assets/trump1.jpg", "ms-appx:///Assets/trump2.jpg", "ms-appx:///Assets/trump3.jpg", "ms-appx:///Assets/trump4.jpg", "ms-appx:///Assets/trump5.jpg", "ms-appx:///Assets/trump6.jpg" };
        private int sigImagen = 1;

        public TrumpPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string s = uris[sigImagen];
            fotoTrump.Source = new BitmapImage(new Uri(s, UriKind.Absolute));
            sigImagen = sigImagen==uris.Length-1?sigImagen=0:sigImagen+1;
        }
    }
}
