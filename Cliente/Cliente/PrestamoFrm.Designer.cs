namespace Cliente
{
    partial class PrestamoFrm
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
            this.GuardarButton = new System.Windows.Forms.Button();
            this.iDENTIFICACIONtextBox = new System.Windows.Forms.TextBox();
            this.mONTOtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "IDENTIFICACION";
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(305, 111);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 23);
            this.GuardarButton.TabIndex = 1;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // iDENTIFICACIONtextBox
            // 
            this.iDENTIFICACIONtextBox.Location = new System.Drawing.Point(170, 33);
            this.iDENTIFICACIONtextBox.Name = "iDENTIFICACIONtextBox";
            this.iDENTIFICACIONtextBox.Size = new System.Drawing.Size(210, 22);
            this.iDENTIFICACIONtextBox.TabIndex = 2;
            // 
            // mONTOtextBox
            // 
            this.mONTOtextBox.Location = new System.Drawing.Point(170, 65);
            this.mONTOtextBox.Name = "mONTOtextBox";
            this.mONTOtextBox.Size = new System.Drawing.Size(210, 22);
            this.mONTOtextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "MONTO";
            // 
            // PrestamoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 219);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mONTOtextBox);
            this.Controls.Add(this.iDENTIFICACIONtextBox);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.label1);
            this.Name = "PrestamoFrm";
            this.Text = "PrestamoFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.TextBox iDENTIFICACIONtextBox;
        private System.Windows.Forms.TextBox mONTOtextBox;
        private System.Windows.Forms.Label label2;
    }
}