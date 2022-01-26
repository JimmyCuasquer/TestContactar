namespace Cliente
{
    partial class PagoFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.vALORlabel = new System.Windows.Forms.Label();
            this.sECUENCIALPRESTAMOTextBox = new System.Windows.Forms.TextBox();
            this.GuardarPagoButton = new System.Windows.Forms.Button();
            this.vALORTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "SECUENCIALPRESTAMO";
            // 
            // vALORlabel
            // 
            this.vALORlabel.AutoSize = true;
            this.vALORlabel.Location = new System.Drawing.Point(81, 96);
            this.vALORlabel.Name = "vALORlabel";
            this.vALORlabel.Size = new System.Drawing.Size(55, 17);
            this.vALORlabel.TabIndex = 1;
            this.vALORlabel.Text = "VALOR";
            // 
            // sECUENCIALPRESTAMOTextBox
            // 
            this.sECUENCIALPRESTAMOTextBox.Location = new System.Drawing.Point(196, 46);
            this.sECUENCIALPRESTAMOTextBox.Name = "sECUENCIALPRESTAMOTextBox";
            this.sECUENCIALPRESTAMOTextBox.Size = new System.Drawing.Size(170, 22);
            this.sECUENCIALPRESTAMOTextBox.TabIndex = 2;
            // 
            // GuardarPagoButton
            // 
            this.GuardarPagoButton.Location = new System.Drawing.Point(271, 142);
            this.GuardarPagoButton.Name = "GuardarPagoButton";
            this.GuardarPagoButton.Size = new System.Drawing.Size(95, 23);
            this.GuardarPagoButton.TabIndex = 3;
            this.GuardarPagoButton.Text = "Guardar";
            this.GuardarPagoButton.UseVisualStyleBackColor = true;
            this.GuardarPagoButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // vALORTextBox
            // 
            this.vALORTextBox.Location = new System.Drawing.Point(196, 91);
            this.vALORTextBox.Name = "vALORTextBox";
            this.vALORTextBox.Size = new System.Drawing.Size(170, 22);
            this.vALORTextBox.TabIndex = 4;
            // 
            // PagoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 227);
            this.Controls.Add(this.vALORTextBox);
            this.Controls.Add(this.GuardarPagoButton);
            this.Controls.Add(this.sECUENCIALPRESTAMOTextBox);
            this.Controls.Add(this.vALORlabel);
            this.Controls.Add(this.label1);
            this.Name = "PagoFrm";
            this.Text = "PagoFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label vALORlabel;
        private System.Windows.Forms.TextBox sECUENCIALPRESTAMOTextBox;
        private System.Windows.Forms.Button GuardarPagoButton;
        private System.Windows.Forms.TextBox vALORTextBox;
    }
}