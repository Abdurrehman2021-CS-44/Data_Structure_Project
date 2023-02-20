
namespace GarmentsSquare.UserControls
{
    partial class ucGenerateReport
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridViewRiders = new System.Windows.Forms.DataGridView();
            this.Gen = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblGeneratePerformanceReport = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblEmployee = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.Generate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblRiders = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRiders)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(57)))), ((int)(((byte)(25)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.90966F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.318671F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.63813F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.318671F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.63818F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.176689F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(709, 438);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.22222F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.55555F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.22222F));
            this.tableLayoutPanel3.Controls.Add(this.panel5, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 277);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(703, 141);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dataGridViewRiders);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(74, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(553, 135);
            this.panel5.TabIndex = 0;
            // 
            // dataGridViewRiders
            // 
            this.dataGridViewRiders.AllowUserToAddRows = false;
            this.dataGridViewRiders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRiders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRiders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Gen});
            this.dataGridViewRiders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRiders.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewRiders.Name = "dataGridViewRiders";
            this.dataGridViewRiders.Size = new System.Drawing.Size(553, 135);
            this.dataGridViewRiders.TabIndex = 0;
            this.dataGridViewRiders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRiders_CellContentClick);
            // 
            // Gen
            // 
            this.Gen.HeaderText = "Generate";
            this.Gen.Name = "Gen";
            this.Gen.Text = "Generate";
            this.Gen.UseColumnTextForButtonValue = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblGeneratePerformanceReport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 41);
            this.panel1.TabIndex = 0;
            // 
            // lblGeneratePerformanceReport
            // 
            this.lblGeneratePerformanceReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(57)))), ((int)(((byte)(25)))));
            this.lblGeneratePerformanceReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblGeneratePerformanceReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGeneratePerformanceReport.Font = new System.Drawing.Font("Tahoma", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneratePerformanceReport.ForeColor = System.Drawing.Color.White;
            this.lblGeneratePerformanceReport.Location = new System.Drawing.Point(0, 0);
            this.lblGeneratePerformanceReport.Name = "lblGeneratePerformanceReport";
            this.lblGeneratePerformanceReport.ReadOnly = true;
            this.lblGeneratePerformanceReport.Size = new System.Drawing.Size(703, 36);
            this.lblGeneratePerformanceReport.TabIndex = 7;
            this.lblGeneratePerformanceReport.Text = "Generate Performance Report";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblEmployee);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(703, 34);
            this.panel2.TabIndex = 1;
            // 
            // lblEmployee
            // 
            this.lblEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(57)))), ((int)(((byte)(25)))));
            this.lblEmployee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEmployee.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployee.ForeColor = System.Drawing.Color.White;
            this.lblEmployee.Location = new System.Drawing.Point(0, 0);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.ReadOnly = true;
            this.lblEmployee.Size = new System.Drawing.Size(703, 26);
            this.lblEmployee.TabIndex = 8;
            this.lblEmployee.Text = "Employees:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.22222F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.55555F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.22222F));
            this.tableLayoutPanel2.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 90);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(703, 141);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridViewEmployees);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(74, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(553, 135);
            this.panel3.TabIndex = 0;
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.AllowUserToAddRows = false;
            this.dataGridViewEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Generate});
            this.dataGridViewEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEmployees.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.Size = new System.Drawing.Size(553, 135);
            this.dataGridViewEmployees.TabIndex = 0;
            this.dataGridViewEmployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmployees_CellContentClick);
            // 
            // Generate
            // 
            this.Generate.HeaderText = "Generate";
            this.Generate.Name = "Generate";
            this.Generate.Text = "Generate";
            this.Generate.UseColumnTextForButtonValue = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblRiders);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 237);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(703, 34);
            this.panel4.TabIndex = 3;
            // 
            // lblRiders
            // 
            this.lblRiders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(57)))), ((int)(((byte)(25)))));
            this.lblRiders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblRiders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRiders.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRiders.ForeColor = System.Drawing.Color.White;
            this.lblRiders.Location = new System.Drawing.Point(0, 0);
            this.lblRiders.Name = "lblRiders";
            this.lblRiders.ReadOnly = true;
            this.lblRiders.Size = new System.Drawing.Size(703, 26);
            this.lblRiders.TabIndex = 9;
            this.lblRiders.Text = "Riders:";
            // 
            // ucGenerateReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucGenerateReport";
            this.Size = new System.Drawing.Size(709, 438);
            this.Load += new System.EventHandler(this.ucGenerateReport_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRiders)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox lblGeneratePerformanceReport;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox lblEmployee;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox lblRiders;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridViewRiders;
        private System.Windows.Forms.DataGridViewButtonColumn Gen;
        private System.Windows.Forms.DataGridViewButtonColumn Generate;
    }
}
