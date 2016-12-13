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
        private DelegateCommand _insertarCommand;
        private DelegateCommand _pegarCommand;
        private DelegateCommand _actualizarCommand;

        private bool nuevo;
        #endregion

        public clsMainPageVM()
        {
            lista = new clsListadosBL().getListadoPersonaBL();
            nuevo = false;
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
            MessageBoxResult mb = MessageBox.Show("¿Seguro que quiere eliminar a " + Persona.nombre + "?", "Eliminar", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (mb == MessageBoxResult.Yes)
            {
                clsManejadoraPersonaBL mpbl = new clsManejadoraPersonaBL();
                mpbl.deletePersona(_personaSeleccionada.id);

                lista = new clsListadosBL().getListadoPersonaBL();
                NotifyPropertyChanged("lista");
            }

        }

        private bool EliminarCommand_CanExecute()
        {
            bool sePuedeBorrar = true;
            if (_personaSeleccionada == null)
                sePuedeBorrar = false;
            return sePuedeBorrar;
        }

        //Actualizar
        public DelegateCommand actualizarCommand
        {
            get
            {
                _actualizarCommand = new DelegateCommand(ActualizarCommand_Executed);
                return _actualizarCommand;
            }
        }

        private void ActualizarCommand_Executed()
        {
            lista = new clsListadosBL().getListadoPersonaBL();
            nuevo = false;
            NotifyPropertyChanged("lista");
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

        private void GuardarCommand_Executed()
        {
            clsManejadoraPersonaBL mpbl = new clsManejadoraPersonaBL();
            if (_personaSeleccionada.id == -1)
                mpbl.insertPersona(_personaSeleccionada);
            else
                mpbl.updatePersona(_personaSeleccionada);

            lista = new clsListadosBL().getListadoPersonaBL();
            NotifyPropertyChanged("lista");
            _personaSeleccionada = null;
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
            clsPersona p = new clsPersona("Persona", "sin guardar", -1, DateTime.Today, "", "");
            lista = new clsListadosBL().getListadoPersonaBL();
            lista.Add(p);

            nuevo = true;
            _personaSeleccionada = p;
            NotifyPropertyChanged("lista");
            NotifyPropertyChanged("Persona");
        }

        //Pegar
        public DelegateCommand pegarCommand
        {
            get
            {
                _pegarCommand = new DelegateCommand(PegarCommand_Executed);
                return _pegarCommand;
            }
        }

        private void PegarCommand_Executed()
        {
            Application.Current.Shutdown();
        }

    }
}
