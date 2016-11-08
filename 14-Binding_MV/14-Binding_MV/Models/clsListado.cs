using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace _14_Binding_MV.Models
{
    public class clsListado
    {
        public ObservableCollection<clsPersona> lista { get; set; }


        public clsListado()
        {
            lista = new ObservableCollection<clsPersona>();
            lista.Add(new clsPersona("Alberto", "Navarro", 1, new DateTime(1995,12,6), "Mi calle", "666 555 444"));
            lista.Add(new clsPersona("Abradolf", "Lincler", 2, new DateTime(1945, 2, 15), "New Auschwitz", "666 666 123"));
            //TODO: Añadir más personas

        }
    }
}