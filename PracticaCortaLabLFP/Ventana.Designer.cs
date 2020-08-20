namespace PracticaCortaLabLFP
{
    partial class Ventana
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
            this.Componentes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Componentes
            // 
            this.Componentes.Location = new System.Drawing.Point(64, 41);
            this.Componentes.Multiline = true;
            this.Componentes.Name = "Componentes";
            this.Componentes.ReadOnly = true;
            this.Componentes.Size = new System.Drawing.Size(673, 122);
            this.Componentes.TabIndex = 0;
            this.Componentes.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Ventana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 224);
            this.Controls.Add(this.Componentes);
            this.Name = "Ventana";
            this.Text = "Ventana";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Componentes;
    }
}