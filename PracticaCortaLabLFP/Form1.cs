using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaCortaLabLFP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

  

        private void BotonObtener_Click(object sender, EventArgs e)
        {
            string Oracion = Texto1.Text;
            Analizador analizador = new Analizador(Oracion);
            analizador.ProcesoAnalisis();
            
        }
    }
}
