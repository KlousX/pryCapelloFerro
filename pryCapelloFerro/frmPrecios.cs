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
    public partial class frmPrecios : Form
    {
        public frmPrecios()
        {
            InitializeComponent();
        }

        private void frmPrecios_Load(object sender, EventArgs e)
        {
            dgvPrecios.Columns.Add("Concepto", "Concepto");
            dgvPrecios.Columns.Add("Detalle", "Detalle");
            dgvPrecios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvPrecios.Rows.Add("Precio por kilómetro", "$5");
            dgvPrecios.Rows.Add("Descuento", "50%");
            dgvPrecios.Rows.Add("Condición descuento", "Distancia mayor o igual a 100km, con una estancia mayor o igual a 7 días");
            dgvPrecios.Rows.Add("Días de estancia", "Entre 1 y 30");

            dgvPrecios.RowHeadersVisible = false;
            dgvPrecios.AllowUserToAddRows = false;
            dgvPrecios.ReadOnly = true;
        }
    }
}
