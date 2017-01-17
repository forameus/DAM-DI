using _08_Grid.Models;
using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;


// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace _08_Grid
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }



        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            bool valido = true;
            
            //Crear persona, validarla y obtener los posibles errores
            clsPersona persona = new clsPersona(txbNombre.Text, txbApellidos.Text, txbFecha.Text);
            String[] errores = clsValidaPersona.validarPersona(persona);

            //Mostrar mensajes de error
            txtErrorNombre.Text = errores[0];
            txtErrorApellidos.Text = errores[1];
            txtErrorFecha.Text = errores[2];

            //Comprobar si los strings están vacíos, en tal caso, la persona ha sido validada
            foreach (string temp in errores)
                if (temp != "" && valido)
                    valido = false;

            //Mostrar mensaje de validación
            if (valido)
                txtValidado.Text = "¡Bienvenido, " +persona.nombre+"!";
            else
                txtValidado.Text = "";
        }
    }
}
