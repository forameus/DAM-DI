using Examen_DI.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Examen_DI
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
       public clsMainPageVM ViewModel { get; }
        Stopwatch miReloj = new Stopwatch();

        public MainPage()
        {
            this.InitializeComponent();
            this.ViewModel = (clsMainPageVM) this.DataContext;
            
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += timer_Tick;
            timer.Start();

            miReloj.Start();

        }

        void timer_Tick(object sender, object e)
        {
            if(ViewModel._puntuacion!=6)
                txbTimer.Text = string.Format("{0}:{1}:{2}", miReloj.Elapsed.Hours.ToString(), miReloj.Elapsed.Minutes.ToString(), miReloj.Elapsed.Seconds.ToString());
        }


        /// <summary>
        /// Reinicia el reloj y los elementos del juego
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReiniciar_Click(object sender, RoutedEventArgs e)
        {
            miReloj.Reset();
            ViewModel.repetir();
            miReloj.Start();
        }
    }
}
