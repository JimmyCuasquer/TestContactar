using Proxies.Pago;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cliente
{
    public partial class PagoFrm : Form
    {
        public PagoFrm()
        {
            InitializeComponent();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            try
            {
                PagoMSJ pago = new PagoMSJ();

                pago.SECUENCIALPRESTAMO = int.Parse(sECUENCIALPRESTAMOTextBox.Text);
                pago.VALORPAGO = Convert.ToDecimal(vALORTextBox.Text);
               
                PagoWS pagoWS = new PagoWS();
                pagoWS.Guardar(pago);

                MessageBox.Show("Registro guardado exitosamente", "Pago", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Pago", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
