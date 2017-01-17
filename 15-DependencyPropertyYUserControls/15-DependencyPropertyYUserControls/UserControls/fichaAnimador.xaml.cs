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

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace _15_DependencyPropertyYUserControls.UserControls
{
    public sealed partial class fichaAnimador : UserControl
    {
        //public static string html = @"<iframe width=""300"" height=""180"" src=""http://www.youtube.com/embed/tYrND5hMY3A?rel=0&autoplay=1"" frameborder=""0"" allowfullscreen></iframe>";

        //"<iframe width="300" height="180" src="http://www.youtube.com/embed/tYrND5hMY3A?rel=0&autoplay=1" frameborder="0" allowfullscreen></iframe>";

        //public static string html = @"https://www.google.es/";
        //public static string html = "http://www.youtube.com/embed/tYrND5hMY3A";
        public static string html = "<iframe width=\"300\" height=\"180\" src =\"http://www.youtube.com/embed/tYrND5hMY3A?rel=0&autoplay=1\" frameborder =\"0\" allowfullscreen ></iframe>";

        public static string part1 = "<iframe width=\"300\" height=\"180\" src =\"http:"+"/"+"/"+"www.youtube.com"+"/"+"embed"+"/";
        public static string part2 = "?rel=0&autoplay=1\" frameborder =\"0\" allowfullscreen ></iframe>";

        public fichaAnimador()
        {
            this.InitializeComponent();
            this.Video = part1 + "tYrND5hMY3A" + part2;

            //html = "<iframe width=\"300\" height=\"180\" src =\"http://www.youtube.com/embed/tYrND5hMY3A?rel=0&autoplay=1\" frameborder =\"0\" allowfullscreen ></iframe>";

            wvVideo.NavigateToString(this.Video);
        }




        public string Video
        {
            get { return (string)GetValue(VideoProperty); }
            set { SetValue(VideoProperty, part1+value+part2); }
        }

       


        // Using a DependencyProperty as the backing store for Video.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty VideoProperty =
            DependencyProperty.Register("Video", typeof(string), typeof(fichaAnimador), new PropertyMetadata(html));




        public string Nombre
        {
            get { return (string)GetValue(NombreProperty); }
            set { SetValue(NombreProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Nombre.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty NombreProperty =
            DependencyProperty.Register("Nombre", typeof(string), typeof(fichaAnimador), new PropertyMetadata(string.Empty));



    }
}
