namespace Ksu.Cis300.KnapsackSolver
{
    partial class UserInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInterface));
            this.uxButtonBar = new System.Windows.Forms.ToolStrip();
            this.uxOpen = new System.Windows.Forms.ToolStripButton();
            this.uxSave = new System.Windows.Forms.ToolStripButton();
            this.uxFileName = new System.Windows.Forms.TextBox();
            this.uxLimit = new System.Windows.Forms.TextBox();
            this.uxSolutionContainer = new System.Windows.Forms.Panel();
            this.uxSolution = new System.Windows.Forms.DataGridView();
            this.uxId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uxValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uxWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uxDensity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uxSelected = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uxLimitLabel = new System.Windows.Forms.Label();
            this.uxTotalWeight = new System.Windows.Forms.TextBox();
            this.uxTotalValue = new System.Windows.Forms.TextBox();
            this.uxValueLabel = new System.Windows.Forms.Label();
            this.uxWeightLabel = new System.Windows.Forms.Label();
            this.uxOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.uxSaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.uxButtonBar.SuspendLayout();
            this.uxSolutionContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxSolution)).BeginInit();
            this.SuspendLayout();
            // 
            // uxButtonBar
            // 
            this.uxButtonBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxOpen,
            this.uxSave});
            this.uxButtonBar.Location = new System.Drawing.Point(0, 0);
            this.uxButtonBar.Name = "uxButtonBar";
            this.uxButtonBar.Size = new System.Drawing.Size(526, 25);
            this.uxButtonBar.TabIndex = 0;
            // 
            // uxOpen
            // 
            this.uxOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.uxOpen.Image = ((System.Drawing.Image)(resources.GetObject("uxOpen.Image")));
            this.uxOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uxOpen.Name = "uxOpen";
            this.uxOpen.Size = new System.Drawing.Size(61, 22);
            this.uxOpen.Text = "Open File";
            this.uxOpen.Click += new System.EventHandler(this.uxOpen_Click);
            // 
            // uxSave
            // 
            this.uxSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.uxSave.Enabled = false;
            this.uxSave.Image = ((System.Drawing.Image)(resources.GetObject("uxSave.Image")));
            this.uxSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uxSave.Name = "uxSave";
            this.uxSave.Size = new System.Drawing.Size(82, 22);
            this.uxSave.Text = "Save Solution";
            this.uxSave.Click += new System.EventHandler(this.uxSave_Click);
            // 
            // uxFileName
            // 
            this.uxFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.uxFileName.Location = new System.Drawing.Point(13, 29);
            this.uxFileName.Name = "uxFileName";
            this.uxFileName.ReadOnly = true;
            this.uxFileName.Size = new System.Drawing.Size(501, 29);
            this.uxFileName.TabIndex = 1;
            // 
            // uxLimit
            // 
            this.uxLimit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.uxLimit.Location = new System.Drawing.Point(131, 64);
            this.uxLimit.Name = "uxLimit";
            this.uxLimit.ReadOnly = true;
            this.uxLimit.Size = new System.Drawing.Size(383, 29);
            this.uxLimit.TabIndex = 2;
            // 
            // uxSolutionContainer
            // 
            this.uxSolutionContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxSolutionContainer.Controls.Add(this.uxSolution);
            this.uxSolutionContainer.Location = new System.Drawing.Point(13, 100);
            this.uxSolutionContainer.Name = "uxSolutionContainer";
            this.uxSolutionContainer.Size = new System.Drawing.Size(501, 346);
            this.uxSolutionContainer.TabIndex = 3;
            // 
            // uxSolution
            // 
            this.uxSolution.AllowUserToAddRows = false;
            this.uxSolution.AllowUserToDeleteRows = false;
            this.uxSolution.AllowUserToResizeRows = false;
            this.uxSolution.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.uxSolution.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxSolution.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uxId,
            this.uxValue,
            this.uxWeight,
            this.uxDensity,
            this.uxSelected});
            this.uxSolution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxSolution.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.uxSolution.Location = new System.Drawing.Point(0, 0);
            this.uxSolution.Name = "uxSolution";
            this.uxSolution.ReadOnly = true;
            this.uxSolution.RowHeadersVisible = false;
            this.uxSolution.Size = new System.Drawing.Size(501, 346);
            this.uxSolution.TabIndex = 0;
            // 
            // uxId
            // 
            this.uxId.HeaderText = "ID";
            this.uxId.Name = "uxId";
            this.uxId.ReadOnly = true;
            // 
            // uxValue
            // 
            this.uxValue.HeaderText = "Value";
            this.uxValue.Name = "uxValue";
            this.uxValue.ReadOnly = true;
            // 
            // uxWeight
            // 
            this.uxWeight.HeaderText = "Weight";
            this.uxWeight.Name = "uxWeight";
            this.uxWeight.ReadOnly = true;
            // 
            // uxDensity
            // 
            this.uxDensity.HeaderText = "Density";
            this.uxDensity.Name = "uxDensity";
            this.uxDensity.ReadOnly = true;
            // 
            // uxSelected
            // 
            this.uxSelected.HeaderText = "Selected";
            this.uxSelected.Name = "uxSelected";
            this.uxSelected.ReadOnly = true;
            // 
            // uxLimitLabel
            // 
            this.uxLimitLabel.AutoSize = true;
            this.uxLimitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.uxLimitLabel.Location = new System.Drawing.Point(13, 65);
            this.uxLimitLabel.Name = "uxLimitLabel";
            this.uxLimitLabel.Size = new System.Drawing.Size(117, 24);
            this.uxLimitLabel.TabIndex = 4;
            this.uxLimitLabel.Text = "Weight Limit:";
            // 
            // uxTotalWeight
            // 
            this.uxTotalWeight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxTotalWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.uxTotalWeight.Location = new System.Drawing.Point(131, 487);
            this.uxTotalWeight.Name = "uxTotalWeight";
            this.uxTotalWeight.ReadOnly = true;
            this.uxTotalWeight.Size = new System.Drawing.Size(383, 29);
            this.uxTotalWeight.TabIndex = 5;
            // 
            // uxTotalValue
            // 
            this.uxTotalValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxTotalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.uxTotalValue.Location = new System.Drawing.Point(131, 452);
            this.uxTotalValue.Name = "uxTotalValue";
            this.uxTotalValue.ReadOnly = true;
            this.uxTotalValue.Size = new System.Drawing.Size(383, 29);
            this.uxTotalValue.TabIndex = 6;
            // 
            // uxValueLabel
            // 
            this.uxValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.uxValueLabel.AutoSize = true;
            this.uxValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.uxValueLabel.Location = new System.Drawing.Point(9, 452);
            this.uxValueLabel.Name = "uxValueLabel";
            this.uxValueLabel.Size = new System.Drawing.Size(110, 24);
            this.uxValueLabel.TabIndex = 7;
            this.uxValueLabel.Text = "Total Value:";
            // 
            // uxWeightLabel
            // 
            this.uxWeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.uxWeightLabel.AutoSize = true;
            this.uxWeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.uxWeightLabel.Location = new System.Drawing.Point(9, 490);
            this.uxWeightLabel.Name = "uxWeightLabel";
            this.uxWeightLabel.Size = new System.Drawing.Size(120, 24);
            this.uxWeightLabel.TabIndex = 8;
            this.uxWeightLabel.Text = "Total Weight:";
            // 
            // uxOpenDialog
            // 
            this.uxOpenDialog.Filter = "Comma-separated-value files|*.csv|All files|*.*";
            // 
            // uxSaveDialog
            // 
            this.uxSaveDialog.Filter = "Comma-separated-value files|*.csv|All files|*.*";
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 519);
            this.Controls.Add(this.uxWeightLabel);
            this.Controls.Add(this.uxValueLabel);
            this.Controls.Add(this.uxTotalValue);
            this.Controls.Add(this.uxTotalWeight);
            this.Controls.Add(this.uxLimitLabel);
            this.Controls.Add(this.uxSolutionContainer);
            this.Controls.Add(this.uxLimit);
            this.Controls.Add(this.uxFileName);
            this.Controls.Add(this.uxButtonBar);
            this.MinimumSize = new System.Drawing.Size(315, 340);
            this.Name = "UserInterface";
            this.Text = "Knapsack Solver";
            this.uxButtonBar.ResumeLayout(false);
            this.uxButtonBar.PerformLayout();
            this.uxSolutionContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uxSolution)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip uxButtonBar;
        private System.Windows.Forms.ToolStripButton uxOpen;
        private System.Windows.Forms.ToolStripButton uxSave;
        private System.Windows.Forms.TextBox uxFileName;
        private System.Windows.Forms.TextBox uxLimit;
        private System.Windows.Forms.Panel uxSolutionContainer;
        private System.Windows.Forms.DataGridView uxSolution;
        private System.Windows.Forms.Label uxLimitLabel;
        private System.Windows.Forms.TextBox uxTotalWeight;
        private System.Windows.Forms.TextBox uxTotalValue;
        private System.Windows.Forms.Label uxValueLabel;
        private System.Windows.Forms.Label uxWeightLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn uxId;
        private System.Windows.Forms.DataGridViewTextBoxColumn uxValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn uxWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn uxDensity;
        private System.Windows.Forms.DataGridViewTextBoxColumn uxSelected;
        private System.Windows.Forms.OpenFileDialog uxOpenDialog;
        private System.Windows.Forms.SaveFileDialog uxSaveDialog;
    }
}

