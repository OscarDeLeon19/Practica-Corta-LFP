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
    public partial class Ventana : Form
    {
        private string[] identificador;
        private string[] numero_entero;
        private string[] numero_decimal;
        private string[] moneda;
        private int NoIdentificador;
        private int NoNumeroEntero;
        private int NoNumeroDecimal;
        private int NoMoneda;
        public Ventana(string[] identificador, string[] numero_entero, string[] numero_decimal, string[] moneda, int NoIdentificador, int NoNumeroEntero, int NoNumeroDecimal, int NoMoneda)
        {
            InitializeComponent();
            this.identificador = identificador;
            this.numero_entero = numero_entero;
            this.numero_decimal = numero_decimal;
            this.moneda = moneda;
            this.NoIdentificador = NoIdentificador;
            this.NoNumeroEntero = NoNumeroEntero;
            this.NoNumeroDecimal = NoNumeroDecimal;
            this.NoMoneda = NoMoneda;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void AgregarDatos()
        {
            String Cadena = "Palabras: ";
            for (int i = 0; i < NoIdentificador; i++)
            {
                Cadena = Cadena + "(" + identificador[i] + ") ";
            }

            Cadena = Cadena + "\r\nNumeros Enteros: ";
            for (int i = 0; i < NoNumeroEntero; i++)
            {
                Cadena = Cadena + "(" + numero_entero[i] + ") ";               
            }
            Cadena = Cadena + "\r\nNumeros Decimales: ";
            for (int i = 0; i < NoNumeroDecimal; i++)
            {
                Cadena = Cadena + "(" + numero_decimal[i] + ") ";
            }
            Cadena = Cadena + "\r\nMonedas: ";
            for (int i = 0; i < NoMoneda; i++)
            {
                Cadena = Cadena + "(" + moneda[i] + ") ";
            }
            Componentes.Text = Cadena;
        }
    }
}
