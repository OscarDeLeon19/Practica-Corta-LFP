namespace PracticaCortaLabLFP
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
            this.Texto1 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BotonObtener = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Texto1
            // 
            this.Texto1.Location = new System.Drawing.Point(211, 23);
            this.Texto1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Texto1.Name = "Texto1";
            this.Texto1.Size = new System.Drawing.Size(579, 29);
            this.Texto1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingresa una oracion";
            // 
            // BotonObtener
            // 
            this.BotonObtener.Location = new System.Drawing.Point(125, 86);
            this.BotonObtener.Name = "BotonObtener";
            this.BotonObtener.Size = new System.Drawing.Size(535, 63);
            this.BotonObtener.TabIndex = 2;
            this.BotonObtener.Text = "Obtener Oracion";
            this.BotonObtener.UseVisualStyleBackColor = true;
            this.BotonObtener.Click += new System.EventHandler(this.BotonObtener_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 180);
            this.Controls.Add(this.BotonObtener);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Texto1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "Analizador Lexico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox Texto1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BotonObtener;
    }
}

