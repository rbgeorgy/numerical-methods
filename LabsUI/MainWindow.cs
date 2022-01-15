using Common;
using lab1_2;
using lab3;
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
using NumericalMethodImplementation_lab1_2 = lab1_2.NumericalMethodImplementation;
using NumericalMethodImplementation_lab3 = lab3.NumericalMethodImplementation;

namespace LabsUI
{
    public partial class MainWindow : Form
    {
        
        private NumericalMethodImplementation_lab1_2 _numericalMethodImplementationLab1_2;
        private NumericalMethodImplementation_lab3 _numericalMethodImplementationLab3;
        GridDataView _gridDataView;
        public MainWindow()
        {
            InitializeComponent();
            findRootsButton.Enabled = false;
            findRootButtonLab3.Enabled = false;

            _numericalMethodImplementationLab1_2 = new NumericalMethodImplementation_lab1_2();
            _numericalMethodImplementationLab3 = new NumericalMethodImplementation_lab3();
            
            #region OnTextFieldsInit
            if(FillNumericTextBoxSuccessful(aBoundTextValue))
                _numericalMethodImplementationLab1_2.ABound = Tools.ParseDoubleWithPi(aBoundTextValue.Text);
            if(FillNumericTextBoxSuccessful(bBoundTextValue))
                _numericalMethodImplementationLab1_2.BBound = Tools.ParseDoubleWithPi(bBoundTextValue.Text);
            if(FillNumericTextBoxSuccessful(epsilonTextValue))
                _numericalMethodImplementationLab1_2.Epsilon = Tools.ParseDoubleWithPi(epsilonTextValue.Text);
            
            
            if(FillNumericTextBoxSuccessful(lab3epsilon))
                _numericalMethodImplementationLab3.Epsilon = Tools.ParseDoubleWithPi(lab3epsilon.Text);
            
            if(FillNumericTextBoxSuccessful(aBound1))
                _numericalMethodImplementationLab3.ABound1 = Tools.ParseDoubleWithPi(aBound1.Text);
            if(FillNumericTextBoxSuccessful(bBound1))
                _numericalMethodImplementationLab3.BBound1 = Tools.ParseDoubleWithPi(bBound1.Text);
            
            if(FillNumericTextBoxSuccessful(aBound2))
                _numericalMethodImplementationLab3.ABound2 = Tools.ParseDoubleWithPi(aBound2.Text);
            if(FillNumericTextBoxSuccessful(bBound2))
                _numericalMethodImplementationLab3.BBound2 = Tools.ParseDoubleWithPi(bBound2.Text);
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
                _numericalMethodImplementationLab1_2.ABound = Tools.ParseDoubleWithPi(aBoundTextValue.Text);
        }

        private void bBoundTextValue_TextChanged(object sender, EventArgs e)
        {
            if(FillNumericTextBoxSuccessful(bBoundTextValue))
                _numericalMethodImplementationLab1_2.BBound = Tools.ParseDoubleWithPi(bBoundTextValue.Text);
        }

        private void epsilonTextValue_TextChanged(object sender, EventArgs e)
        {
            if(FillNumericTextBoxSuccessful(epsilonTextValue))
                _numericalMethodImplementationLab1_2.Epsilon = Tools.ParseDoubleWithPi(epsilonTextValue.Text);
        }
        #endregion

        #region lab1,2
        private void drawGraphButton_Click(object sender, EventArgs e)
        {
            functionChart.Series[0] = new Series
            {
                ChartType = SeriesChartType.Line
            };
            var defaultChartAreas = functionChart.ChartAreas[0];
            defaultChartAreas.AxisX.Minimum = _numericalMethodImplementationLab1_2.ABound - _numericalMethodImplementationLab1_2.Epsilon;
            defaultChartAreas.AxisX.Maximum = _numericalMethodImplementationLab1_2.BBound + _numericalMethodImplementationLab1_2.Epsilon;
            defaultChartAreas.AxisY.Minimum = -Math.PI;
            defaultChartAreas.AxisY.Maximum = Math.PI;

            functionChart.Series[0].Color = Color.Chocolate;
            
            var seriesValues = _numericalMethodImplementationLab1_2.CalculateSeries();
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
            foreach (var root in _numericalMethodImplementationLab1_2.ApproximateRoots)
            {
                _numericalMethodImplementationLab1_2.ChordMethod(root - 0.3, root + 0.3);
            }

            
            for (var i = 0; i < _numericalMethodImplementationLab1_2.ApproximatedRoots.Count; i++)
            {
                var row = (DataGridViewRow)_gridDataView.table.Rows[0].Clone();
                Debug.Assert(row != null, nameof(row) + " != null");
                row.Cells[0].Value = _numericalMethodImplementationLab1_2.ApproximateRoots[i];
                row.Cells[1].Value = _numericalMethodImplementationLab1_2.ApproximatedRoots[i];
                var result = _numericalMethodImplementationLab1_2.Function(_numericalMethodImplementationLab1_2.ApproximatedRoots[i]);
                row.Cells[2].Value = String.Format("{0:F15}", result);;
                _gridDataView.table.Rows.Add(row);
            }
            
            _gridDataView.Show();
        }
        #endregion
        
