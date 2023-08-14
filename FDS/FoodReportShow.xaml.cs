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
    /// Interaction logic for FoodReportShow.xaml
    /// </summary>
    public partial class FoodReportShow : Window
    {
        public FoodReportShow()
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
                FDSDataSet1 dataset = new FDSDataSet1();
                dataset.BeginInit();
                reportDataSource1.Name = "DataSet1";
                reportDataSource1.Value = dataset.FoodStoreWhole;
                this._reportViewer.LocalReport.DataSources.Add(reportDataSource1);
                this._reportViewer.LocalReport.ReportEmbeddedResource = "FDS.Report3.rdlc";
                dataset.EndInit();
                FDSDataSet1TableAdapters.FoodStoreWholeTableAdapter bentable = new FDSDataSet1TableAdapters.FoodStoreWholeTableAdapter();
                bentable.ClearBeforeFill = true;
                bentable.Fill(dataset.FoodStoreWhole);
                _reportViewer.RefreshReport();
                _isReportViewerLoaded = true;
            }
        }
    }
}
