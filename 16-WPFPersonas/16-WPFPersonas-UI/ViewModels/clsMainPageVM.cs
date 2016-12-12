using _16_WPFPersonas_BL.Listados;
using _16_WPFPersonas_BL.Manejadoras;
using _16_WPFPersonas_ET;
using _16_WPFPersonas_ET.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;

namespace _16_WPFPersonas_UI.ViewModels
{
    public class clsMainPageVM : clsVMBase
    {
        #region "Atributos"
        private clsPersona _personaSeleccionada;
        public List<clsPersona> lista { get; set; }
        
        private DelegateCommand _eliminarCommand;
        private DelegateCommand _guardarCommand;
        private DelegateCommand _insertarPersona;
        #endregion

        public clsMainPageVM()
        {
            lista = new clsListadosBL().getListadoPersonaBL();            
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
                NotifyPropertyChanged("Persona");
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

        private void EliminarCommand_Executed()
        {
            clsManejadoraPersonaBL mpbl = new clsManejadoraPersonaBL();
            mpbl.deletePersona(_personaSeleccionada.id);

            lista = new clsListadosBL().getListadoPersonaBL();
            NotifyPropertyChanged("lista");
        }

        private bool EliminarCommand_CanExecute()
        {
            bool sePuedeBorrar = true;
            if (_personaSeleccionada == null)
                sePuedeBorrar = false;
            return sePuedeBorrar;
        }



        public DelegateCommand guardarCommand
        {
            get
            {                
               _guardarCommand= new DelegateCommand(GuardarCommand_Executed);
                return _guardarCommand;
            }
        }

        private void GuardarCommand_Executed()
        {
            clsManejadoraPersonaBL mpbl = new clsManejadoraPersonaBL();
            mpbl.updatePersona(_personaSeleccionada);

            lista = new clsListadosBL().getListadoPersonaBL();
            NotifyPropertyChanged("lista");
        }

    }
}
