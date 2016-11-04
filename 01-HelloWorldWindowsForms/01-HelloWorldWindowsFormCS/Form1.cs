using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_HelloWorldWindowsFormCS
{
    public partial class Form1 : Form
    {
        private int rep;

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            bool f = true;
            string nombre = this.textBox.Text;
            if (!string.IsNullOrEmpty(nombre))
            {
                if (MessageBox.Show("Hola " + nombre + ".\nHoy es el " + DateTime.Today.Day + " de Octubre", "Hola mundo", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1).ToString() == "No")
                {
                    while (f)
                    {
                        f = (MessageBox.Show("¡QUE SÍ!", "¡QUE SÍ!", MessageBoxButtons.YesNo, MessageBoxIcon.Error).ToString() == "No");
                    }
                }
            }
            else
                switch (rep)
                {
                    case 0:
                        this.etiqueta2.Text = "No has metido ningún nombre.";
                        rep++;
                        break;
                    case 1:
                        this.etiqueta2.Text = "No es tan difícil, tienes que escribir un nombre.";
                        rep++;
                        break;
                    case 2:
                        this.etiqueta2.Text = "Mira, yo no tengo tiempo para esto, \no escribes un nombre o me voy.";
                        rep++;
                        break;
                    default:
                        Application.Exit();
                        break;
                }
        }
       
    }
    
    
}
