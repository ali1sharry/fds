using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FDS
{
    /// <summary>
    /// Interaction logic for BenReportShow.xaml
    /// </summary>
    public partial class BenReportShow : Window
    {
        public BenReportShow()
        {
            InitializeComponent();
            _reportViewer.Load += ReportViewer_Load;
        }
        private bool _isReportViewerLoaded;

        private void ReportViewer_Load(object sender, EventArgs e)
        {
            if (!_isReportViewerLoaded)
            {
                ReportDataSource reportDataSource1 = new ReportDataSource();
                FDSDataSet dataset = new FDSDataSet();
                dataset.BeginInit();
                reportDataSource1.Name = "DataSet1";
                reportDataSource1.Value = dataset.Beneficiaries;
                this._reportViewer.LocalReport.DataSources.Add(reportDataSource1);
                this._reportViewer.LocalReport.ReportEmbeddedResource = "FDS.Report1.rdlc";
                dataset.EndInit();
                FDSDataSetTableAdapters.BeneficiariesTableAdapter bentable = new FDSDataSetTableAdapters.BeneficiariesTableAdapter();
                bentable.ClearBeforeFill = true;
                bentable.Fill(dataset.Beneficiaries);
                _reportViewer.RefreshReport();
                _isReportViewerLoaded = true;
            }
        }
    }
}
