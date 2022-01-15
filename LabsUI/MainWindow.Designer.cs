namespace LabsUI
{
    partial class MainWindow
    {
        private const int _pageHeight = 576;
        private const int _pageWidth = 1024;
        private System.Windows.Forms.TabControl tabControl1;
        
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Lab_1_2_Page = new System.Windows.Forms.TabPage();
            this.findRootsButton = new System.Windows.Forms.Button();
            this.drawGraphButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.epsilonTextValue = new System.Windows.Forms.TextBox();
            this.bBoundTextValue = new System.Windows.Forms.TextBox();
            this.aBoundTextValue = new System.Windows.Forms.TextBox();
            this.UserImputLabel = new System.Windows.Forms.Label();
            this.functionChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Lab_3_Page = new System.Windows.Forms.TabPage();
            this.aBound2 = new System.Windows.Forms.TextBox();
            this.aBound1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.findRootButtonLab3 = new System.Windows.Forms.Button();
            this.lab3drawGraph = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.epsilonLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lab3epsilon = new System.Windows.Forms.TextBox();
            this.bBound2 = new System.Windows.Forms.TextBox();
            this.bBound1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lab3Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lab7Page = new System.Windows.Forms.TabPage();
            this.calcIntegralButton = new System.Windows.Forms.Button();
            this.drawGraphButtonLab7 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.hLab7 = new System.Windows.Forms.TextBox();
            this.bBoundLab7 = new System.Windows.Forms.TextBox();
            this.aBoundLab7 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.chartLab7 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1.SuspendLayout();
            this.Lab_1_2_Page.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.functionChart)).BeginInit();
            this.Lab_3_Page.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lab3Chart)).BeginInit();
            this.lab7Page.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartLab7)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Lab_1_2_Page);
            this.tabControl1.Controls.Add(this.Lab_3_Page);
            this.tabControl1.Controls.Add(this.lab7Page);
            this.tabControl1.Location = new System.Drawing.Point(8, 16);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1152, 648);
            this.tabControl1.TabIndex = 0;
            // 
            // Lab_1_2_Page
            // 
            this.Lab_1_2_Page.Controls.Add(this.findRootsButton);
            this.Lab_1_2_Page.Controls.Add(this.drawGraphButton);
            this.Lab_1_2_Page.Controls.Add(this.label4);
            this.Lab_1_2_Page.Controls.Add(this.label3);
            this.Lab_1_2_Page.Controls.Add(this.label2);
            this.Lab_1_2_Page.Controls.Add(this.label1);
            this.Lab_1_2_Page.Controls.Add(this.epsilonTextValue);
            this.Lab_1_2_Page.Controls.Add(this.bBoundTextValue);
            this.Lab_1_2_Page.Controls.Add(this.aBoundTextValue);
            this.Lab_1_2_Page.Controls.Add(this.UserImputLabel);
            this.Lab_1_2_Page.Controls.Add(this.functionChart);
            this.Lab_1_2_Page.Location = new System.Drawing.Point(4, 22);
            this.Lab_1_2_Page.Name = "Lab_1_2_Page";
            this.Lab_1_2_Page.Size = new System.Drawing.Size(1144, 622);
            this.Lab_1_2_Page.TabIndex = 0;
            this.Lab_1_2_Page.Text = "Labs 1,2 page";
            this.Lab_1_2_Page.UseVisualStyleBackColor = true;
            // 
            // findRootsButton
            // 
            this.findRootsButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.findRootsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.findRootsButton.Location = new System.Drawing.Point(53, 354);
            this.findRootsButton.Name = "findRootsButton";
            this.findRootsButton.Size = new System.Drawing.Size(159, 43);
            this.findRootsButton.TabIndex = 10;
            this.findRootsButton.Text = "Find Roots";
            this.findRootsButton.UseVisualStyleBackColor = true;
            this.findRootsButton.Click += new System.EventHandler(this.findRootsButton_Click);
            // 
            // drawGraphButton
            // 
            this.drawGraphButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.drawGraphButton.Location = new System.Drawing.Point(264, 354);
            this.drawGraphButton.Name = "drawGraphButton";
            this.drawGraphButton.Size = new System.Drawing.Size(159, 43);
            this.drawGraphButton.TabIndex = 9;
            this.drawGraphButton.Text = "Draw Graph";
            this.drawGraphButton.UseVisualStyleBackColor = true;
            this.drawGraphButton.Click += new System.EventHandler(this.drawGraphButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.Location = new System.Drawing.Point(48, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "(2-x)^x-sin(sin(x))";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(48, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "b:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(48, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "epsilon:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(48, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "a:";
            // 
            // epsilonTextValue
            // 
            this.epsilonTextValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.epsilonTextValue.Location = new System.Drawing.Point(141, 217);
            this.epsilonTextValue.Name = "epsilonTextValue";
            this.epsilonTextValue.Size = new System.Drawing.Size(100, 35);
            this.epsilonTextValue.TabIndex = 4;
            this.epsilonTextValue.TextChanged += new System.EventHandler(this.epsilonTextValue_TextChanged);
            // 
            // bBoundTextValue
            // 
            this.bBoundTextValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.bBoundTextValue.Location = new System.Drawing.Point(141, 176);
            this.bBoundTextValue.Name = "bBoundTextValue";
            this.bBoundTextValue.Size = new System.Drawing.Size(100, 35);
            this.bBoundTextValue.TabIndex = 3;
            this.bBoundTextValue.Text = "pi";
            this.bBoundTextValue.TextChanged += new System.EventHandler(this.bBoundTextValue_TextChanged);
            // 
            // aBoundTextValue
            // 
            this.aBoundTextValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.aBoundTextValue.Location = new System.Drawing.Point(141, 135);
            this.aBoundTextValue.Name = "aBoundTextValue";
            this.aBoundTextValue.Size = new System.Drawing.Size(100, 35);
            this.aBoundTextValue.TabIndex = 2;
            this.aBoundTextValue.Text = "-3pi";
            this.aBoundTextValue.TextChanged += new System.EventHandler(this.aBoundTextValue_TextChanged);
            // 
            // UserImputLabel
            // 
            this.UserImputLabel.AutoSize = true;
            this.UserImputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.UserImputLabel.Location = new System.Drawing.Point(46, 63);
            this.UserImputLabel.Name = "UserImputLabel";
            this.UserImputLabel.Size = new System.Drawing.Size(322, 39);
            this.UserImputLabel.TabIndex = 1;
            this.UserImputLabel.Text = "User imput params:";
            // 
            // functionChart
            // 
            chartArea1.Name = "ChartArea1";
            this.functionChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.functionChart.Legends.Add(legend1);
            this.functionChart.Location = new System.Drawing.Point(464, 27);
            this.functionChart.Name = "functionChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.functionChart.Series.Add(series1);
            this.functionChart.Size = new System.Drawing.Size(649, 546);
            this.functionChart.TabIndex = 0;
            this.functionChart.Text = "chart1";
            // 
            // Lab_3_Page
            // 
            this.Lab_3_Page.Controls.Add(this.aBound2);
            this.Lab_3_Page.Controls.Add(this.aBound1);
            this.Lab_3_Page.Controls.Add(this.label10);
            this.Lab_3_Page.Controls.Add(this.findRootButtonLab3);
            this.Lab_3_Page.Controls.Add(this.lab3drawGraph);
            this.Lab_3_Page.Controls.Add(this.label5);
            this.Lab_3_Page.Controls.Add(this.label6);
            this.Lab_3_Page.Controls.Add(this.epsilonLabel);
            this.Lab_3_Page.Controls.Add(this.label8);
            this.Lab_3_Page.Controls.Add(this.lab3epsilon);
            this.Lab_3_Page.Controls.Add(this.bBound2);
            this.Lab_3_Page.Controls.Add(this.bBound1);
            this.Lab_3_Page.Controls.Add(this.label9);
            this.Lab_3_Page.Controls.Add(this.lab3Chart);
            this.Lab_3_Page.Location = new System.Drawing.Point(4, 22);
            this.Lab_3_Page.Name = "Lab_3_Page";
            this.Lab_3_Page.Size = new System.Drawing.Size(1144, 622);
            this.Lab_3_Page.TabIndex = 0;
            this.Lab_3_Page.Text = "Lab 3 page";
            this.Lab_3_Page.UseVisualStyleBackColor = true;
            // 
            // aBound2
            // 
            this.aBound2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.aBound2.Location = new System.Drawing.Point(188, 187);
            this.aBound2.Name = "aBound2";
            this.aBound2.Size = new System.Drawing.Size(100, 35);
            this.aBound2.TabIndex = 24;
            this.aBound2.Text = "-3pi";
            this.aBound2.TextChanged += new System.EventHandler(this.aBound2_TextChanged);
            // 
            // aBound1
            // 
            this.aBound1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.aBound1.Location = new System.Drawing.Point(188, 146);
            this.aBound1.Name = "aBound1";
            this.aBound1.Size = new System.Drawing.Size(100, 35);
            this.aBound1.TabIndex = 23;
            this.aBound1.Text = "-3pi";
            this.aBound1.TextChanged += new System.EventHandler(this.aBound1_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label10.Location = new System.Drawing.Point(41, 321);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(225, 26);
            this.label10.TabIndex = 22;
            this.label10.Text = "2*x1+cos(cos(x2)) = 2";
            // 
            // findRootButtonLab3
            // 
            this.findRootButtonLab3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.findRootButtonLab3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.findRootButtonLab3.Location = new System.Drawing.Point(46, 365);
            this.findRootButtonLab3.Name = "findRootButtonLab3";
            this.findRootButtonLab3.Size = new System.Drawing.Size(159, 43);
            this.findRootButtonLab3.TabIndex = 21;
            this.findRootButtonLab3.Text = "Find Roots";
            this.findRootButtonLab3.UseVisualStyleBackColor = true;
            this.findRootButtonLab3.Click += new System.EventHandler(this.findRootButtonLab3_Click);
            // 
            // lab3drawGraph
            // 
            this.lab3drawGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lab3drawGraph.Location = new System.Drawing.Point(257, 365);
            this.lab3drawGraph.Name = "lab3drawGraph";
            this.lab3drawGraph.Size = new System.Drawing.Size(159, 43);
            this.lab3drawGraph.TabIndex = 20;
            this.lab3drawGraph.Text = "Draw Graph";
            this.lab3drawGraph.UseVisualStyleBackColor = true;
            this.lab3drawGraph.Click += new System.EventHandler(this.lab3drawGraph_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label5.Location = new System.Drawing.Point(41, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 26);
            this.label5.TabIndex = 19;
            this.label5.Text = "sin (sin(x1+1)) - x2 = 1.2";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label6.Location = new System.Drawing.Point(41, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 26);
            this.label6.TabIndex = 18;
            this.label6.Text = "X2 interval:";
            // 
            // epsilonLabel
            // 
            this.epsilonLabel.AutoSize = true;
            this.epsilonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.epsilonLabel.Location = new System.Drawing.Point(41, 228);
            this.epsilonLabel.Name = "epsilonLabel";
            this.epsilonLabel.Size = new System.Drawing.Size(87, 26);
            this.epsilonLabel.TabIndex = 17;
            this.epsilonLabel.Text = "epsilon:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label8.Location = new System.Drawing.Point(41, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 26);
            this.label8.TabIndex = 16;
            this.label8.Text = "X1 interval:";
            // 
            // lab3epsilon
            // 
            this.lab3epsilon.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lab3epsilon.Location = new System.Drawing.Point(134, 228);
            this.lab3epsilon.Name = "lab3epsilon";
            this.lab3epsilon.Size = new System.Drawing.Size(100, 35);
            this.lab3epsilon.TabIndex = 15;
            this.lab3epsilon.TextChanged += new System.EventHandler(this.lab3epsilon_TextChanged);
            // 
            // bBound2
            // 
            this.bBound2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.bBound2.Location = new System.Drawing.Point(316, 187);
            this.bBound2.Name = "bBound2";
            this.bBound2.Size = new System.Drawing.Size(100, 35);
            this.bBound2.TabIndex = 14;
            this.bBound2.Text = "3pi";
            this.bBound2.TextChanged += new System.EventHandler(this.bBound2_TextChanged);
            // 
            // bBound1
            // 
            this.bBound1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.bBound1.Location = new System.Drawing.Point(316, 146);
            this.bBound1.Name = "bBound1";
            this.bBound1.Size = new System.Drawing.Size(100, 35);
            this.bBound1.TabIndex = 13;
            this.bBound1.Text = "3pi";
            this.bBound1.TextChanged += new System.EventHandler(this.bBound1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.label9.Location = new System.Drawing.Point(39, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(322, 39);
            this.label9.TabIndex = 12;
            this.label9.Text = "User imput params:";
            // 
            // lab3Chart
            // 
            chartArea2.Name = "ChartArea1";
            this.lab3Chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.lab3Chart.Legends.Add(legend2);
            this.lab3Chart.Location = new System.Drawing.Point(457, 38);
            this.lab3Chart.Name = "lab3Chart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.lab3Chart.Series.Add(series2);
            this.lab3Chart.Size = new System.Drawing.Size(649, 546);
            this.lab3Chart.TabIndex = 11;
            this.lab3Chart.Text = "chart1";
            // 
            // lab7Page
            // 
            this.lab7Page.Controls.Add(this.calcIntegralButton);
            this.lab7Page.Controls.Add(this.drawGraphButtonLab7);
            this.lab7Page.Controls.Add(this.label7);
            this.lab7Page.Controls.Add(this.label11);
            this.lab7Page.Controls.Add(this.label12);
            this.lab7Page.Controls.Add(this.label13);
            this.lab7Page.Controls.Add(this.hLab7);
            this.lab7Page.Controls.Add(this.bBoundLab7);
            this.lab7Page.Controls.Add(this.aBoundLab7);
            this.lab7Page.Controls.Add(this.label14);
            this.lab7Page.Controls.Add(this.chartLab7);
            this.lab7Page.Location = new System.Drawing.Point(4, 22);
            this.lab7Page.Name = "lab7Page";
            this.lab7Page.Size = new System.Drawing.Size(1144, 622);
            this.lab7Page.TabIndex = 1;
            this.lab7Page.Text = "Lab 7 page";
            this.lab7Page.UseVisualStyleBackColor = true;
            // 
            // calcIntegralButton
            // 
            this.calcIntegralButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.calcIntegralButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.calcIntegralButton.Location = new System.Drawing.Point(46, 365);
            this.calcIntegralButton.Name = "calcIntegralButton";
            this.calcIntegralButton.Size = new System.Drawing.Size(159, 43);
            this.calcIntegralButton.TabIndex = 21;
            this.calcIntegralButton.Text = "Calc integral";
            this.calcIntegralButton.UseVisualStyleBackColor = true;
            this.calcIntegralButton.Click += new System.EventHandler(this.calcIntegralButton_Click);
            // 
            // drawGraphButtonLab7
            // 
            this.drawGraphButtonLab7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.drawGraphButtonLab7.Location = new System.Drawing.Point(257, 365);
            this.drawGraphButtonLab7.Name = "drawGraphButtonLab7";
            this.drawGraphButtonLab7.Size = new System.Drawing.Size(159, 43);
            this.drawGraphButtonLab7.TabIndex = 20;
            this.drawGraphButtonLab7.Text = "Draw Graph";
            this.drawGraphButtonLab7.UseVisualStyleBackColor = true;
            this.drawGraphButtonLab7.Click += new System.EventHandler(this.drawGraphButtonLab7_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label7.Location = new System.Drawing.Point(41, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 26);
            this.label7.TabIndex = 19;
            this.label7.Text = "F: e^x + 1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label11.Location = new System.Drawing.Point(41, 187);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 26);
            this.label11.TabIndex = 18;
            this.label11.Text = "b:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label12.Location = new System.Drawing.Point(41, 228);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 26);
            this.label12.TabIndex = 17;
            this.label12.Text = "h:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label13.Location = new System.Drawing.Point(41, 146);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 26);
            this.label13.TabIndex = 16;
            this.label13.Text = "a:";
            // 
            // hLab7
            // 
            this.hLab7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.hLab7.Location = new System.Drawing.Point(134, 228);
            this.hLab7.Name = "hLab7";
            this.hLab7.Size = new System.Drawing.Size(100, 35);
            this.hLab7.TabIndex = 15;
            this.hLab7.TextChanged += new System.EventHandler(this.hLab7_TextChanged);
            // 
            // bBoundLab7
            // 
            this.bBoundLab7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.bBoundLab7.Location = new System.Drawing.Point(134, 187);
            this.bBoundLab7.Name = "bBoundLab7";
            this.bBoundLab7.Size = new System.Drawing.Size(100, 35);
            this.bBoundLab7.TabIndex = 14;
            this.bBoundLab7.Text = "1";
            this.bBoundLab7.TextChanged += new System.EventHandler(this.bBoundLab7_TextChanged);
            // 
            // aBoundLab7
            // 
            this.aBoundLab7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.aBoundLab7.Location = new System.Drawing.Point(134, 146);
            this.aBoundLab7.Name = "aBoundLab7";
            this.aBoundLab7.Size = new System.Drawing.Size(100, 35);
            this.aBoundLab7.TabIndex = 13;
            this.aBoundLab7.Text = "0";
            this.aBoundLab7.TextChanged += new System.EventHandler(this.aBoundLab7_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.label14.Location = new System.Drawing.Point(39, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(322, 39);
            this.label14.TabIndex = 12;
            this.label14.Text = "User imput params:";
            // 
            // chartLab7
            // 
            chartArea3.Name = "ChartArea1";
            this.chartLab7.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartLab7.Legends.Add(legend3);
            this.chartLab7.Location = new System.Drawing.Point(457, 38);
            this.chartLab7.Name = "chartLab7";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartLab7.Series.Add(series3);
            this.chartLab7.Size = new System.Drawing.Size(649, 546);
            this.chartLab7.TabIndex = 11;
            this.chartLab7.Text = "chart1";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "MainWindow";
            this.Text = "LabsUI";
            this.tabControl1.ResumeLayout(false);
            this.Lab_1_2_Page.ResumeLayout(false);
            this.Lab_1_2_Page.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.functionChart)).EndInit();
            this.Lab_3_Page.ResumeLayout(false);
            this.Lab_3_Page.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lab3Chart)).EndInit();
            this.lab7Page.ResumeLayout(false);
            this.lab7Page.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartLab7)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TabPage Lab_1_2_Page;

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart functionChart;
        private System.Windows.Forms.TextBox aBoundTextValue;
        private System.Windows.Forms.Label UserImputLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox epsilonTextValue;
        private System.Windows.Forms.TextBox bBoundTextValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button drawGraphButton;
        private System.Windows.Forms.Button findRootsButton;
        private System.Windows.Forms.TabPage Lab_3_Page;
        private System.Windows.Forms.Button findRootButtonLab3;
        private System.Windows.Forms.Button lab3drawGraph;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox bBound2;
        private System.Windows.Forms.TextBox bBound1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataVisualization.Charting.Chart lab3Chart;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label epsilonLabel;
        private System.Windows.Forms.TextBox lab3epsilon;
        private System.Windows.Forms.TextBox aBound2;
        private System.Windows.Forms.TextBox aBound1;
        private System.Windows.Forms.TabPage lab7Page;
        private System.Windows.Forms.Button calcIntegralButton;
        private System.Windows.Forms.Button drawGraphButtonLab7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox hLab7;
        private System.Windows.Forms.TextBox bBoundLab7;
        private System.Windows.Forms.TextBox aBoundLab7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLab7;
    }
}