using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiltonLopez
{
    public partial class FrmE3 : Form
    {
        public FrmE3()
        {
            InitializeComponent();
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            string nombre = NombreTextBox.Text.Trim();
            string apellido = ApellidoTextBox.Text.Trim();
            bool datosValidos = true;

            if (string.IsNullOrEmpty(nombre))
            {
                errorProvider1.SetError(NombreTextBox, "Ingrese un nombre");
                datosValidos = false;
            }
            else
            {
                errorProvider1.SetError(NombreTextBox, "");
            }

            if (string.IsNullOrEmpty(apellido))
            {
                errorProvider1.SetError(ApellidoTextBox, "Ingrese un apellido");
                datosValidos = false;
            }
            else
            {
                errorProvider1.SetError(ApellidoTextBox, "");
            }

            if (datosValidos)
            {
                for (int i = 1; i <= 100; i++)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        LstNumeros.Items.Add($"{nombre} {apellido}");
                    }
                    else if (i % 3 == 0)
                    {
                        LstNumeros.Items.Add(nombre);
                    }
                    else if (i % 5 == 0)
                    {
                        LstNumeros.Items.Add(apellido);
                    }
                    else
                    {
                        LstNumeros.Items.Add(i);
                    }
                }
            }
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            Form Principal = new PrimerExamen();
            Principal.Show();
            Close();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NombreTextBox.Clear();
            ApellidoTextBox.Clear();
            LstNumeros.Items.Clear();
        }
    }
}
