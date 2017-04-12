namespace XenAdmin.Wizards.NewSRWizard_Pages.Frontends
{
    partial class Local_SR
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Local_SR));
            this.dataGridView = new XenAdmin.Controls.DataGridViewEx.DataGridViewEx();
            this.colCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSerial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelCreate = new System.Windows.Forms.Label();
            this.buttonSelectAll2 = new System.Windows.Forms.Button();
            this.buttonClearAll2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCheck,
            this.colSize,
            this.colSerial});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView, 2);
            resources.ApplyResources(this.dataGridView, "dataGridView");
            this.dataGridView.MultiSelect = true;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // colCheck
            // 
            this.colCheck.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.colCheck, "colCheck");
            this.colCheck.Name = "colCheck";
            // 
            // colSize
            // 
            this.colSize.FillWeight = 165.9091F;
            resources.ApplyResources(this.colSize, "colSize");
            this.colSize.Name = "colSize";
            this.colSize.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colSerial
            // 
            this.colSerial.FillWeight = 34.09091F;
            resources.ApplyResources(this.colSerial, "colSerial");
            this.colSerial.Name = "colSerial";
            this.colSerial.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.labelCreate, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonSelectAll2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonClearAll2, 1, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // labelCreate
            // 
            resources.ApplyResources(this.labelCreate, "labelCreate");
            this.tableLayoutPanel1.SetColumnSpan(this.labelCreate, 2);
            this.labelCreate.Name = "labelCreate";
            // 
            // buttonSelectAll2
            // 
            resources.ApplyResources(this.buttonSelectAll2, "buttonSelectAll2");
            this.buttonSelectAll2.Name = "buttonSelectAll2";
            this.buttonSelectAll2.UseVisualStyleBackColor = true;
            this.buttonSelectAll2.Click += new System.EventHandler(this.buttonSelectAll_Click);
            // 
            // buttonClearAll2
            // 
            resources.ApplyResources(this.buttonClearAll2, "buttonClearAll2");
            this.buttonClearAll2.Name = "buttonClearAll2";
            this.buttonClearAll2.UseVisualStyleBackColor = true;
            this.buttonClearAll2.Click += new System.EventHandler(this.buttonClearAll_Click);
            // 
            // Local_SR
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Name = "Local_SR";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private XenAdmin.Controls.DataGridViewEx.DataGridViewEx dataGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonSelectAll2;
        private System.Windows.Forms.Button buttonClearAll2;
        private System.Windows.Forms.Label labelCreate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSerial;
    }
}
