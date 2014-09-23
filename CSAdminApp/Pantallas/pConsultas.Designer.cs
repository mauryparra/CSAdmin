namespace CSAdminApp.Pantallas
{
    partial class pConsultas
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cSAdminBDEntitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cSAdminBDEntitiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetAsistencia";
            reportDataSource1.Value = this.cSAdminBDEntitiesBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "CSAdminApp.Reportes.ReporteAsistencia.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.Size = new System.Drawing.Size(689, 446);
            this.reportViewer.TabIndex = 0;
            // 
            // cSAdminBDEntitiesBindingSource
            // 
            this.cSAdminBDEntitiesBindingSource.DataSource = typeof(CSAdminApp.Clases.CSAdminBDEntities);
            // 
            // pConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reportViewer);
            this.Name = "pConsultas";
            this.Size = new System.Drawing.Size(689, 446);
            this.Load += new System.EventHandler(this.pConsultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cSAdminBDEntitiesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.BindingSource cSAdminBDEntitiesBindingSource;
    }
}
