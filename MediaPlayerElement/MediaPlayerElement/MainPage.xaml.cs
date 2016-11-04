using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media;
using Windows.Media.Core;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MediaPlayerElement
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        //Variables
        private int videoActual = 0;
        private string[] videos;


        public MainPage()
        {
            this.InitializeComponent();

            //Cargar vídeo desde URI
            Uri pathUri = new Uri("ms-appx:///Videos/video1.mp4");
            reproductor.Source = MediaSource.CreateFromUri(pathUri);

            //Crear Array de URIs
            videos = new string[3] { "ms-appx:///Videos/video1.mp4", "ms-appx:///Videos/video2.mp4", "ms-appx:///Videos/video3.mp4" };
        }

        private async void Cargar_Click(object sender, RoutedEventArgs e)
        {
            //Crear y configurar el explorador de archivos.
            FileOpenPicker fop = new FileOpenPicker();
            fop.SuggestedStartLocation = PickerLocationId.VideosLibrary;
            fop.FileTypeFilter.Add(".mp4");

            //Asignar el archivo al explorador
            StorageFile file = await fop.PickSingleFileAsync();

            //Reproducir archivo si no es nulo.
            if (file != null)
            {
                var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
                reproductor.Source = MediaSource.CreateFromStorageFile(file);
                
                reproductor.MediaPlayer.Play();
            }
        }

        //Cargar vídeo anterior
        private void btnAnt_Click(object sender, RoutedEventArgs e)
        {
            if (videoActual != 0)
            {
                videoActual--;
                Uri pathUri = new Uri(videos[videoActual]);
                reproductor.Source = MediaSource.CreateFromUri(pathUri);
            }
        }

        //Cargar vídeo posterior
        private void btnSig_Click(object sender, RoutedEventArgs e)
        {
            if (videoActual != 2)
            {
                videoActual++;
                Uri pathUri = new Uri(videos[videoActual]);
                reproductor.Source = MediaSource.CreateFromUri(pathUri);
            }
        }



        //Alternar repetición
        private void btnRep_Click(object sender, RoutedEventArgs e)
        {
            if (reproductor.MediaPlayer.IsLoopingEnabled)
            {
                reproductor.MediaPlayer.IsLoopingEnabled = false;
                txtRep.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
            }
            else
            {
                reproductor.MediaPlayer.IsLoopingEnabled = true;
                txtRep.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
            }
        }
    }
}
