using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        private string nombre;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show(" ☻ ♦ ☻  Welcome  ☻ ♦ ☻ ");
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnascendente_Click(object sender, EventArgs e)
        {
            Ordenarascendente();
        }
        public void Ordenarascendente()
        {
            string[] nombre = new string[5];
            int[] edad = new int[5];

            nombre[0] = "Jeymy";
            nombre[1] = "Ortiz";
            nombre[2] = "Yamileth";
            nombre[3] = "Ronaldo";
            nombre[4] = "Messi";
            edad[0] = 14;
            edad[1] = 22;
            edad[2] = 40;
            edad[3] = 45;
            edad[4] = 34;

            for (int i = 0; i < nombre.Length; i++)
            {
                lstnombres.Items.Add(nombre[i]);
                lstedades.Items.Add(edad[i]);
            }

            for (int k = 0; k < 4; k++)
            {
                for (int f = 0; f < 4 - k; f++)
                {
                    if (nombre[f].CompareTo(nombre[f + 1]) > 0)
                    {
                        string aux;
                        aux = nombre[f];
                        nombre[f] = nombre[f + 1];
                        nombre[f + 1] = aux;
                    }
                }
            }

            for (int k = 0; k < 4; k++)
            {
                for (int f = 0; f < 4 - k; f++)
                {
                    if (edad[f] > edad[f + 1])
                    {
                        int aux;
                        aux = edad[f];
                        edad[f] = edad[f + 1];
                        edad[f + 1] = aux;
                    }
                }
            }

            for (int f = 0; f < nombre.Length; f++)
            {
                cbnombre.Items.Add(nombre[f]);
                cbedad.Items.Add(edad[f]);
            }
        }

        private void btndescendente_Click(object sender, EventArgs e)
        {
            
            ordenardescendente();
            MessageBox.Show("Lo intente pero no me salio de manera descendente :c");
        }   

        public void ordenardescendente()
        {
            string[] nombre = new string[5];
            int[] edad = new int[5];
            nombre[0] = "Jeymy";
            nombre[1] = "Ortiz";
            nombre[2] = "Yamileth";
            nombre[3] = "Ronaldo";
            nombre[4] = "Messi";
            edad[0] = 14;
            edad[1] = 22;
            edad[2] = 40;
            edad[3] = 45;
            edad[4] = 34;

           
            for (int i = 0; i < nombre.Length; i++)
            {
                lstnombres.Items.Add(nombre[i]);
                lstedades.Items.Add(edad[i]);
            }

            }
            
        }

    }

