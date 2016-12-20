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
        private DelegateCommand _guardarCommand;
        private DelegateCommand _recargarCommand;
        private DelegateCommand _insertarCommand;
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

        private async void rellenaLista()
        {
            clsListado oListado = new clsListado();
            lista = await oListado.getPersonas();
            OnProperyChanged("lista");
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

        private async void EliminarCommand_Executed()
        {
            clsManejadoraPersona mp = new clsManejadoraPersona();
            ContentDialog confirmarBorrado = new ContentDialog();

            confirmarBorrado.Title = "Eliminar";
            confirmarBorrado.Content = "¿Seguro que quieres eliminar a esta persona?";
            confirmarBorrado.PrimaryButtonText = "Cancelar";
            confirmarBorrado.SecondaryButtonText = "Aceptar";

            ContentDialogResult resultado = await confirmarBorrado.ShowAsync();
            if (resultado == ContentDialogResult.Secondary)
            {
                mp.EliminarPersona(_personaSeleccionada.id);
                rellenaLista();
            }

        }

        private bool EliminarCommand_CanExecute()
        {
            bool sePuedeBorrar = false;
            if (_personaSeleccionada != null)
                sePuedeBorrar = true;
            return sePuedeBorrar;
        }


        //Guardar
        public DelegateCommand guardarCommand
        {
            get
            {
                _guardarCommand = new DelegateCommand(GuardarCommand_Executed);
                return _guardarCommand;
            }
        }

        private async void GuardarCommand_Executed()
        {
            clsManejadoraPersona mp = new clsManejadoraPersona();
            mp.ActualizarPersona(_personaSeleccionada);
            await Task.Delay(1000);
            rellenaLista();
        }

        //Recargar
        public DelegateCommand recargarCommand
        {
            get
            {
                _recargarCommand = new DelegateCommand(RecargarCommand_Executed);
                return _recargarCommand;
            }
        }

        private void RecargarCommand_Executed()
        {           
           
            rellenaLista();
        }

        //Insertar
        public DelegateCommand insertarCommand
        {
            get
            {
                _insertarCommand = new DelegateCommand(InsertarCommand_Executed);
                return _insertarCommand;
            }
        }

        private void InsertarCommand_Executed()
        {
            rellenaLista();
        }

    }

}

