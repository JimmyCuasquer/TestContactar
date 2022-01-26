using Proxies.Prestamo;
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
    public partial class PrestamoFrm : Form
    {
        public PrestamoFrm()
        {
            InitializeComponent();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            try
            {
                PrestamoBase prestamoBase = new PrestamoBase();
                prestamoBase.IDENTIFICACION = iDENTIFICACIONtextBox.Text;
                prestamoBase.MONTO = mONTOtextBox.Text;

                PrestamoWS prestamoWS = new PrestamoWS();
                prestamoBase = prestamoWS.Guardar(prestamoBase);
                if (prestamoBase.MENSAJE.Equals(""))
                    MessageBox.Show("Registro guardado exitosamente", "Prestamos", MessageBoxButtons.OK);
                else
                    MessageBox.Show(prestamoBase.MENSAJE, "Prestamos", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Prestamos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
