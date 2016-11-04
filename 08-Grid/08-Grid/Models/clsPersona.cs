using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _08_Grid.Models
{
    class clsPersona
    {
        //atributos
        public string nombre {get; set;}
        public string apellidos{get; set;}
        public DateTime? fechaNac {get; set;}

        //construcores
        public clsPersona()
        {
            this.nombre = "";
            this.apellidos = "";
            this.fechaNac = null;
        }

        public clsPersona(string nombre, string apellidos, String fechaDeNacimiento)
        {
            DateTime fecha;
            this.nombre = nombre;
            this.apellidos = apellidos;
            if (DateTime.TryParse(fechaDeNacimiento, out fecha))
                this.fechaNac = fecha;
            else
                fechaNac = null;
        }

    }
}
