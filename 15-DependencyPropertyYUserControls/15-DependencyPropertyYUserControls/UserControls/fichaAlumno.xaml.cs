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

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace _15_DependencyPropertyYUserControls.UserControls
{
    public sealed partial class fichaAlumno : UserControl
    {
        public fichaAlumno()
        {
            this.InitializeComponent();
        }



        public string Nombre
        {
            get { return (string)GetValue(NombreProperty); }
            set { SetValue(NombreProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Nombre.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty NombreProperty =
            DependencyProperty.Register("Nombre", typeof(string), typeof(fichaAlumno), new PropertyMetadata(string.Empty));




        public string Apellidos
        {
            get { return (string)GetValue(ApellidosProperty); }
            set { SetValue(ApellidosProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Apellidos.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ApellidosProperty =
            DependencyProperty.Register("Apellidos", typeof(string), typeof(fichaAlumno), new PropertyMetadata(string.Empty));




        public ImageSource Foto
        {
            get { return (ImageSource)GetValue(FotoProperty); }
            set { SetValue(FotoProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Foto.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FotoProperty =
            DependencyProperty.Register("Foto", typeof(ImageSource), typeof(fichaAlumno), new PropertyMetadata(new BitmapImage(new Uri("http://www.zonanortenoticias.com/wp-content/uploads/2016/03/anonymous.jpg"))));







    }
}
