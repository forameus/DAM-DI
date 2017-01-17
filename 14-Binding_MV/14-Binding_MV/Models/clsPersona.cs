using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _14_Binding_MV.Models
{
    public class clsPersona : INotifyPropertyChanged
    {
        //atributos
        [Required]
        [Display(Name = "Nombre")]
        private string nombre;
        [Required]
        [Display(Name = "Apellidos")]
        private string apellidos;
        [Display(Name = "ID")]
        public int id { get; set; }
        [Display(Name = "Fecha de Nacimiento")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime fechaNac { get; set; }
        [Display(Name = "Dirección")]
        public string direccion { get; set; }
        [Display(Name = "Teléfono")]
        public string telefono { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        //constructores
        public clsPersona()
        {
            id = 0;
            nombre = "";
            apellidos = "";

            fechaNac = new DateTime();
            direccion = "";
            telefono = "";
        }

        public clsPersona(string nombre, string apellidos, int id, DateTime fechaNac, string direccion, string telefono)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.fechaNac = fechaNac;
            this.direccion = direccion;
            this.telefono = telefono;
        }

        

        public override string ToString()
        {
            return Apellidos + ", " + Nombre;
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

        public string Apellidos
        {
            get
            {
                return apellidos;
            }

            set
            {
                apellidos = value;
                OnProperyChanged("Apellidos");
            }
        }

    }
}
