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
    public partial class PrimerExamen : Form
    {
        public PrimerExamen()
        {
            InitializeComponent();
        }

        private void PrimerExamen_Load(object sender, EventArgs e)
        {

        }

        private void ejercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Ejercicio1 = new FrmE1();
            Ejercicio1.Show();
            this.Hide();
        }

        private void ejercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Ejercicio2 = new FrmE2();
            Ejercicio2.Show();
            this.Hide();
        }

        private void ejercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Ejercicio3 = new FrmE3();
            Ejercicio3.Show();
            this.Hide();
        }
    }
}
