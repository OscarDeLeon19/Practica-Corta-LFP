using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaCortaLabLFP
{
    class Analizador
    {
        private string Oracion;
        private string[] identificador = new string[20];
        private string[] numero_entero = new string[20];
        private string[] numero_decimal = new string[20];
        private string[] moneda = new string[20];
        private int NoIdentificador = 0;
        private int NoNumeroEntero = 0;
        private int NoNumeroDecimal = 0;
        private int NoMoneda = 0;
        public Analizador(string Oracion)
        {
            this.Oracion = Oracion;
        }

        public void ProcesoAnalisis()
        {
            Oracion = Oracion + " .";
            char[] cadena = Oracion.ToCharArray();
            for (int i = 0; i< cadena.Length; i++)
            {
                string caracter = cadena[i].ToString();
                if (caracter == "Q")
                {
                    if (Char.IsPunctuation(cadena[i + 1]))
                    {
                        string aux = "Q";
                        for (int j = i; j < cadena.Length; j++)
                        {
                            if (Char.IsWhiteSpace(cadena[j]))
                            {
                                i = j;
                                j = cadena.Length;
                                moneda[NoMoneda] = aux;
                                NoMoneda++;
                            }
                            else if (Char.IsPunctuation(cadena[j]) || Char.IsNumber(cadena[j]))
                            {
                                aux = aux + cadena[j].ToString();
                            }
                        }
                    }
                }
                if (Char.IsLetter(cadena[i]))
                {
                    string aux = "";
                    for (int j = i; j < cadena.Length; j++)
                    {
                        if (Char.IsLetter(cadena[j]) || Char.IsNumber(cadena[j]))
                        {
                            aux = aux + cadena[j].ToString();
                        } else if (Char.IsWhiteSpace(cadena[j]))
                        {
                            i = j;
                            j = cadena.Length;
                            identificador[NoIdentificador] = aux;
                            NoIdentificador++;
                        }
                    }
                }
                if (Char.IsNumber(cadena[i]))
                {
                    string aux = "";
                    bool No_Decimal = false;
                    for (int j = i; j < cadena.Length; j++)
                    {
                        if (Char.IsNumber(cadena[j]))
                        {
                            aux = aux + cadena[j].ToString();
                        } else if (Char.IsPunctuation(cadena[j]))
                        {
                            aux = aux + cadena[j].ToString();
                            No_Decimal = true;
                        } else if (Char.IsWhiteSpace(cadena[j]))
                        {
                            i = j;
                            j = cadena.Length;
                            if (No_Decimal == true)
                            {
                                numero_decimal[NoNumeroDecimal] = aux;
                                NoNumeroDecimal++;
                            } else
                            {
                                numero_entero[NoNumeroEntero] = aux;
                                NoNumeroEntero++;
                            }
                        }
                    }
                }
                
            }

            //for (int i = 0; i < NoIdentificador; i++)
            //{
            //    MessageBox.Show("Identificador: " + identificador[i]);
            //}
            //for (int i = 0; i < NoNumeroEntero; i++)
            //{
            //    MessageBox.Show("Entero: " + numero_entero[i]);
            //}
            //for (int i = 0; i < NoNumeroDecimal; i++)
            //{
            //    MessageBox.Show("Decimal: " + numero_decimal[i]);
            //}
            //for (int i = 0; i < NoMoneda; i++)
            //{
            //    MessageBox.Show("Moneda: " + moneda[i]);
            //}
            Ventana ventana = new Ventana(identificador, numero_entero, numero_decimal, moneda, NoIdentificador, NoNumeroEntero, NoNumeroDecimal, NoMoneda );
            ventana.Metodo();
            ventana.Show();
        }
    }

  

}
