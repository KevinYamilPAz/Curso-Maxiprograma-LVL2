namespace PracticaPokedex
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
            this.DGVpokemons = new System.Windows.Forms.DataGridView();
            this.PBpokemon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVpokemons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBpokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVpokemons
            // 
            this.DGVpokemons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVpokemons.Location = new System.Drawing.Point(12, 12);
            this.DGVpokemons.Name = "DGVpokemons";
            this.DGVpokemons.RowHeadersWidth = 51;
            this.DGVpokemons.RowTemplate.Height = 24;
            this.DGVpokemons.Size = new System.Drawing.Size(607, 475);
            this.DGVpokemons.TabIndex = 0;
            this.DGVpokemons.SelectionChanged += new System.EventHandler(this.DGVpokemons_SelectionChanged);
            // 
            // PBpokemon
            // 
            this.PBpokemon.Location = new System.Drawing.Point(634, 12);
            this.PBpokemon.Name = "PBpokemon";
            this.PBpokemon.Size = new System.Drawing.Size(449, 475);
            this.PBpokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBpokemon.TabIndex = 1;
            this.PBpokemon.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 499);
            this.Controls.Add(this.PBpokemon);
            this.Controls.Add(this.DGVpokemons);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVpokemons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBpokemon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVpokemons;
        private System.Windows.Forms.PictureBox PBpokemon;
    }
}

