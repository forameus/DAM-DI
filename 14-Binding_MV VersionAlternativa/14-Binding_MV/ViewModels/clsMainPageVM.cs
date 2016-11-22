using _14_Binding_MV.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace _14_Binding_MV.ViewModels
{
    public class clsMainPageVM : INotifyPropertyChanged
    {
        #region "Atributos"
        private clsPersona _personaSeleccionada;
        public ObservableCollection<clsPersona> lista { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        public clsMainPageVM()
        {
            lista = new clsListado(15).lista;
        }

        public clsPersona Persona
        {
            get
            {
                return _personaSeleccionada;
            }

            set
            {
                _personaSeleccionada = value;
                OnProperyChanged("Persona");
            }
        }

        protected void OnProperyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public void btnBorrar_Click(Object sender, RoutedEventArgs e)
        {
            lista.Remove(_personaSeleccionada);
        }

    }
}
