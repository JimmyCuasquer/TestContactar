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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void crearPersonasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonasFrm personasFrm = new PersonasFrm();
            personasFrm.Show();
        }

        private void crearPrestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrestamoFrm prestamosFrm = new PrestamoFrm();
            prestamosFrm.Show();
        }

        private void registrarPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PagoFrm pagosFrm = new PagoFrm();
            pagosFrm.Show();
        }
    }
}
