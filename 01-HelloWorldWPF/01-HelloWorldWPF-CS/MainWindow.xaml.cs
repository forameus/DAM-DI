using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _01_HelloWorldWPF_CS
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string s = "";
            Random r = new Random();
            if (!string.IsNullOrEmpty(txtNombre.Text)) {

                MessageBox.Show("Hola, " + this.txtNombre.Text+", bienvenido al siglo "+this.ObtenerSiglo(), "HOLA", MessageBoxButton.OK, MessageBoxImage.Information);
               }
            else
            {
                s += (char)r.Next(65, 90);
                for (int i = 0; i < r.Next(5, 15); i++)
                {
                    s += (char)r.Next(97, 122);
                }
                txtNombre.Text = s;
            }
        }
        
        /// <summary>
        /// Devuelve el siglo actual.
        /// </summary>
        /// <returns>int siglo</returns>
        private int ObtenerSiglo()
        {
            int res;
            if(DateTime.Now.Year % 100 == 0)
                res = DateTime.Now.Year / 100;
            else
                res = DateTime.Now.Year / 100 + 1;
            return res;
        }

        /// <summary>
        /// Devuelve el siglo dado un año.
        /// </summary>
        /// <param name="año"></param>
        /// <returns>Siglo al que pertenece el año</returns>
        private int ObtenerSiglo(int anyo)
        {
            int res;
            if (anyo % 100 == 0)
                res = anyo / 100;
            else
                res = anyo / 100 + 1;
            return res;
        }
    }
}
