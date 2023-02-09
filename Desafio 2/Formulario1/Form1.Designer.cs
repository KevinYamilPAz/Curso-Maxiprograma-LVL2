namespace Formulario1
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
            this.LBnombre = new System.Windows.Forms.Label();
            this.TBnombre = new System.Windows.Forms.TextBox();
            this.LBedad = new System.Windows.Forms.Label();
            this.LBdireccion = new System.Windows.Forms.Label();
            this.LBapellido = new System.Windows.Forms.Label();
            this.TBapellido = new System.Windows.Forms.TextBox();
            this.TBedad = new System.Windows.Forms.TextBox();
            this.TBdireccion = new System.Windows.Forms.TextBox();
            this.BTcarga = new System.Windows.Forms.Button();
            this.LVdatos = new System.Windows.Forms.ListView();
            this.BTcancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBnombre
            // 
            this.LBnombre.AutoSize = true;
            this.LBnombre.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LBnombre.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LBnombre.Location = new System.Drawing.Point(68, 39);
            this.LBnombre.Name = "LBnombre";
            this.LBnombre.Size = new System.Drawing.Size(62, 16);
            this.LBnombre.TabIndex = 0;
            this.LBnombre.Text = "Nombre :";
            // 
            // TBnombre
            // 
            this.TBnombre.BackColor = System.Drawing.SystemColors.Control;
            this.TBnombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBnombre.ForeColor = System.Drawing.SystemColors.Desktop;
            this.TBnombre.Location = new System.Drawing.Point(138, 40);
            this.TBnombre.Name = "TBnombre";
            this.TBnombre.Size = new System.Drawing.Size(240, 15);
            this.TBnombre.TabIndex = 1;
            // 
            // LBedad
            // 
            this.LBedad.AutoSize = true;
            this.LBedad.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LBedad.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LBedad.Location = new System.Drawing.Point(84, 115);
            this.LBedad.Name = "LBedad";
            this.LBedad.Size = new System.Drawing.Size(46, 16);
            this.LBedad.TabIndex = 2;
            this.LBedad.Text = "Edad :";
            // 
            // LBdireccion
            // 
            this.LBdireccion.AutoSize = true;
            this.LBdireccion.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LBdireccion.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LBdireccion.Location = new System.Drawing.Point(60, 152);
            this.LBdireccion.Name = "LBdireccion";
            this.LBdireccion.Size = new System.Drawing.Size(70, 16);
            this.LBdireccion.TabIndex = 3;
            this.LBdireccion.Text = "Direccion :";
            // 
            // LBapellido
            // 
            this.LBapellido.AutoSize = true;
            this.LBapellido.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LBapellido.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LBapellido.Location = new System.Drawing.Point(68, 80);
            this.LBapellido.Name = "LBapellido";
            this.LBapellido.Size = new System.Drawing.Size(63, 16);
            this.LBapellido.TabIndex = 4;
            this.LBapellido.Text = "Apellido :";
            // 
            // TBapellido
            // 
            this.TBapellido.BackColor = System.Drawing.SystemColors.Control;
            this.TBapellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBapellido.ForeColor = System.Drawing.SystemColors.Desktop;
            this.TBapellido.Location = new System.Drawing.Point(138, 81);
            this.TBapellido.Name = "TBapellido";
            this.TBapellido.Size = new System.Drawing.Size(240, 15);
            this.TBapellido.TabIndex = 5;
            // 
            // TBedad
            // 
            this.TBedad.BackColor = System.Drawing.SystemColors.Control;
            this.TBedad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBedad.ForeColor = System.Drawing.SystemColors.Desktop;
            this.TBedad.Location = new System.Drawing.Point(138, 116);
            this.TBedad.Name = "TBedad";
            this.TBedad.Size = new System.Drawing.Size(58, 15);
            this.TBedad.TabIndex = 6;
            this.TBedad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBedad_KeyPress);
            // 
            // TBdireccion
            // 
            this.TBdireccion.BackColor = System.Drawing.SystemColors.Control;
            this.TBdireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBdireccion.ForeColor = System.Drawing.SystemColors.Desktop;
            this.TBdireccion.Location = new System.Drawing.Point(138, 153);
            this.TBdireccion.Name = "TBdireccion";
            this.TBdireccion.Size = new System.Drawing.Size(240, 15);
            this.TBdireccion.TabIndex = 7;
            // 
            // BTcarga
            // 
            this.BTcarga.Location = new System.Drawing.Point(152, 373);
            this.BTcarga.Name = "BTcarga";
            this.BTcarga.Size = new System.Drawing.Size(90, 45);
            this.BTcarga.TabIndex = 9;
            this.BTcarga.Text = "Cargar datos";
            this.BTcarga.UseVisualStyleBackColor = true;
            this.BTcarga.Click += new System.EventHandler(this.BTcarga_Click);
            // 
            // LVdatos
            // 
            this.LVdatos.BackColor = System.Drawing.Color.Snow;
            this.LVdatos.BackgroundImageTiled = true;
            this.LVdatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LVdatos.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LVdatos.HideSelection = false;
            this.LVdatos.Location = new System.Drawing.Point(138, 198);
            this.LVdatos.Name = "LVdatos";
            this.LVdatos.Size = new System.Drawing.Size(240, 156);
            this.LVdatos.TabIndex = 10;
            this.LVdatos.UseCompatibleStateImageBehavior = false;
            this.LVdatos.View = System.Windows.Forms.View.List;
            // 
            // BTcancelar
            // 
            this.BTcancelar.Location = new System.Drawing.Point(274, 373);
            this.BTcancelar.Name = "BTcancelar";
            this.BTcancelar.Size = new System.Drawing.Size(90, 45);
            this.BTcancelar.TabIndex = 11;
            this.BTcancelar.Text = "Cancelar";
            this.BTcancelar.UseVisualStyleBackColor = true;
            this.BTcancelar.Click += new System.EventHandler(this.BTcancelar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(514, 459);
            this.Controls.Add(this.BTcancelar);
            this.Controls.Add(this.LVdatos);
            this.Controls.Add(this.BTcarga);
            this.Controls.Add(this.TBdireccion);
            this.Controls.Add(this.TBedad);
            this.Controls.Add(this.TBapellido);
            this.Controls.Add(this.LBapellido);
            this.Controls.Add(this.LBdireccion);
            this.Controls.Add(this.LBedad);
            this.Controls.Add(this.TBnombre);
            this.Controls.Add(this.LBnombre);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(532, 506);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(532, 506);
            this.Name = "Form1";
            this.Text = "Datos Personales";
            this.TransparencyKey = System.Drawing.SystemColors.Window;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBnombre;
        private System.Windows.Forms.TextBox TBnombre;
        private System.Windows.Forms.Label LBedad;
        private System.Windows.Forms.Label LBdireccion;
        private System.Windows.Forms.Label LBapellido;
        private System.Windows.Forms.TextBox TBapellido;
        private System.Windows.Forms.TextBox TBedad;
        private System.Windows.Forms.TextBox TBdireccion;
        private System.Windows.Forms.Button BTcarga;
        private System.Windows.Forms.ListView LVdatos;
        private System.Windows.Forms.Button BTcancelar;
    }
}

