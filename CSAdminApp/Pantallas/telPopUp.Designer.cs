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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.dataGridViewTel = new System.Windows.Forms.DataGridView();
            this.maskedTextBoxTel = new System.Windows.Forms.MaskedTextBox();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.labelTelefono = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTel)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.maskedTextBoxTel);
            this.splitContainer.Panel1.Controls.Add(this.buttonAgregar);
            this.splitContainer.Panel1.Controls.Add(this.comboBoxTipo);
            this.splitContainer.Panel1.Controls.Add(this.labelTelefono);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.dataGridViewTel);
            this.splitContainer.Size = new System.Drawing.Size(284, 122);
            this.splitContainer.SplitterDistance = 42;
            this.splitContainer.TabIndex = 1;
            // 
            // dataGridViewTel
            // 
            this.dataGridViewTel.AllowUserToAddRows = false;
            this.dataGridViewTel.AllowUserToDeleteRows = false;
            this.dataGridViewTel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTel.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTel.Name = "dataGridViewTel";
            this.dataGridViewTel.ReadOnly = true;
            this.dataGridViewTel.Size = new System.Drawing.Size(284, 76);
            this.dataGridViewTel.TabIndex = 1;
            // 
            // maskedTextBoxTel
            // 
            this.maskedTextBoxTel.Location = new System.Drawing.Point(70, 12);
            this.maskedTextBoxTel.Mask = "(999) 000-0000";
            this.maskedTextBoxTel.Name = "maskedTextBoxTel";
            this.maskedTextBoxTel.PromptChar = ' ';
            this.maskedTextBoxTel.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxTel.TabIndex = 6;
            this.maskedTextBoxTel.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgregar.Location = new System.Drawing.Point(242, 10);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(30, 23);
            this.buttonAgregar.TabIndex = 8;
            this.buttonAgregar.Text = "+";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBoxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "MO",
            "FI"});
            this.comboBoxTipo.Location = new System.Drawing.Point(176, 12);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(60, 21);
            this.comboBoxTipo.TabIndex = 7;
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(12, 15);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(52, 13);
            this.labelTelefono.TabIndex = 5;
            this.labelTelefono.Text = "Teléfono:";
            // 
            // telPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 122);
            this.Controls.Add(this.splitContainer);
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
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.SplitContainer splitContainer;
        internal System.Windows.Forms.DataGridView dataGridViewTel;
        internal System.Windows.Forms.MaskedTextBox maskedTextBoxTel;
        internal System.Windows.Forms.Button buttonAgregar;
        internal System.Windows.Forms.ComboBox comboBoxTipo;
        internal System.Windows.Forms.Label labelTelefono;

    }
}