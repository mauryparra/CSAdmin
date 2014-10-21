using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Reporting.WinForms;

namespace CSAdminApp.Pantallas
{
    public partial class pConsultas : UserControl
    {
        private List<Clases.Inasistencias> lstInasistencias = new List<Clases.Inasistencias>();

        public pConsultas()
        {
            InitializeComponent();
        }

        private void pConsultas_Load(object sender, EventArgs e)
        {
            using (Clases.CSAdminBDEntities db = new Clases.CSAdminBDEntities())
            {
                lstInasistencias = db.Inasistencias.ToList();

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

        private void reportViewer_ReportRefresh(object sender, CancelEventArgs e)
        {
            // TODO
        }
    }
}
