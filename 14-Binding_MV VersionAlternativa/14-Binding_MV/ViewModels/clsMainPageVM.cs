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

        private DelegateCommand _buscarCommand;
        private DelegateCommand _eliminarCommand;
        private string textoABuscar;
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








        public DelegateCommand buscarCommand
        {
            get
            {
                _buscarCommand = new DelegateCommand(BuscarCommand_Executed, BuscarCommand_CanExecute);
                return _buscarCommand;
            }
        }

       
        public DelegateCommand eliminarCommand
        {
            get
            {
                _eliminarCommand = new DelegateCommand(EliminarCommand_Executed, EliminarCommand_CanExecute);
                return _eliminarCommand;
            }
        }

        private bool BuscarCommand_CanExecute()
        {
            throw new NotImplementedException();
        }

        private void BuscarCommand_Executed()
        {
            throw new NotImplementedException();
        }




        private void EliminarCommand_Executed()
        {
            lista.Remove(_personaSeleccionada);
        }

        private bool EliminarCommand_CanExecute()
        {
            bool sePuedeBorrar = true;

            /*if (_personaSeleccionada == null)
                sePuedeBorrar = false;*/

            return sePuedeBorrar;
        }

       

    }
}
