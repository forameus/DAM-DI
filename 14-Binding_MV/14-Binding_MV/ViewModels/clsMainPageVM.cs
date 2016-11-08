using _14_Binding_MV.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Binding_MV.ViewModels
{
    class clsMainPageVM
    {
        #region "Atributos"
        public clsPersona _personaSeleccionada { get; set; }
        public ObservableCollection<clsPersona> lista { get; set; }
        #endregion

        public clsMainPageVM()
        {
            lista = new clsListado(15).lista;
        }
    }
}
