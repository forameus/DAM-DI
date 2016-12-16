using _17_ClienteApiRest.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace _17_ClienteApiRest.ViewModels
{
    public class clsMainPageVM : INotifyPropertyChanged
    {
        #region "Atributos"
        private clsPersona _personaSeleccionada;
        public ObservableCollection<clsPersona> lista { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
  
        private DelegateCommand _eliminarCommand;
        #endregion

        public clsMainPageVM()
        {
            rellenaLista();    
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
                _eliminarCommand.RaiseCanExecuteChanged();
                OnProperyChanged("Persona");
            }
        }

        

        protected void OnProperyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }


        //Eliminar
        public DelegateCommand eliminarCommand
        {
            get
            {
                _eliminarCommand = new DelegateCommand(EliminarCommand_Executed, EliminarCommand_CanExecute);
                return _eliminarCommand;
            }
        }

        private void EliminarCommand_Executed()
        {
            HttpStatusCode respuesta;
            clsManejadoraPersona mp = new clsManejadoraPersona();
            ContentDialog confirmarBorrado = new ContentDialog();

            confirmarBorrado.Title = "Eliminar";
            confirmarBorrado.Content = "¿Seguro?";
            confirmarBorrado.PrimaryButtonText = "Cancelar";
            confirmarBorrado.SecondaryButtonText = "Aceptar";

            ContentDialogResult resultado = await confirmarBorrado.ShowAsync();
        }

        private bool EliminarCommand_CanExecute()
        {
            bool sePuedeBorrar = true;
            if (_personaSeleccionada == null)
                sePuedeBorrar = false;
            return sePuedeBorrar;
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
            if (string.IsNullOrEmpty(_textoABuscar))
            {
                var listaFiltrada = from p in lista where p.Nombre.StartsWith(_textoABuscar) select p;
                lista = new ObservableCollection<clsPersona>(listaFiltrada);
            }
            else
            {
                //clsListado listaPersonas = lita;
            }

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
        
        private async void rellenaLista()
        {
            clsListado oListado = new clsListado();
            lista = await oListado.getPersonas();
            OnProperyChanged("lista");
        }    

    }
}
