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
    public partial class reportViewerNUT : Form
    {
        public reportViewerNUT(int id)
        {
            InitializeComponent();

            rptNUT rptNut = new rptNUT();

            //((TextObject)rptNut.Section2.ReportObjects["Hello,"]).Text = name;

            //TextObject to = (TextObject)rptNut.ReportDefinition.Sections["Section3"].ReportObjects["Hello,"];
            //to.Text = "newvalue";
            ReportDocument reportDocument = new ReportDocument();

            ParameterField parameterField = new ParameterField();

            ParameterFields parameterFields = new ParameterFields();

            ParameterDiscreteValue parameterDiscreteValue = new ParameterDiscreteValue();

            parameterField.Name = "employeeID";

            parameterDiscreteValue.Value = id;

            parameterField.CurrentValues.Add(parameterDiscreteValue);

            parameterFields.Add(parameterField);

            crystalReportViewer1.ParameterFieldInfo = parameterFields;

            //crystalReportViewer1.ReportSource = reportDocument;

            reportDocument.Load(@"C:\Users\shart\source\repos\Microcenter\Microcenter\PrintingLayer\rptNUT.rpt");

            crystalReportViewer1.ReportSource = reportDocument;

        }
    }
}
