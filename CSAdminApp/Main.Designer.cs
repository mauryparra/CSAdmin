namespace CSAdminApp
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.radioButtonAdmin = new System.Windows.Forms.RadioButton();
            this.radioButtonCertificados = new System.Windows.Forms.RadioButton();
            this.radioButtonConsultas = new System.Windows.Forms.RadioButton();
            this.radioButtonEquipos = new System.Windows.Forms.RadioButton();
            this.radioButtonAsistencia = new System.Windows.Forms.RadioButton();
            this.radioButtonContratos = new System.Windows.Forms.RadioButton();
            this.radioButtonPersonal = new System.Windows.Forms.RadioButton();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeCSAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer
            // 
            // 
            // toolStripContainer.BottomToolStripPanel
            // 
            this.toolStripContainer.BottomToolStripPanel.Controls.Add(this.statusStrip);
            // 
            // toolStripContainer.ContentPanel
            // 
            this.toolStripContainer.ContentPanel.Controls.Add(this.splitContainer);
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(834, 446);
            this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer.Name = "toolStripContainer";
            this.toolStripContainer.Size = new System.Drawing.Size(834, 492);
            this.toolStripContainer.TabIndex = 0;
            this.toolStripContainer.Text = "toolStripContainer1";
            // 
            // toolStripContainer.TopToolStripPanel
            // 
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.menuStrip);
            // 
            // statusStrip
            // 
            this.statusStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripProgressBar});
            this.statusStrip.Location = new System.Drawing.Point(0, 0);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(834, 22);
            this.statusStrip.TabIndex = 0;
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar.Visible = false;
            // 
            // splitContainer
            // 
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.radioButtonAdmin);
            this.splitContainer.Panel1.Controls.Add(this.radioButtonCertificados);
            this.splitContainer.Panel1.Controls.Add(this.radioButtonConsultas);
            this.splitContainer.Panel1.Controls.Add(this.radioButtonEquipos);
            this.splitContainer.Panel1.Controls.Add(this.radioButtonAsistencia);
            this.splitContainer.Panel1.Controls.Add(this.radioButtonContratos);
            this.splitContainer.Panel1.Controls.Add(this.radioButtonPersonal);
            this.splitContainer.Panel1MinSize = 144;
            this.splitContainer.Size = new System.Drawing.Size(834, 446);
            this.splitContainer.SplitterDistance = 144;
            this.splitContainer.SplitterWidth = 1;
            this.splitContainer.TabIndex = 0;
            // 
            // radioButtonAdmin
            // 
            this.radioButtonAdmin.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonAdmin.AutoSize = true;
            this.radioButtonAdmin.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSeaGreen;
            this.radioButtonAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.radioButtonAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.radioButtonAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAdmin.Location = new System.Drawing.Point(3, 225);
            this.radioButtonAdmin.MinimumSize = new System.Drawing.Size(134, 30);
            this.radioButtonAdmin.Name = "radioButtonAdmin";
            this.radioButtonAdmin.Padding = new System.Windows.Forms.Padding(2, 2, 2, 1);
            this.radioButtonAdmin.Size = new System.Drawing.Size(134, 31);
            this.radioButtonAdmin.TabIndex = 6;
            this.radioButtonAdmin.Text = "&Admin";
            this.radioButtonAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonAdmin.UseVisualStyleBackColor = true;
            this.radioButtonAdmin.CheckedChanged += new System.EventHandler(this.radioButtonAdmin_CheckedChanged);
            // 
            // radioButtonCertificados
            // 
            this.radioButtonCertificados.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonCertificados.AutoSize = true;
            this.radioButtonCertificados.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSeaGreen;
            this.radioButtonCertificados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.radioButtonCertificados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.radioButtonCertificados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonCertificados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCertificados.Location = new System.Drawing.Point(3, 188);
            this.radioButtonCertificados.MinimumSize = new System.Drawing.Size(134, 30);
            this.radioButtonCertificados.Name = "radioButtonCertificados";
            this.radioButtonCertificados.Padding = new System.Windows.Forms.Padding(2, 2, 2, 1);
            this.radioButtonCertificados.Size = new System.Drawing.Size(134, 31);
            this.radioButtonCertificados.TabIndex = 5;
            this.radioButtonCertificados.Text = "Ce&rtificados";
            this.radioButtonCertificados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonCertificados.UseVisualStyleBackColor = true;
            this.radioButtonCertificados.CheckedChanged += new System.EventHandler(this.radioButtonCertificados_CheckedChanged);
            // 
            // radioButtonConsultas
            // 
            this.radioButtonConsultas.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonConsultas.AutoSize = true;
            this.radioButtonConsultas.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSeaGreen;
            this.radioButtonConsultas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.radioButtonConsultas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.radioButtonConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonConsultas.Location = new System.Drawing.Point(3, 151);
            this.radioButtonConsultas.MinimumSize = new System.Drawing.Size(134, 30);
            this.radioButtonConsultas.Name = "radioButtonConsultas";
            this.radioButtonConsultas.Padding = new System.Windows.Forms.Padding(2, 2, 2, 1);
            this.radioButtonConsultas.Size = new System.Drawing.Size(134, 31);
            this.radioButtonConsultas.TabIndex = 4;
            this.radioButtonConsultas.Text = "&Consultas";
            this.radioButtonConsultas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonConsultas.UseVisualStyleBackColor = true;
            this.radioButtonConsultas.CheckedChanged += new System.EventHandler(this.radioButtonConsultas_CheckedChanged);
            // 
            // radioButtonEquipos
            // 
            this.radioButtonEquipos.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonEquipos.AutoSize = true;
            this.radioButtonEquipos.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSeaGreen;
            this.radioButtonEquipos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.radioButtonEquipos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.radioButtonEquipos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonEquipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonEquipos.Location = new System.Drawing.Point(3, 114);
            this.radioButtonEquipos.MinimumSize = new System.Drawing.Size(134, 30);
            this.radioButtonEquipos.Name = "radioButtonEquipos";
            this.radioButtonEquipos.Padding = new System.Windows.Forms.Padding(2, 2, 2, 1);
            this.radioButtonEquipos.Size = new System.Drawing.Size(134, 31);
            this.radioButtonEquipos.TabIndex = 3;
            this.radioButtonEquipos.Text = "&Equipos";
            this.radioButtonEquipos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonEquipos.UseVisualStyleBackColor = true;
            this.radioButtonEquipos.CheckedChanged += new System.EventHandler(this.radioButtonEquipos_CheckedChanged);
            // 
            // radioButtonAsistencia
            // 
            this.radioButtonAsistencia.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonAsistencia.AutoSize = true;
            this.radioButtonAsistencia.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSeaGreen;
            this.radioButtonAsistencia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.radioButtonAsistencia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.radioButtonAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonAsistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAsistencia.Location = new System.Drawing.Point(3, 77);
            this.radioButtonAsistencia.MinimumSize = new System.Drawing.Size(134, 30);
            this.radioButtonAsistencia.Name = "radioButtonAsistencia";
            this.radioButtonAsistencia.Padding = new System.Windows.Forms.Padding(2, 2, 2, 1);
            this.radioButtonAsistencia.Size = new System.Drawing.Size(134, 31);
            this.radioButtonAsistencia.TabIndex = 2;
            this.radioButtonAsistencia.Text = "A&sistencia";
            this.radioButtonAsistencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonAsistencia.UseVisualStyleBackColor = true;
            this.radioButtonAsistencia.CheckedChanged += new System.EventHandler(this.radioButtonAsistencia_CheckedChanged);
            // 
            // radioButtonContratos
            // 
            this.radioButtonContratos.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonContratos.AutoSize = true;
            this.radioButtonContratos.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSeaGreen;
            this.radioButtonContratos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.radioButtonContratos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.radioButtonContratos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonContratos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonContratos.Location = new System.Drawing.Point(3, 40);
            this.radioButtonContratos.MinimumSize = new System.Drawing.Size(134, 30);
            this.radioButtonContratos.Name = "radioButtonContratos";
            this.radioButtonContratos.Padding = new System.Windows.Forms.Padding(2, 2, 2, 1);
            this.radioButtonContratos.Size = new System.Drawing.Size(134, 31);
            this.radioButtonContratos.TabIndex = 1;
            this.radioButtonContratos.Text = "&Contratos";
            this.radioButtonContratos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonContratos.UseVisualStyleBackColor = true;
            this.radioButtonContratos.CheckedChanged += new System.EventHandler(this.radioButtonContratos_CheckedChanged);
            // 
            // radioButtonPersonal
            // 
            this.radioButtonPersonal.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonPersonal.AutoSize = true;
            this.radioButtonPersonal.Checked = true;
            this.radioButtonPersonal.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSeaGreen;
            this.radioButtonPersonal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.radioButtonPersonal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.radioButtonPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPersonal.Location = new System.Drawing.Point(3, 3);
            this.radioButtonPersonal.MinimumSize = new System.Drawing.Size(134, 30);
            this.radioButtonPersonal.Name = "radioButtonPersonal";
            this.radioButtonPersonal.Padding = new System.Windows.Forms.Padding(2, 2, 2, 1);
            this.radioButtonPersonal.Size = new System.Drawing.Size(134, 31);
            this.radioButtonPersonal.TabIndex = 0;
            this.radioButtonPersonal.TabStop = true;
            this.radioButtonPersonal.Text = "&Personal";
            this.radioButtonPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonPersonal.UseVisualStyleBackColor = true;
            this.radioButtonPersonal.CheckedChanged += new System.EventHandler(this.radioButtonPersonal_CheckedChanged);
            // 
            // menuStrip
            // 
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(834, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeCSAdminToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ay&uda";
            // 
            // acercaDeCSAdminToolStripMenuItem
            // 
            this.acercaDeCSAdminToolStripMenuItem.Name = "acercaDeCSAdminToolStripMenuItem";
            this.acercaDeCSAdminToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.acercaDeCSAdminToolStripMenuItem.Text = "&Acerca de CSAdmin";
            this.acercaDeCSAdminToolStripMenuItem.Click += new System.EventHandler(this.acercaDeCSAdminToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 492);
            this.Controls.Add(this.toolStripContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(850, 530);
            this.Name = "Main";
            this.Text = "CSAdmin";
            this.Load += new System.EventHandler(this.Main_Load);
            this.toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer.ContentPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.PerformLayout();
            this.toolStripContainer.ResumeLayout(false);
            this.toolStripContainer.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeCSAdminToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.RadioButton radioButtonPersonal;
        private System.Windows.Forms.RadioButton radioButtonAdmin;
        private System.Windows.Forms.RadioButton radioButtonCertificados;
        private System.Windows.Forms.RadioButton radioButtonConsultas;
        private System.Windows.Forms.RadioButton radioButtonEquipos;
        private System.Windows.Forms.RadioButton radioButtonAsistencia;
        private System.Windows.Forms.RadioButton radioButtonContratos;
    }
}

