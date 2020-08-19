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
            this.Text1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Text1
            // 
            this.Text1.Location = new System.Drawing.Point(64, 41);
            this.Text1.Multiline = true;
            this.Text1.Name = "Text1";
            this.Text1.ReadOnly = true;
            this.Text1.Size = new System.Drawing.Size(673, 122);
            this.Text1.TabIndex = 0;
            this.Text1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Ventana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 224);
            this.Controls.Add(this.Text1);
            this.Name = "Ventana";
            this.Text = "Ventana";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Text1;
    }
}