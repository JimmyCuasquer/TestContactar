
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Proxies.Persona;
using Proxies.TipoIdentificacion;

namespace Cliente
{
    public partial class PersonasFrm : Form
    {
        public PersonasFrm()
        {
            InitializeComponent();
        }

        private void listarButton_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void Listar()
        {
            try
            {
                PersonaWS personaWS = new PersonaWS();

                List<PersonaMSJ> listaPersonaMSJ = personaWS.Listar().ToList();
                personasDataGridView.DataSource = listaPersonaMSJ;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void ListarTiposIdentificacion()
        {
            try
            {
                TipoIdentificacionWS tipoIdentificacionWS = new TipoIdentificacionWS();

                List<TipoIdentificacionMSJ> tipoIdentificacionMSJs = tipoIdentificacionWS.Listar().ToList();
                tipoIdentificacionBindingSource.DataSource = tipoIdentificacionMSJs;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void guardarButton_Click(object sender, EventArgs e)
        {
            try
            {
                PersonaMSJ persona = new PersonaMSJ();
                persona.CODIGOTIPOIDENTIFICACION = "CC";
                persona.IDENTIFICACION = iDENTIFICACIONTextBox.Text;
                persona.PRIMERNOMBRE = pRIMERNOMBRETextBox.Text;
                persona.SEGUNDONOMBRE = sEGUNDONOMBRETextBox.Text;
                persona.PRIMERAPELLIDO = pRIMERAPELLIDOTextBox.Text;
                persona.SEGUNDOAPELLIDO = sEGUNDOAPELLIDOTextBox.Text;
                persona.ESTAACTIVO = true;

                PersonaWS personaWS = new PersonaWS();
                personaWS.Guardar(persona);

                Listar();

                MessageBox.Show("Registro guardado exitosamente", "Personas", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Personas", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            try
            {
                PersonaWS personaWS = new PersonaWS();
                PersonaMSJ personaMSJ = personaWS.BuscarPorIdentificacion(iDENTIFICACIONTextBox.Text);

                if (personaMSJ == null)
                {
                    MessageBox.Show("La identificación: " + iDENTIFICACIONTextBox.Text + " no se encuentra en la base de datos");
                }
                else
                {
                    pRIMERNOMBRETextBox.Text = personaMSJ.PRIMERNOMBRE;
                    sEGUNDONOMBRETextBox.Text = personaMSJ.SEGUNDONOMBRE;
                    pRIMERAPELLIDOTextBox.Text = personaMSJ.PRIMERAPELLIDO;
                    sEGUNDOAPELLIDOTextBox.Text = personaMSJ.SEGUNDOAPELLIDO;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Personas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void personasDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void PersonasFrm_Load(object sender, EventArgs e)
        {
            ListarTiposIdentificacion();

        } 
    }
}
