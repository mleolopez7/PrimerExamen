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
    public partial class FrmE2 : Form
    {
        public FrmE2()
        {
            InitializeComponent();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            Form Principal = new PrimerExamen();
            Principal.Show();
            Close();
        }

        private async void BtnCalcular_Click(object sender, EventArgs e)
        {
            ValidarCampos();

            double precioP1 = Convert.ToDouble(PrecioP1TextBox.Text);
            int cantidadP1 = Convert.ToInt32(CantidadP1TextBox.Text);

            double precioP2 = Convert.ToDouble(PrecioP2TextBox.Text);
            int cantidadP2 = Convert.ToInt32(CantidadP2TextBox.Text);

            double precioP3 = Convert.ToDouble(PrecioP3TextBox.Text);
            int cantidadP3 = Convert.ToInt32(CantidadP3TextBox.Text);

            double totalFactura = precioP1 * cantidadP1 + precioP2 * cantidadP2 + precioP3 * cantidadP3;

            double descuento = await CalcularDescuentoAsync(totalFactura);

            DescuentoTextBox.Text = descuento.ToString("C");
            TotalPagarTextBox.Text = (totalFactura - descuento).ToString("C");

        }

        private async Task<double> CalcularDescuentoAsync(double totalFactura)
        {
            await Task.Delay(1000);

            double descuento = totalFactura * 0.15;

            return descuento;
        }

        private bool ValidarCampos()
        {
            bool ok = true;

            if (string.IsNullOrWhiteSpace(PrecioP1TextBox.Text))
            {
                errorProvider1.SetError(PrecioP1TextBox, "Ingrese el precio del producto");
                ok = false;
            }
            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(CantidadP1TextBox.Text))
            {
                errorProvider1.SetError(CantidadP1TextBox, "Ingrese la cantidad del producto");
                ok = false;
            }
            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(PrecioP2TextBox.Text))
            {
                errorProvider1.SetError(PrecioP2TextBox, "Ingrese el precio del producto");
                ok = false;
            }
            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(CantidadP2TextBox.Text))
            {
                errorProvider1.SetError(CantidadP2TextBox, "Ingrese la cantidad del producto");
                ok = false;
            }
            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(PrecioP3TextBox.Text))
            {
                errorProvider1.SetError(PrecioP3TextBox, "Ingrese el precio del producto");
                ok = false;
            }
            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(CantidadP3TextBox.Text))
            {
                errorProvider1.SetError(CantidadP3TextBox, "Ingrese la cantidad del producto");
                ok = false;
            }
            errorProvider1.Clear();

            return ok;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
