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

// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace _12_Controls
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            cal1.MinDate = DateTime.Now;
            cal2.IsEnabled = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (rbYes.IsChecked == true)
            {
                RadioButtons.Background = new ImageBrush
                {
                    Stretch = Windows.UI.Xaml.Media.Stretch.UniformToFill,
                    ImageSource =
            new BitmapImage { UriSource = new Uri("ms-appx:///Assets/yes.jpg") }
                };
            }
            if (rbNo.IsChecked == true)
            {
                RadioButtons.Background = new ImageBrush
                {
                    Stretch = Windows.UI.Xaml.Media.Stretch.UniformToFill,
                    ImageSource =
           new BitmapImage { UriSource = new Uri("ms-appx:///Assets/no.jpg") }
                };
            }
            if (rbMaybe.IsChecked == true)
            {
                                  
            }
        }

        private void cal1_DateChanged(CalendarDatePicker sender, CalendarDatePickerDateChangedEventArgs args)
        {
            DateTimeOffset f = (DateTimeOffset) sender.Date;            
            cal2.MinDate = f;
            cal2.IsEnabled = true;

            if (cal2.Date < cal1.Date)
                cal2.Date = cal1.Date;
        }

        private void cal2_DateChanged(CalendarDatePicker sender, CalendarDatePickerDateChangedEventArgs args)
        {
            TimeSpan duracion = (TimeSpan) (cal2.Date - cal1.Date);            
            //txtCal.Text = "Has seleccionado un viaje de "+" días.";
            txtCal.Text = String.Format("Ha reservado {0} días", (int) duracion.TotalDays);
        }
    }
}
