namespace ResponseReader
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.campoEntrada = new System.Windows.Forms.TextBox();
            this.boton = new System.Windows.Forms.Button();
            this.mensaje = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // campoEntrada
            // 
            this.campoEntrada.Location = new System.Drawing.Point(12, 12);
            this.campoEntrada.Name = "campoEntrada";
            this.campoEntrada.Size = new System.Drawing.Size(120, 20);
            this.campoEntrada.TabIndex = 0;
            // 
            // boton
            // 
            this.boton.Location = new System.Drawing.Point(138, 12);
            this.boton.Name = "boton";
            this.boton.Size = new System.Drawing.Size(75, 23);
            this.boton.TabIndex = 1;
            this.boton.Text = "Enviar";
            this.boton.UseVisualStyleBackColor = true;
            this.boton.Click += new System.EventHandler(this.boton_Click);
            // 
            // mensaje
            // 
            this.mensaje.AutoSize = true;
            this.mensaje.BackColor = System.Drawing.Color.Aqua;
            this.mensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mensaje.ForeColor = System.Drawing.Color.Navy;
            this.mensaje.Location = new System.Drawing.Point(219, 8);
            this.mensaje.Name = "mensaje";
            this.mensaje.Padding = new System.Windows.Forms.Padding(5);
            this.mensaje.Size = new System.Drawing.Size(134, 27);
            this.mensaje.TabIndex = 3;
            this.mensaje.Text = "Digite su matricula";
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(12, 41);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(708, 266);
            this.panel.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 319);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.mensaje);
            this.Controls.Add(this.boton);
            this.Controls.Add(this.campoEntrada);
            this.Name = "Form1";
            this.Text = "Response Reader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox campoEntrada;
        private System.Windows.Forms.Button boton;
        private System.Windows.Forms.Label mensaje;
        private System.Windows.Forms.FlowLayoutPanel panel;

    }
}

