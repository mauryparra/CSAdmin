using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.Reporting.WinForms;

namespace CSAdminApp.Pantallas
{
    public partial class pConsultas : UserControl
    {
        public pConsultas()
        {
            InitializeComponent();
        }

        private void pConsultas_Load(object sender, EventArgs e)
        {
            List<Clases.Inasistencias> lstInasistencias = new List<Clases.Inasistencias>();

            lstInasistencias = Main.BDContext.Inasistencias.ToList();

            string exeFolder = Path.GetDirectoryName(Application.StartupPath);
            string reportPath = Path.Combine(exeFolder, @"Release\Reportes\ReporteAsistencia.rdlc");

            reportViewer.ProcessingMode = ProcessingMode.Local;
            reportViewer.LocalReport.ReportPath = reportPath;

            ReportDataSource rDataSource = new ReportDataSource();
            rDataSource.Name = "DataSetAsistencia";
            rDataSource.Value = lstInasistencias;

            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(rDataSource);
            reportViewer.RefreshReport();
        }
    }
}
