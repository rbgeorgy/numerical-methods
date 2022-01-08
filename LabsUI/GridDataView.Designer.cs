
namespace LabsUI
{
    partial class GridDataView
    {
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
            this.table = new System.Windows.Forms.DataGridView();
            this.RefiningRoot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefinedRoot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FunctionFromRefinedRoot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RefiningRoot,
            this.RefinedRoot,
            this.FunctionFromRefinedRoot});
            this.table.Location = new System.Drawing.Point(0, 1);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(798, 448);
            this.table.TabIndex = 0;
            this.table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // RefiningRoot
            // 
            this.RefiningRoot.Frozen = true;
            this.RefiningRoot.HeaderText = "Уточняемый корень";
            this.RefiningRoot.Name = "RefiningRoot";
            // 
            // RefinedRoot
            // 
            this.RefinedRoot.Frozen = true;
            this.RefinedRoot.HeaderText = "Уточнённый корень";
            this.RefinedRoot.Name = "RefinedRoot";
            // 
            // FunctionFromRefinedRoot
            // 
            this.FunctionFromRefinedRoot.Frozen = true;
            this.FunctionFromRefinedRoot.HeaderText = "Функция от уточненного корня";
            this.FunctionFromRefinedRoot.Name = "FunctionFromRefinedRoot";
            // 
            // GridDataView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.table);
            this.Name = "GridDataView";
            this.Text = "GridDataView";
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView table;
        public System.Windows.Forms.DataGridViewTextBoxColumn RefiningRoot;
        public System.Windows.Forms.DataGridViewTextBoxColumn RefinedRoot;
        public System.Windows.Forms.DataGridViewTextBoxColumn FunctionFromRefinedRoot;
    }
}