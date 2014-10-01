namespace CSAdminApp.Pantallas
{
    partial class telPopUp
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
            this.maskedTextBoxTel = new System.Windows.Forms.MaskedTextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.maskedTextBoxCel = new System.Windows.Forms.MaskedTextBox();
            this.labelCel = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // maskedTextBoxTel
            // 
            this.maskedTextBoxTel.Location = new System.Drawing.Point(70, 21);
            this.maskedTextBoxTel.Mask = "(999) 000-0000";
            this.maskedTextBoxTel.Name = "maskedTextBoxTel";
            this.maskedTextBoxTel.PromptChar = ' ';
            this.maskedTextBoxTel.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxTel.TabIndex = 10;
            this.maskedTextBoxTel.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // buttonOk
            // 
            this.buttonOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonOk.Location = new System.Drawing.Point(15, 85);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(43, 25);
            this.buttonOk.TabIndex = 12;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(12, 24);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(52, 13);
            this.labelTelefono.TabIndex = 9;
            this.labelTelefono.Text = "Teléfono:";
            // 
            // maskedTextBoxCel
            // 
            this.maskedTextBoxCel.Location = new System.Drawing.Point(70, 52);
            this.maskedTextBoxCel.Mask = "(999) 000-0000";
            this.maskedTextBoxCel.Name = "maskedTextBoxCel";
            this.maskedTextBoxCel.PromptChar = ' ';
            this.maskedTextBoxCel.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxCel.TabIndex = 14;
            this.maskedTextBoxCel.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // labelCel
            // 
            this.labelCel.AutoSize = true;
            this.labelCel.Location = new System.Drawing.Point(12, 55);
            this.labelCel.Name = "labelCel";
            this.labelCel.Size = new System.Drawing.Size(42, 13);
            this.labelCel.TabIndex = 13;
            this.labelCel.Text = "Celular:";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonCancelar.Location = new System.Drawing.Point(75, 85);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(89, 25);
            this.buttonCancelar.TabIndex = 15;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // telPopUp
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancelar;
            this.ClientSize = new System.Drawing.Size(187, 122);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.maskedTextBoxCel);
            this.Controls.Add(this.labelCel);
            this.Controls.Add(this.maskedTextBoxTel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelTelefono);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "telPopUp";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Teléfonos";
            this.Load += new System.EventHandler(this.telPopUp_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telPopUp_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.MaskedTextBox maskedTextBoxTel;
        internal System.Windows.Forms.Button buttonOk;
        internal System.Windows.Forms.Label labelTelefono;
        internal System.Windows.Forms.MaskedTextBox maskedTextBoxCel;
        internal System.Windows.Forms.Label labelCel;
        internal System.Windows.Forms.Button buttonCancelar;


    }
}