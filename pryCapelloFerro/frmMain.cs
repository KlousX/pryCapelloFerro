using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryCapelloFerro
{
    public partial class frmMain : Form
    {

        int kmPrecio = 5;
        int descuento = 1/2;

        public frmMain()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtDestino_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDistancia_Click(object sender, EventArgs e)
        {

        }

        private void mkdDistancia_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            frmPrecios precios = new frmPrecios();
            precios.ShowDialog();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (txtDestino.Text == "")
            {
                MessageBox.Show("Detalle el destino", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDestino.Focus();
                return;
            }
            if (mkdDistancia.Text == null)
            {
                MessageBox.Show("Detalle la distancia", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mkdDistancia.Focus();
                return;
            }

            int dias = (dtpVuelta.Value - dtpIda.Value).Days;

            if (mkdDistancia.Value >= 100 && dias >= 7)
            {

            }
        }
    }
}
