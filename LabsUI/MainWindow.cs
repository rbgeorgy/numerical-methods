using Common;
using lab1_2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace LabsUI
{
    public partial class MainWindow : Form
    {
        private NumericalMethodImplementation _numericalMethodImplementation;
        GridDataView _gridDataView;
        public MainWindow()
        {
            InitializeComponent();
            findRootsButton.Enabled = false;

            _numericalMethodImplementation = new NumericalMethodImplementation();

            #region OnTextFieldsInit
            if(FillNumericTextBoxSuccessful(aBoundTextValue))
                _numericalMethodImplementation.ABound = Tools.ParseDoubleWithPi(aBoundTextValue.Text);
            if(FillNumericTextBoxSuccessful(bBoundTextValue))
                _numericalMethodImplementation.BBound = Tools.ParseDoubleWithPi(bBoundTextValue.Text);
            if(FillNumericTextBoxSuccessful(epsilonTextValue))
                _numericalMethodImplementation.Epsilon = Tools.ParseDoubleWithPi(epsilonTextValue.Text);
            #endregion
        }

        #region OnTextFieldsChanged

        private bool FillNumericTextBoxSuccessful(TextBox textBox)
        {
            if (!string.IsNullOrEmpty(textBox.Text) && Tools.IsParseable(textBox.Text))
            {
                textBox.BackColor = Color.LightGreen;
                return true;
            }
            
            textBox.BackColor = Color.MediumVioletRed;
            return false;
        }

        private void aBoundTextValue_TextChanged(object sender, EventArgs e)
        {
            if(FillNumericTextBoxSuccessful(aBoundTextValue))
                _numericalMethodImplementation.ABound = Tools.ParseDoubleWithPi(aBoundTextValue.Text);
        }

        private void bBoundTextValue_TextChanged(object sender, EventArgs e)
        {
            if(FillNumericTextBoxSuccessful(bBoundTextValue))
                _numericalMethodImplementation.BBound = Tools.ParseDoubleWithPi(bBoundTextValue.Text);
        }

        private void epsilonTextValue_TextChanged(object sender, EventArgs e)
        {
            if(FillNumericTextBoxSuccessful(epsilonTextValue))
                _numericalMethodImplementation.Epsilon = Tools.ParseDoubleWithPi(epsilonTextValue.Text);
        }
        #endregion

        private void drawGraphButton_Click(object sender, EventArgs e)
        {
            functionChart.Series[0] = new Series
            {
                ChartType = SeriesChartType.Line
            };
            var defaultChartAreas = functionChart.ChartAreas[0];
            defaultChartAreas.AxisX.Minimum = _numericalMethodImplementation.ABound - _numericalMethodImplementation.Epsilon;
            defaultChartAreas.AxisX.Maximum = _numericalMethodImplementation.BBound + _numericalMethodImplementation.Epsilon;
            defaultChartAreas.AxisY.Minimum = -Math.PI;
            defaultChartAreas.AxisY.Maximum = Math.PI;

            functionChart.Series[0].Color = Color.Chocolate;
            
            var seriesValues = _numericalMethodImplementation.CalculateSeries();
            foreach (var point in seriesValues)
            {
                functionChart.Series[0].Points.AddXY(point.Item1, point.Item2);   
            }

            findRootsButton.Enabled = true;
        }

        private void findRootsButton_Click(object sender, EventArgs e)
        {
            findRootsButton.Enabled = false;
            _gridDataView = new GridDataView();
            foreach (var root in _numericalMethodImplementation.ApproximateRoots)
            {
                _numericalMethodImplementation.ChordMethod(root - 0.3, root + 0.3);
            }

            
            for (var i = 0; i < _numericalMethodImplementation.ApproximatedRoots.Count; i++)
            {
                var row = (DataGridViewRow)_gridDataView.table.Rows[0].Clone();
                Debug.Assert(row != null, nameof(row) + " != null");
                row.Cells[0].Value = _numericalMethodImplementation.ApproximateRoots[i];
                row.Cells[1].Value = _numericalMethodImplementation.ApproximatedRoots[i];
                var result = _numericalMethodImplementation.Function(_numericalMethodImplementation.ApproximatedRoots[i]);
                row.Cells[2].Value = String.Format("{0:F15}", result);;
                _gridDataView.table.Rows.Add(row);
            }
            
            _gridDataView.Show();
        }
    }
}