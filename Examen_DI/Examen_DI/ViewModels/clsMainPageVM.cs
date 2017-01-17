using Examen_DI.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace Examen_DI.ViewModels
{
    public class clsMainPageVM : INotifyPropertyChanged
    {
        //Propiedades
        public string _mensaje { get; set; }
        public int _puntuacion { get; set; }
        private clsFoto _fotoSeleccionada1;
        private clsFoto _fotoSeleccionada2;
        
        public ObservableCollection<clsFoto> conjunto { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        // private DelegateCommand _emparejarCommand;

        public clsMainPageVM()
        {
            conjunto = new clsConjuntos().conjunto;
            _puntuacion = 0;
            _mensaje = "¡BUENA SUERTE!";
        }

        public clsFoto Foto
        {
            get
            {
                return _fotoSeleccionada1;
            }

            set
            {
                //En caso de que se haya seleccionado una foto, le asigna su imagen correspondiente
                if (_fotoSeleccionada1 == null)
                {
                    _fotoSeleccionada1 = value;
                    _fotoSeleccionada1.Imagen = "ms-appx:///Assets/" + _fotoSeleccionada1.Nombre + ".jpg";
                    OnProperyChanged("Foto");
                }
                //En caso de que se haya seleccionado la segunda foto, se comprueba si coinciden
                else if (_fotoSeleccionada2 == null)
                {
                    _fotoSeleccionada2 = value;
                    _fotoSeleccionada2.Imagen = "ms-appx:///Assets/" + _fotoSeleccionada2.Nombre + ".jpg";
                    OnProperyChanged("Foto");

                    emparejar();
                }

            }
        }

        protected void OnProperyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }


        /// <summary>
        /// Comprueba si se han seleccionado dos fotos iguales y hace las acciones pertinentes
        /// </summary>
        public async void emparejar()
        {
            //Si coinciden...
            if (_fotoSeleccionada1.Pareja == _fotoSeleccionada2.Nombre)
            {
                _puntuacion++;
                _fotoSeleccionada1 = null; _fotoSeleccionada2 = null;
               
                //Si ha conseguido todas las parejas
                if (_puntuacion == 6)
                {
                    _mensaje = "¡HAS GANADO!"; OnProperyChanged("_mensaje");
                }
                else
                {
                    _mensaje = "¡HAS ACERTADO!"; OnProperyChanged("_mensaje");
                }
            }
            //Si no coinciden...
            else
            {
                _mensaje = "¡HAS FALLADO!"; OnProperyChanged("_mensaje");
                await Task.Delay(1000);
                _fotoSeleccionada1.Imagen = "ms-appx:///Assets/logo.jpg";
                _fotoSeleccionada2.Imagen = "ms-appx:///Assets/logo.jpg";
                OnProperyChanged("Foto");
                _fotoSeleccionada1 = null; _fotoSeleccionada2 = null;
            }


        }

        /// <summary>
        /// Reinicia los elementos del juego para una nueva partida
        /// </summary>
        public void repetir()
        {
            _fotoSeleccionada1 = new clsFoto("", ""); _fotoSeleccionada2 = new clsFoto("", "");//<--Le asigno valores temporales para evitar NullPointerExeption
            
            conjunto = new clsConjuntos().conjunto; OnProperyChanged("conjunto");         
            _puntuacion = 0;
            _mensaje = ""; OnProperyChanged("_mensaje");

            _fotoSeleccionada1 = null; _fotoSeleccionada2 = null;//<--Le vuelvo a asignar valores nulos

        }

    }
}
