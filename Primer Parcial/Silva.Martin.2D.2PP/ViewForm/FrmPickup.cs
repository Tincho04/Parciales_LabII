using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace ViewForm
{
    public partial class FrmPickup : Form
    {
        PickUp pickUp;

        public FrmPickup()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            pickUp = new PickUp(txtPatente.Text, txtModelo.Text);

            MessageBox.Show(pickUp.ConsultarDatos());
        }
    }
}
