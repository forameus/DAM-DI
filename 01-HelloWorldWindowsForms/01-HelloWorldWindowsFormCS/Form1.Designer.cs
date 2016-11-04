namespace _01_HelloWorldWindowsFormCS
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox = new System.Windows.Forms.TextBox();
            this.etiqueta1 = new System.Windows.Forms.Label();
            this.boton = new System.Windows.Forms.Button();
            this.etiqueta2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(79, 41);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(153, 20);
            this.textBox.TabIndex = 0;
            // 
            // etiqueta1
            // 
            this.etiqueta1.AutoSize = true;
            this.etiqueta1.Location = new System.Drawing.Point(29, 44);
            this.etiqueta1.Name = "etiqueta1";
            this.etiqueta1.Size = new System.Drawing.Size(44, 13);
            this.etiqueta1.TabIndex = 1;
            this.etiqueta1.Text = "Nombre";
            // 
            // boton
            // 
            this.boton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boton.Location = new System.Drawing.Point(105, 100);
            this.boton.Name = "boton";
            this.boton.Size = new System.Drawing.Size(75, 23);
            this.boton.TabIndex = 2;
            this.boton.Text = "&Click";
            this.boton.UseVisualStyleBackColor = true;
            this.boton.Click += new System.EventHandler(this.button1_Click);
            // 
            // etiqueta2
            // 
            this.etiqueta2.AutoSize = true;
            this.etiqueta2.Location = new System.Drawing.Point(12, 183);
            this.etiqueta2.Name = "etiqueta2";
            this.etiqueta2.Size = new System.Drawing.Size(88, 13);
            this.etiqueta2.TabIndex = 3;
            this.etiqueta2.Text = "                           ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.etiqueta2);
            this.Controls.Add(this.boton);
            this.Controls.Add(this.etiqueta1);
            this.Controls.Add(this.textBox);
            this.Name = "Form1";
            this.Text = "Hello World C#";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label etiqueta1;
        private System.Windows.Forms.Button boton;
        private System.Windows.Forms.Label etiqueta2;
    }
}

