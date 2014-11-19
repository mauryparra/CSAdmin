namespace CSAdminApp.Pantallas
{
    partial class pAdmin
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControlAdmin = new System.Windows.Forms.TabControl();
            this.tabPageFunciones = new System.Windows.Forms.TabPage();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.fButtonCancelar = new System.Windows.Forms.Button();
            this.fButtonGuardar = new System.Windows.Forms.Button();
            this.fButtonRecargar = new System.Windows.Forms.Button();
            this.dataGridViewFunciones = new System.Windows.Forms.DataGridView();
            this.entityDataSource = new EFWinforms.EntityDataSource(this.components);
            this.dataGridViewContratos = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageSituacProfesionales = new System.Windows.Forms.TabPage();
            this.sButtonCancelar = new System.Windows.Forms.Button();
            this.sButtonGuardar = new System.Windows.Forms.Button();
            this.sButtonRecargar = new System.Windows.Forms.Button();
            this.dataGridViewSitPro = new System.Windows.Forms.DataGridView();
            this.tabPageUsuarios = new System.Windows.Forms.TabPage();
            this.uButtonCancelar = new System.Windows.Forms.Button();
            this.uButtonGuardar = new System.Windows.Forms.Button();
            this.uButtonRecargar = new System.Windows.Forms.Button();
            this.tabPageLocalidades = new System.Windows.Forms.TabPage();
            this.lButtonCancelar = new System.Windows.Forms.Button();
            this.lButtonGuardar = new System.Windows.Forms.Button();
            this.lButtonRecargar = new System.Windows.Forms.Button();
            this.dataGridViewLocalidades = new System.Windows.Forms.DataGridView();
            this.tabControlAdmin.SuspendLayout();
            this.tabPageFunciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContratos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPageSituacProfesionales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSitPro)).BeginInit();
            this.tabPageUsuarios.SuspendLayout();
            this.tabPageLocalidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocalidades)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlAdmin
            // 
            this.tabControlAdmin.Controls.Add(this.tabPageFunciones);
            this.tabControlAdmin.Controls.Add(this.tabPageSituacProfesionales);
            this.tabControlAdmin.Controls.Add(this.tabPageUsuarios);
            this.tabControlAdmin.Controls.Add(this.tabPageLocalidades);
            this.tabControlAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlAdmin.Location = new System.Drawing.Point(0, 0);
            this.tabControlAdmin.Name = "tabControlAdmin";
            this.tabControlAdmin.SelectedIndex = 0;
            this.tabControlAdmin.Size = new System.Drawing.Size(689, 446);
            this.tabControlAdmin.TabIndex = 1;
            // 
            // tabPageFunciones
            // 
            this.tabPageFunciones.Controls.Add(this.splitContainer);
            this.tabPageFunciones.Location = new System.Drawing.Point(4, 24);
            this.tabPageFunciones.Name = "tabPageFunciones";
            this.tabPageFunciones.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFunciones.Size = new System.Drawing.Size(681, 418);
            this.tabPageFunciones.TabIndex = 0;
            this.tabPageFunciones.Text = "Funciones";
            this.tabPageFunciones.UseVisualStyleBackColor = true;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(3, 3);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.fButtonCancelar);
            this.splitContainer.Panel1.Controls.Add(this.fButtonGuardar);
            this.splitContainer.Panel1.Controls.Add(this.fButtonRecargar);
            this.splitContainer.Panel1.Controls.Add(this.dataGridViewFunciones);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.label1);
            this.splitContainer.Panel2.Controls.Add(this.dataGridViewContratos);
            this.splitContainer.Size = new System.Drawing.Size(675, 412);
            this.splitContainer.SplitterDistance = 225;
            this.splitContainer.TabIndex = 0;
            // 
            // fButtonCancelar
            // 
            this.fButtonCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fButtonCancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSeaGreen;
            this.fButtonCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepPink;
            this.fButtonCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.fButtonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fButtonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fButtonCancelar.Location = new System.Drawing.Point(584, 194);
            this.fButtonCancelar.Name = "fButtonCancelar";
            this.fButtonCancelar.Size = new System.Drawing.Size(88, 26);
            this.fButtonCancelar.TabIndex = 36;
            this.fButtonCancelar.Text = "&Cancelar";
            this.fButtonCancelar.UseVisualStyleBackColor = true;
            this.fButtonCancelar.Click += new System.EventHandler(this.fButtonCancelar_Click);
            // 
            // fButtonGuardar
            // 
            this.fButtonGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fButtonGuardar.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSeaGreen;
            this.fButtonGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.fButtonGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.fButtonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fButtonGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fButtonGuardar.Location = new System.Drawing.Point(385, 194);
            this.fButtonGuardar.Name = "fButtonGuardar";
            this.fButtonGuardar.Size = new System.Drawing.Size(88, 26);
            this.fButtonGuardar.TabIndex = 35;
            this.fButtonGuardar.Text = "&Guardar";
            this.fButtonGuardar.UseVisualStyleBackColor = true;
            this.fButtonGuardar.Click += new System.EventHandler(this.fButtonGuardar_Click);
            // 
            // fButtonRecargar
            // 
            this.fButtonRecargar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fButtonRecargar.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSeaGreen;
            this.fButtonRecargar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.fButtonRecargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.fButtonRecargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fButtonRecargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fButtonRecargar.Location = new System.Drawing.Point(479, 194);
            this.fButtonRecargar.Name = "fButtonRecargar";
            this.fButtonRecargar.Size = new System.Drawing.Size(99, 26);
            this.fButtonRecargar.TabIndex = 34;
            this.fButtonRecargar.Text = "&Recargar";
            this.fButtonRecargar.UseVisualStyleBackColor = true;
            this.fButtonRecargar.Click += new System.EventHandler(this.fButtonRecargar_Click);
            // 
            // dataGridViewFunciones
            // 
            this.dataGridViewFunciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFunciones.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFunciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFunciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunciones.DataSource = this.entityDataSource;
            this.dataGridViewFunciones.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewFunciones.Name = "dataGridViewFunciones";
            this.dataGridViewFunciones.Size = new System.Drawing.Size(675, 188);
            this.dataGridViewFunciones.TabIndex = 0;
            // 
            // entityDataSource
            // 
            this.entityDataSource.DbContextType = typeof(CSAdminApp.Clases.CSAdminBDEntities);
            // 
            // dataGridViewContratos
            // 
            this.dataGridViewContratos.AllowUserToAddRows = false;
            this.dataGridViewContratos.AllowUserToDeleteRows = false;
            this.dataGridViewContratos.AllowUserToOrderColumns = true;
            this.dataGridViewContratos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewContratos.AutoGenerateColumns = false;
            this.entityDataSource.SetAutoLookup(this.dataGridViewContratos, true);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewContratos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewContratos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContratos.DataSource = this.entityDataSource;
            this.dataGridViewContratos.Location = new System.Drawing.Point(0, 29);
            this.dataGridViewContratos.Name = "dataGridViewContratos";
            this.dataGridViewContratos.ReadOnly = true;
            this.dataGridViewContratos.Size = new System.Drawing.Size(675, 154);
            this.dataGridViewContratos.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.entityDataSource.SetAutoLookup(this.dataGridView1, true);
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.entityDataSource;
            this.dataGridView1.Location = new System.Drawing.Point(4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(675, 374);
            this.dataGridView1.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contratos Asociados:";
            // 
            // tabPageSituacProfesionales
            // 
            this.tabPageSituacProfesionales.Controls.Add(this.sButtonCancelar);
            this.tabPageSituacProfesionales.Controls.Add(this.sButtonGuardar);
            this.tabPageSituacProfesionales.Controls.Add(this.sButtonRecargar);
            this.tabPageSituacProfesionales.Controls.Add(this.dataGridViewSitPro);
            this.tabPageSituacProfesionales.Location = new System.Drawing.Point(4, 24);
            this.tabPageSituacProfesionales.Name = "tabPageSituacProfesionales";
            this.tabPageSituacProfesionales.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSituacProfesionales.Size = new System.Drawing.Size(681, 418);
            this.tabPageSituacProfesionales.TabIndex = 1;
            this.tabPageSituacProfesionales.Text = "Situaciones Profesionales";
            this.tabPageSituacProfesionales.UseVisualStyleBackColor = true;
            // 
            // sButtonCancelar
            // 
            this.sButtonCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sButtonCancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSeaGreen;
            this.sButtonCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepPink;
            this.sButtonCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.sButtonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sButtonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sButtonCancelar.Location = new System.Drawing.Point(587, 384);
            this.sButtonCancelar.Name = "sButtonCancelar";
            this.sButtonCancelar.Size = new System.Drawing.Size(88, 26);
            this.sButtonCancelar.TabIndex = 33;
            this.sButtonCancelar.Text = "&Cancelar";
            this.sButtonCancelar.UseVisualStyleBackColor = true;
            this.sButtonCancelar.Click += new System.EventHandler(this.sButtonCancelar_Click);
            // 
            // sButtonGuardar
            // 
            this.sButtonGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sButtonGuardar.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSeaGreen;
            this.sButtonGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.sButtonGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.sButtonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sButtonGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sButtonGuardar.Location = new System.Drawing.Point(388, 384);
            this.sButtonGuardar.Name = "sButtonGuardar";
            this.sButtonGuardar.Size = new System.Drawing.Size(88, 26);
            this.sButtonGuardar.TabIndex = 32;
            this.sButtonGuardar.Text = "&Guardar";
            this.sButtonGuardar.UseVisualStyleBackColor = true;
            this.sButtonGuardar.Click += new System.EventHandler(this.sButtonGuardar_Click);
            // 
            // sButtonRecargar
            // 
            this.sButtonRecargar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sButtonRecargar.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSeaGreen;
            this.sButtonRecargar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.sButtonRecargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.sButtonRecargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sButtonRecargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sButtonRecargar.Location = new System.Drawing.Point(482, 384);
            this.sButtonRecargar.Name = "sButtonRecargar";
            this.sButtonRecargar.Size = new System.Drawing.Size(99, 26);
            this.sButtonRecargar.TabIndex = 31;
            this.sButtonRecargar.Text = "&Recargar";
            this.sButtonRecargar.UseVisualStyleBackColor = true;
            this.sButtonRecargar.Click += new System.EventHandler(this.sButtonRecargar_Click);
            // 
            // dataGridViewSitPro
            // 
            this.dataGridViewSitPro.AllowUserToOrderColumns = true;
            this.dataGridViewSitPro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSitPro.AutoGenerateColumns = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSitPro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewSitPro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSitPro.DataSource = this.entityDataSource;
            this.dataGridViewSitPro.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewSitPro.Name = "dataGridViewSitPro";
            this.dataGridViewSitPro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewSitPro.Size = new System.Drawing.Size(675, 374);
            this.dataGridViewSitPro.TabIndex = 0;
            // 
            // tabPageUsuarios
            // 
            this.tabPageUsuarios.Controls.Add(this.dataGridView1);
            this.tabPageUsuarios.Controls.Add(this.uButtonCancelar);
            this.tabPageUsuarios.Controls.Add(this.uButtonGuardar);
            this.tabPageUsuarios.Controls.Add(this.uButtonRecargar);
            this.tabPageUsuarios.Location = new System.Drawing.Point(4, 24);
            this.tabPageUsuarios.Name = "tabPageUsuarios";
            this.tabPageUsuarios.Size = new System.Drawing.Size(681, 418);
            this.tabPageUsuarios.TabIndex = 3;
            this.tabPageUsuarios.Text = "Usuarios";
            this.tabPageUsuarios.UseVisualStyleBackColor = true;
            // 
            // uButtonCancelar
            // 
            this.uButtonCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uButtonCancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSeaGreen;
            this.uButtonCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepPink;
            this.uButtonCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.uButtonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uButtonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uButtonCancelar.Location = new System.Drawing.Point(587, 384);
            this.uButtonCancelar.Name = "uButtonCancelar";
            this.uButtonCancelar.Size = new System.Drawing.Size(88, 26);
            this.uButtonCancelar.TabIndex = 37;
            this.uButtonCancelar.Text = "&Cancelar";
            this.uButtonCancelar.UseVisualStyleBackColor = true;
            this.uButtonCancelar.Click += new System.EventHandler(this.uButtonCancelar_Click);
            // 
            // uButtonGuardar
            // 
            this.uButtonGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uButtonGuardar.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSeaGreen;
            this.uButtonGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.uButtonGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.uButtonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uButtonGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uButtonGuardar.Location = new System.Drawing.Point(388, 384);
            this.uButtonGuardar.Name = "uButtonGuardar";
            this.uButtonGuardar.Size = new System.Drawing.Size(88, 26);
            this.uButtonGuardar.TabIndex = 36;
            this.uButtonGuardar.Text = "&Guardar";
            this.uButtonGuardar.UseVisualStyleBackColor = true;
            this.uButtonGuardar.Click += new System.EventHandler(this.uButtonGuardar_Click);
            // 
            // uButtonRecargar
            // 
            this.uButtonRecargar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uButtonRecargar.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSeaGreen;
            this.uButtonRecargar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.uButtonRecargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.uButtonRecargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uButtonRecargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uButtonRecargar.Location = new System.Drawing.Point(482, 384);
            this.uButtonRecargar.Name = "uButtonRecargar";
            this.uButtonRecargar.Size = new System.Drawing.Size(99, 26);
            this.uButtonRecargar.TabIndex = 35;
            this.uButtonRecargar.Text = "&Recargar";
            this.uButtonRecargar.UseVisualStyleBackColor = true;
            this.uButtonRecargar.Click += new System.EventHandler(this.uButtonRecargar_Click);
            // 
            // tabPageLocalidades
            // 
            this.tabPageLocalidades.Controls.Add(this.lButtonCancelar);
            this.tabPageLocalidades.Controls.Add(this.lButtonGuardar);
            this.tabPageLocalidades.Controls.Add(this.lButtonRecargar);
            this.tabPageLocalidades.Controls.Add(this.dataGridViewLocalidades);
            this.tabPageLocalidades.Location = new System.Drawing.Point(4, 24);
            this.tabPageLocalidades.Name = "tabPageLocalidades";
            this.tabPageLocalidades.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLocalidades.Size = new System.Drawing.Size(681, 418);
            this.tabPageLocalidades.TabIndex = 2;
            this.tabPageLocalidades.Text = "Localidades";
            this.tabPageLocalidades.UseVisualStyleBackColor = true;
            // 
            // lButtonCancelar
            // 
            this.lButtonCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lButtonCancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSeaGreen;
            this.lButtonCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepPink;
            this.lButtonCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.HotPink;
            this.lButtonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lButtonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lButtonCancelar.Location = new System.Drawing.Point(587, 384);
            this.lButtonCancelar.Name = "lButtonCancelar";
            this.lButtonCancelar.Size = new System.Drawing.Size(88, 26);
            this.lButtonCancelar.TabIndex = 41;
            this.lButtonCancelar.Text = "&Cancelar";
            this.lButtonCancelar.UseVisualStyleBackColor = true;
            this.lButtonCancelar.Click += new System.EventHandler(this.lButtonCancelar_Click);
            // 
            // lButtonGuardar
            // 
            this.lButtonGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lButtonGuardar.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSeaGreen;
            this.lButtonGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.lButtonGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.lButtonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lButtonGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lButtonGuardar.Location = new System.Drawing.Point(388, 384);
            this.lButtonGuardar.Name = "lButtonGuardar";
            this.lButtonGuardar.Size = new System.Drawing.Size(88, 26);
            this.lButtonGuardar.TabIndex = 40;
            this.lButtonGuardar.Text = "&Guardar";
            this.lButtonGuardar.UseVisualStyleBackColor = true;
            this.lButtonGuardar.Click += new System.EventHandler(this.lButtonGuardar_Click);
            // 
            // lButtonRecargar
            // 
            this.lButtonRecargar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lButtonRecargar.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSeaGreen;
            this.lButtonRecargar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.lButtonRecargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.lButtonRecargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lButtonRecargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lButtonRecargar.Location = new System.Drawing.Point(482, 384);
            this.lButtonRecargar.Name = "lButtonRecargar";
            this.lButtonRecargar.Size = new System.Drawing.Size(99, 26);
            this.lButtonRecargar.TabIndex = 39;
            this.lButtonRecargar.Text = "&Recargar";
            this.lButtonRecargar.UseVisualStyleBackColor = true;
            this.lButtonRecargar.Click += new System.EventHandler(this.lButtonRecargar_Click);
            // 
            // dataGridViewLocalidades
            // 
            this.dataGridViewLocalidades.AllowUserToOrderColumns = true;
            this.dataGridViewLocalidades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewLocalidades.AutoGenerateColumns = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLocalidades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewLocalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLocalidades.DataSource = this.entityDataSource;
            this.dataGridViewLocalidades.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewLocalidades.Name = "dataGridViewLocalidades";
            this.dataGridViewLocalidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewLocalidades.Size = new System.Drawing.Size(675, 374);
            this.dataGridViewLocalidades.TabIndex = 38;
            // 
            // pAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlAdmin);
            this.Name = "pAdmin";
            this.Size = new System.Drawing.Size(689, 446);
            this.tabControlAdmin.ResumeLayout(false);
            this.tabPageFunciones.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContratos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPageSituacProfesionales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSitPro)).EndInit();
            this.tabPageUsuarios.ResumeLayout(false);
            this.tabPageLocalidades.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocalidades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TabControl tabControlAdmin;
        internal System.Windows.Forms.TabPage tabPageFunciones;
        internal System.Windows.Forms.SplitContainer splitContainer;
        internal System.Windows.Forms.TabPage tabPageSituacProfesionales;
        internal System.Windows.Forms.TabPage tabPageUsuarios;
        internal System.Windows.Forms.TabPage tabPageLocalidades;
        private EFWinforms.EntityDataSource entityDataSource;
        private System.Windows.Forms.DataGridView dataGridViewSitPro;
        internal System.Windows.Forms.Button sButtonCancelar;
        internal System.Windows.Forms.Button sButtonGuardar;
        internal System.Windows.Forms.Button sButtonRecargar;
        private System.Windows.Forms.DataGridView dataGridViewFunciones;
        internal System.Windows.Forms.Button fButtonCancelar;
        internal System.Windows.Forms.Button fButtonGuardar;
        internal System.Windows.Forms.Button fButtonRecargar;
        private System.Windows.Forms.DataGridView dataGridViewContratos;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button uButtonCancelar;
        internal System.Windows.Forms.Button uButtonGuardar;
        internal System.Windows.Forms.Button uButtonRecargar;
        internal System.Windows.Forms.Button lButtonCancelar;
        internal System.Windows.Forms.Button lButtonGuardar;
        internal System.Windows.Forms.Button lButtonRecargar;
        private System.Windows.Forms.DataGridView dataGridViewLocalidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoAbrevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn condicionAbrevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn condicionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPersonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personasDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn personaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaBajaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn afectadoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn origenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn condicionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionDataGridViewTextBoxColumn;
    }
}