        private void lab3drawGraph_Click(object sender, EventArgs e)
        {
            lab3Chart.Series.Clear();
            lab3Chart.Series.Add(new Series
            {
                ChartType = SeriesChartType.Line
            });
            lab3Chart.Series.Add(new Series
            {
                ChartType = SeriesChartType.Line
            });
            
            var defaultChartAreas = lab3Chart.ChartAreas[0];
            defaultChartAreas.AxisX.Minimum = _numericalMethodImplementationLab3.ABound1;
            defaultChartAreas.AxisX.Maximum = _numericalMethodImplementationLab3.BBound1;
            
            defaultChartAreas.AxisY.Minimum = _numericalMethodImplementationLab3.ABound2;
            defaultChartAreas.AxisY.Maximum = _numericalMethodImplementationLab3.BBound2;
            
            lab3Chart.Series[0].Color = Color.Chocolate;
            lab3Chart.Series[1].Color = Color.Indigo;
            
            var seriesValues1 = _numericalMethodImplementationLab3.CalculateSeries1();
            foreach (var point in seriesValues1)
            {
                lab3Chart.Series[0].Points.AddXY(point.Item1, point.Item2);   
            }
            
            var seriesValues2 = _numericalMethodImplementationLab3.CalculateSeries2();
            foreach (var point in seriesValues2)
            {
                lab3Chart.Series[1].Points.AddXY(point.Item1, point.Item2);   
            }

            findRootButtonLab3.Enabled = true;
        }

        private void aBound1_TextChanged(object sender, EventArgs e)
        {
            if(FillNumericTextBoxSuccessful(aBound1))
                _numericalMethodImplementationLab3.ABound1 = Tools.ParseDoubleWithPi(aBound1.Text);
        }
        
        private void bBound1_TextChanged(object sender, EventArgs e)
        {
            if(FillNumericTextBoxSuccessful(bBound1))
                _numericalMethodImplementationLab3.BBound1 = Tools.ParseDoubleWithPi(bBound1.Text);
        }

        private void aBound2_TextChanged(object sender, EventArgs e)
        {
            if(FillNumericTextBoxSuccessful(aBound2))
                _numericalMethodImplementationLab3.ABound2 = Tools.ParseDoubleWithPi(aBound2.Text);
        }

        private void bBound2_TextChanged(object sender, EventArgs e)
        {
            if(FillNumericTextBoxSuccessful(bBound2))
                _numericalMethodImplementationLab3.BBound2 = Tools.ParseDoubleWithPi(bBound2.Text);
        }

        private void lab3epsilon_TextChanged(object sender, EventArgs e)
        {
            if(FillNumericTextBoxSuccessful(lab3epsilon))
                _numericalMethodImplementationLab3.Epsilon = Tools.ParseDoubleWithPi(lab3epsilon.Text);
        }

        private void findRootButtonLab3_Click(object sender, EventArgs e)
        {
            findRootsButton.Enabled = false;
            _gridDataView = new GridDataView();
            _gridDataView.table.Columns[0].Width = 300;
            _gridDataView.table.Columns[1].Width = 300;
            _gridDataView.table.Columns[2].Width = 300;
            _gridDataView.table.Columns[2].HeaderText = "Норма вектора \n уточнённых решений";
            
            var result = _numericalMethodImplementationLab3.NewtonMethod();
            for (var i = 0; i < result.Count; i++)
            {
                var row = (DataGridViewRow)_gridDataView.table.Rows[0].Clone();
                Debug.Assert(row != null, nameof(row) + " != null");
                row.Cells[0].Value = $"({result[i].ApproximateCoordinates[0]:F15} , {result[i].ApproximateCoordinates[1]:F15})";;
                row.Cells[1].Value = $"({result[i].ApproximatedCoordinates[0]:F15} , {result[i].ApproximatedCoordinates[1]:F15})";;
                row.Cells[2].Value = $"{result[i].NormOfApproximatedCoordinatesVector:F15}";
                _gridDataView.table.Rows.Add(row);
            }
            
            _gridDataView.Show();
        }
    }
}