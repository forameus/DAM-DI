using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Grid.Models
{
    class clsValidaPersona
    {
        /// <summary>
        /// Comprueba si un objeto de tipo clsPersona es válido y devuelve un array de strings
        /// con los mensajes de los fallos.
        /// </summary>
        /// <param name="Persona">La persona a comprobar</param>
        /// <returns>Devuelve un array de strings con los mensajes de error: 0->Nombre, 1->Apellidos, 2->Fecha</returns>

        public static string[] validarPersona(clsPersona p)
        {
            string[] res = new string[] {"","",""};

            if (string.IsNullOrEmpty(p.nombre))
                res[0] = "Nombre no puede estar vacío.";
            else {
                foreach (char temp in p.nombre) {
                    if (!char.IsLetter(temp))
                        res[0] = "Nombre no puede tener carácteres no alfabéticos.";
                }

            }
               
            if (string.IsNullOrEmpty(p.apellidos))
                res[1] = "Apellido no puede estar vacío.";
            else { 
                foreach (char temp in p.nombre) { 
                    if (!char.IsLetter(temp))
                        res[1] = "Apellido no puede tener carácteres no alfabéticos.";
                }

            }

            if (p.fechaNac == null)
                res[2] = "La fecha está vacía o es incorrecta.";
            else
                if (p.fechaNac > DateTime.Now)
                    res[2] = "La fecha no puede ser superior a la actual.";


            return res;
        }

    }
}
