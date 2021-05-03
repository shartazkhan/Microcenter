using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Microcenter.PrintingLayer
{
    public partial class reportViewerInvoice : Form
    {
        public reportViewerInvoice(int id)
        {
            InitializeComponent();

            rptInvoice rptInvoice = new rptInvoice();

            ReportDocument reportDocument = new ReportDocument();

            ParameterField parameterField = new ParameterField();

            ParameterFields parameterFields = new ParameterFields();

            ParameterDiscreteValue parameterDiscreteValue = new ParameterDiscreteValue();

            parameterField.Name = "invoiceID";

            parameterDiscreteValue.Value = id;

            parameterField.CurrentValues.Add(parameterDiscreteValue);

            parameterFields.Add(parameterField);

            crystalReportViewer2.ParameterFieldInfo = parameterFields;

            //crystalReportViewer1.ReportSource = reportDocument;

            reportDocument.Load(@"C:\Users\shart\source\repos\Microcenter\Microcenter\PrintingLayer\rptInvoice.rpt");

            crystalReportViewer2.ReportSource = reportDocument;
        }
    }
}
