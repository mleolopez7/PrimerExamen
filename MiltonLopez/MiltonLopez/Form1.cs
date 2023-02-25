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
    public partial class FrmE1 : Form
    {
        public FrmE1()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double capitalInicial = 200000;
            double tasaInteres = 0.015;

            string[] meses = new string[] { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

            for (int i = 0; i < meses.Length; i++)
            {
                double interesMensual = capitalInicial * tasaInteres;
                capitalInicial += interesMensual;

                LstIntMens.Items.Add(meses[i] + ": " + interesMensual.ToString("C"));
            }
        }


        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            Form Principal = new PrimerExamen();
            Principal.Show();
            Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
