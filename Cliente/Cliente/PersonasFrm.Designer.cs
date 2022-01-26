
using System;

namespace Cliente
{
    partial class PersonasFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iDENTIFICACIONLabel;
            System.Windows.Forms.Label pRIMERAPELLIDOLabel;
            System.Windows.Forms.Label pRIMERNOMBRELabel;
            System.Windows.Forms.Label sEGUNDOAPELLIDOLabel;
            System.Windows.Forms.Label sEGUNDONOMBRELabel;
            this.personasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEGUNDOAPELLIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.personaMSJBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.personaMSJBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listarButton = new System.Windows.Forms.Button();
            this.guardarButton = new System.Windows.Forms.Button();
            this.iDENTIFICACIONTextBox = new System.Windows.Forms.TextBox();
            this.pRIMERAPELLIDOTextBox = new System.Windows.Forms.TextBox();
            this.pRIMERNOMBRETextBox = new System.Windows.Forms.TextBox();
            this.sEGUNDOAPELLIDOTextBox = new System.Windows.Forms.TextBox();
            this.sEGUNDONOMBRETextBox = new System.Windows.Forms.TextBox();
            this.personaWS1 = new Proxies.Persona.PersonaWS();
            this.buscarButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tipoIdentificacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            iDENTIFICACIONLabel = new System.Windows.Forms.Label();
            pRIMERAPELLIDOLabel = new System.Windows.Forms.Label();
            pRIMERNOMBRELabel = new System.Windows.Forms.Label();
            sEGUNDOAPELLIDOLabel = new System.Windows.Forms.Label();
            sEGUNDONOMBRELabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaMSJBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaMSJBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoIdentificacionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iDENTIFICACIONLabel
            // 
            iDENTIFICACIONLabel.AutoSize = true;
            iDENTIFICACIONLabel.Location = new System.Drawing.Point(49, 43);
            iDENTIFICACIONLabel.Name = "iDENTIFICACIONLabel";
            iDENTIFICACIONLabel.Size = new System.Drawing.Size(118, 17);
            iDENTIFICACIONLabel.TabIndex = 3;
            iDENTIFICACIONLabel.Text = "IDENTIFICACION:";
            // 
            // pRIMERAPELLIDOLabel
            // 
            pRIMERAPELLIDOLabel.AutoSize = true;
            pRIMERAPELLIDOLabel.Location = new System.Drawing.Point(36, 76);
            pRIMERAPELLIDOLabel.Name = "pRIMERAPELLIDOLabel";
            pRIMERAPELLIDOLabel.Size = new System.Drawing.Size(131, 17);
            pRIMERAPELLIDOLabel.TabIndex = 5;
            pRIMERAPELLIDOLabel.Text = "PRIMERAPELLIDO:";
            // 
            // pRIMERNOMBRELabel
            // 
            pRIMERNOMBRELabel.AutoSize = true;
            pRIMERNOMBRELabel.Location = new System.Drawing.Point(43, 115);
            pRIMERNOMBRELabel.Name = "pRIMERNOMBRELabel";
            pRIMERNOMBRELabel.Size = new System.Drawing.Size(124, 17);
            pRIMERNOMBRELabel.TabIndex = 7;
            pRIMERNOMBRELabel.Text = "PRIMERNOMBRE:";
            // 
            // sEGUNDOAPELLIDOLabel
            // 
            sEGUNDOAPELLIDOLabel.AutoSize = true;
            sEGUNDOAPELLIDOLabel.Location = new System.Drawing.Point(404, 76);
            sEGUNDOAPELLIDOLabel.Name = "sEGUNDOAPELLIDOLabel";
            sEGUNDOAPELLIDOLabel.Size = new System.Drawing.Size(149, 17);
            sEGUNDOAPELLIDOLabel.TabIndex = 9;
            sEGUNDOAPELLIDOLabel.Text = "SEGUNDOAPELLIDO:";
            // 
            // sEGUNDONOMBRELabel
            // 
            sEGUNDONOMBRELabel.AutoSize = true;
            sEGUNDONOMBRELabel.Location = new System.Drawing.Point(411, 118);
            sEGUNDONOMBRELabel.Name = "sEGUNDONOMBRELabel";
            sEGUNDONOMBRELabel.Size = new System.Drawing.Size(142, 17);
            sEGUNDONOMBRELabel.TabIndex = 11;
            sEGUNDONOMBRELabel.Text = "SEGUNDONOMBRE:";
            // 
            // personasDataGridView
            // 
            this.personasDataGridView.AutoGenerateColumns = false;
            this.personasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.SEGUNDOAPELLIDO,
            this.dataGridViewCheckBoxColumn1});
            this.personasDataGridView.DataSource = this.personaMSJBindingSource1;
            this.personasDataGridView.Enabled = false;
            this.personasDataGridView.Location = new System.Drawing.Point(39, 208);
            this.personasDataGridView.Name = "personasDataGridView";
            this.personasDataGridView.RowHeadersWidth = 51;
            this.personasDataGridView.RowTemplate.Height = 24;
            this.personasDataGridView.Size = new System.Drawing.Size(1340, 227);
            this.personasDataGridView.TabIndex = 0;
            this.personasDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.personasDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SECUENCIAL";
            this.dataGridViewTextBoxColumn1.HeaderText = "SECUENCIAL";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 122;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CODIGOTIPOIDENTIFICACION";
            this.dataGridViewTextBoxColumn2.HeaderText = "CODIGO TIPO IDENTIFICACION";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 217;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IDENTIFICACION";
            this.dataGridViewTextBoxColumn3.HeaderText = "IDENTIFICACION";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PRIMERNOMBRE";
            this.dataGridViewTextBoxColumn4.HeaderText = "PRIMERNOMBRE";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SEGUNDONOMBRE";
            this.dataGridViewTextBoxColumn5.HeaderText = "SEGUNDONOMBRE";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PRIMERAPELLIDO";
            this.dataGridViewTextBoxColumn6.HeaderText = "PRIMERAPELLIDO";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // SEGUNDOAPELLIDO
            // 
            this.SEGUNDOAPELLIDO.DataPropertyName = "SEGUNDOAPELLIDO";
            this.SEGUNDOAPELLIDO.HeaderText = "SEGUNDOAPELLIDO";
            this.SEGUNDOAPELLIDO.Name = "SEGUNDOAPELLIDO";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "ESTAACTIVO";
            this.dataGridViewCheckBoxColumn1.HeaderText = "ESTAACTIVO";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 125;
            // 
            // personaMSJBindingSource1
            // 
            this.personaMSJBindingSource1.DataSource = typeof(Proxies.Persona.PersonaMSJ);
            // 
            // listarButton
            // 
            this.listarButton.Location = new System.Drawing.Point(145, 179);
            this.listarButton.Name = "listarButton";
            this.listarButton.Size = new System.Drawing.Size(87, 23);
            this.listarButton.TabIndex = 1;
            this.listarButton.Text = "Listar";
            this.listarButton.UseVisualStyleBackColor = true;
            this.listarButton.Click += new System.EventHandler(this.listarButton_Click);
            // 
            // guardarButton
            // 
            this.guardarButton.Location = new System.Drawing.Point(39, 179);
            this.guardarButton.Name = "guardarButton";
            this.guardarButton.Size = new System.Drawing.Size(88, 23);
            this.guardarButton.TabIndex = 2;
            this.guardarButton.Text = "Adicionar";
            this.guardarButton.UseVisualStyleBackColor = true;
            this.guardarButton.Click += new System.EventHandler(this.guardarButton_Click);
            // 
            // iDENTIFICACIONTextBox
            // 
            this.iDENTIFICACIONTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaMSJBindingSource1, "IDENTIFICACION", true));
            this.iDENTIFICACIONTextBox.Location = new System.Drawing.Point(186, 40);
            this.iDENTIFICACIONTextBox.Name = "iDENTIFICACIONTextBox";
            this.iDENTIFICACIONTextBox.Size = new System.Drawing.Size(190, 22);
            this.iDENTIFICACIONTextBox.TabIndex = 4;
            // 
            // pRIMERAPELLIDOTextBox
            // 
            this.pRIMERAPELLIDOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaMSJBindingSource1, "PRIMERAPELLIDO", true));
            this.pRIMERAPELLIDOTextBox.Location = new System.Drawing.Point(186, 73);
            this.pRIMERAPELLIDOTextBox.Name = "pRIMERAPELLIDOTextBox";
            this.pRIMERAPELLIDOTextBox.Size = new System.Drawing.Size(190, 22);
            this.pRIMERAPELLIDOTextBox.TabIndex = 6;
            // 
            // pRIMERNOMBRETextBox
            // 
            this.pRIMERNOMBRETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaMSJBindingSource1, "PRIMERNOMBRE", true));
            this.pRIMERNOMBRETextBox.Location = new System.Drawing.Point(186, 110);
            this.pRIMERNOMBRETextBox.Name = "pRIMERNOMBRETextBox";
            this.pRIMERNOMBRETextBox.Size = new System.Drawing.Size(190, 22);
            this.pRIMERNOMBRETextBox.TabIndex = 8;
            // 
            // sEGUNDOAPELLIDOTextBox
            // 
            this.sEGUNDOAPELLIDOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaMSJBindingSource1, "SEGUNDOAPELLIDO", true));
            this.sEGUNDOAPELLIDOTextBox.Location = new System.Drawing.Point(566, 73);
            this.sEGUNDOAPELLIDOTextBox.Name = "sEGUNDOAPELLIDOTextBox";
            this.sEGUNDOAPELLIDOTextBox.Size = new System.Drawing.Size(207, 22);
            this.sEGUNDOAPELLIDOTextBox.TabIndex = 10;
            // 
            // sEGUNDONOMBRETextBox
            // 
            this.sEGUNDONOMBRETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personaMSJBindingSource1, "SEGUNDONOMBRE", true));
            this.sEGUNDONOMBRETextBox.Location = new System.Drawing.Point(566, 115);
            this.sEGUNDONOMBRETextBox.Name = "sEGUNDONOMBRETextBox";
            this.sEGUNDONOMBRETextBox.Size = new System.Drawing.Size(207, 22);
            this.sEGUNDONOMBRETextBox.TabIndex = 12;
            // 
            // personaWS1
            // 
            this.personaWS1.Credentials = null;
            this.personaWS1.Url = "http://localhost/Servidor/Servicios/PersonaWS.asmx";
            this.personaWS1.UseDefaultCredentials = false;
            // 
            // buscarButton
            // 
            this.buscarButton.Location = new System.Drawing.Point(407, 38);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(75, 26);
            this.buscarButton.TabIndex = 13;
            this.buscarButton.Text = "Buscar";
            this.buscarButton.UseVisualStyleBackColor = true;
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tipoIdentificacionBindingSource;
            this.comboBox1.DisplayMember = "NOMBRE";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(186, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.ValueMember = "CODIGO";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tipoIdentificacionBindingSource
            // 
            this.tipoIdentificacionBindingSource.DataSource = typeof(Proxies.TipoIdentificacion.TipoIdentificacionMSJ);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "TIPOIDENTIFICACION";
            // 
            // PersonasFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 465);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buscarButton);
            this.Controls.Add(sEGUNDONOMBRELabel);
            this.Controls.Add(this.sEGUNDONOMBRETextBox);
            this.Controls.Add(sEGUNDOAPELLIDOLabel);
            this.Controls.Add(this.sEGUNDOAPELLIDOTextBox);
            this.Controls.Add(pRIMERNOMBRELabel);
            this.Controls.Add(this.pRIMERNOMBRETextBox);
            this.Controls.Add(pRIMERAPELLIDOLabel);
            this.Controls.Add(this.pRIMERAPELLIDOTextBox);
            this.Controls.Add(iDENTIFICACIONLabel);
            this.Controls.Add(this.iDENTIFICACIONTextBox);
            this.Controls.Add(this.guardarButton);
            this.Controls.Add(this.listarButton);
            this.Controls.Add(this.personasDataGridView);
            this.Name = "PersonasFrm";
            this.Text = "PersonasFrm";
            this.Load += new System.EventHandler(this.PersonasFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaMSJBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaMSJBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoIdentificacionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.DataGridView personasDataGridView;
        private System.Windows.Forms.Button listarButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn sECUENCIALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODIGOTIPOIDENTIFICACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDENTIFICACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRIMERNOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEGUNDONOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRIMERAPELLIDODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEGUNDOAPELLIDODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn eSTAACTIVODataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource personaMSJBindingSource;
        private System.Windows.Forms.BindingSource personaMSJBindingSource1;
        private System.Windows.Forms.Button guardarButton;
        private Proxies.Persona.PersonaWS personaWS1;
        private System.Windows.Forms.TextBox iDENTIFICACIONTextBox;
        private System.Windows.Forms.TextBox pRIMERAPELLIDOTextBox;
        private System.Windows.Forms.TextBox pRIMERNOMBRETextBox;
        private System.Windows.Forms.TextBox sEGUNDOAPELLIDOTextBox;
        private System.Windows.Forms.TextBox sEGUNDONOMBRETextBox;
        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEGUNDOAPELLIDO;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.BindingSource tipoIdentificacionBindingSource;
    }
}