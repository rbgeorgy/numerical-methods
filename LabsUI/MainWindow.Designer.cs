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
            this.tabControl1.SuspendLayout();
            this.Lab_1_2_Page.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.functionChart)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Lab_1_2_Page);
            this.tabControl1.Controls.Add(this.Lab_3_Page);
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
            this.Lab_3_Page.Location = new System.Drawing.Point(4, 25);
            this.Lab_3_Page.Name = "Lab_3_Page";
            this.Lab_3_Page.Size = new System.Drawing.Size(1144, 619);
            this.Lab_3_Page.TabIndex = 0;
            this.Lab_3_Page.Text = "Lab 3 page";
            this.Lab_3_Page.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TabPage Lab_1_2_Page;
        private System.Windows.Forms.TabPage Lab_3_Page;

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
    }
}