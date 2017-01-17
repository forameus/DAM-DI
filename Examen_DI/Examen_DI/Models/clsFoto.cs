using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_DI.Models
{
    public class clsFoto : INotifyPropertyChanged
    {

        //Atributos
        private string nombre;
        private string imagen;
        private string pareja;
        public event PropertyChangedEventHandler PropertyChanged;


        //Constructores
        public clsFoto(string nombre, string imagen, string pareja)
        {
            this.nombre = nombre;
            this.imagen = imagen;
            this.pareja = pareja;

        }

        public clsFoto(string nombre, string pareja)
        {
            this.nombre = nombre;
            this.imagen = "ms-appx:///Assets/"+nombre+".jpg";
            this.pareja = pareja;
        }


        protected void OnProperyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
                OnProperyChanged("Nombre");
            }
        }

        public string Imagen
        {
            get
            {
                return imagen;
            }

            set
            {
                imagen = value;
                OnProperyChanged("Imagen");
            }
        }

        public string Pareja
        {
            get
            {
                return pareja;
            }

            set
            {
                pareja = value;
                OnProperyChanged("Pareja");
            }
        }
    }
   
}
