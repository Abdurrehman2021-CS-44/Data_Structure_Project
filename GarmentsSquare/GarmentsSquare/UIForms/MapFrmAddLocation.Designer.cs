namespace GarmentsSquare.UIForms
{
    partial class MapFrmAddLocation
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gMapAPI = new GMap.NET.WindowsForms.GMapControl();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSearchArea = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLng = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.btnSearchPoint = new System.Windows.Forms.Button();
            this.rtxtArea = new System.Windows.Forms.RichTextBox();
            this.checkBoxMouse = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.375F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.625F));
            this.tableLayoutPanel1.Controls.Add(this.gMapAPI, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gMapAPI
            // 
            this.gMapAPI.Bearing = 0F;
            this.gMapAPI.CanDragMap = true;
            this.gMapAPI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMapAPI.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapAPI.GrayScaleMode = false;
            this.gMapAPI.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapAPI.LevelsKeepInMemory = 5;
            this.gMapAPI.Location = new System.Drawing.Point(3, 3);
            this.gMapAPI.MarkersEnabled = true;
            this.gMapAPI.MaxZoom = 2;
            this.gMapAPI.MinZoom = 2;
            this.gMapAPI.MouseWheelZoomEnabled = true;
            this.gMapAPI.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapAPI.Name = "gMapAPI";
            this.gMapAPI.NegativeMode = false;
            this.gMapAPI.PolygonsEnabled = true;
            this.gMapAPI.RetryLoadTile = 0;
            this.gMapAPI.RoutesEnabled = true;
            this.gMapAPI.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapAPI.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapAPI.ShowTileGridLines = false;
            this.gMapAPI.Size = new System.Drawing.Size(597, 444);
            this.gMapAPI.TabIndex = 1;
            this.gMapAPI.Zoom = 0D;
            this.gMapAPI.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gMapAPI_MouseClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnSearchArea, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtLng, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtLat, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnSearchPoint, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.rtxtArea, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.checkBoxMouse, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.btnAdd, 0, 10);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.txtDistance, 0, 9);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(606, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 11;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.432433F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.684685F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.756757F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.684685F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.234234F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.42342F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.684685F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.38739F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(191, 444);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // btnSearchArea
            // 
            this.btnSearchArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearchArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchArea.Location = new System.Drawing.Point(3, 238);
            this.btnSearchArea.Name = "btnSearchArea";
            this.btnSearchArea.Size = new System.Drawing.Size(185, 28);
            this.btnSearchArea.TabIndex = 6;
            this.btnSearchArea.Text = "Search";
            this.btnSearchArea.UseVisualStyleBackColor = true;
            this.btnSearchArea.Click += new System.EventHandler(this.btnSearchArea_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Latitude";
            // 
            // txtLng
            // 
            this.txtLng.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLng.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLng.Location = new System.Drawing.Point(3, 87);
            this.txtLng.Name = "txtLng";
            this.txtLng.Size = new System.Drawing.Size(185, 26);
            this.txtLng.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Longitude";
            // 
            // txtLat
            // 
            this.txtLat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLat.Location = new System.Drawing.Point(3, 29);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(185, 26);
            this.txtLat.TabIndex = 2;
            // 
            // btnSearchPoint
            // 
            this.btnSearchPoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearchPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchPoint.Location = new System.Drawing.Point(3, 121);
            this.btnSearchPoint.Name = "btnSearchPoint";
            this.btnSearchPoint.Size = new System.Drawing.Size(185, 27);
            this.btnSearchPoint.TabIndex = 4;
            this.btnSearchPoint.Text = "Seach";
            this.btnSearchPoint.UseVisualStyleBackColor = true;
            this.btnSearchPoint.Click += new System.EventHandler(this.btnSearchPoint_Click);
            // 
            // rtxtArea
            // 
            this.rtxtArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtArea.Location = new System.Drawing.Point(3, 154);
            this.rtxtArea.Name = "rtxtArea";
            this.rtxtArea.Size = new System.Drawing.Size(185, 78);
            this.rtxtArea.TabIndex = 5;
            this.rtxtArea.Text = "";
            // 
            // checkBoxMouse
            // 
            this.checkBoxMouse.AutoSize = true;
            this.checkBoxMouse.Location = new System.Drawing.Point(3, 272);
            this.checkBoxMouse.Name = "checkBoxMouse";
            this.checkBoxMouse.Size = new System.Drawing.Size(127, 17);
            this.checkBoxMouse.TabIndex = 8;
            this.checkBoxMouse.Text = "Enable Mouse Select";
            this.checkBoxMouse.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(3, 410);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(185, 31);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 39);
            this.label3.TabIndex = 9;
            this.label3.Text = "Distance";
            // 
            // txtDistance
            // 
            this.txtDistance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistance.Location = new System.Drawing.Point(3, 355);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.ReadOnly = true;
            this.txtDistance.Size = new System.Drawing.Size(185, 26);
            this.txtDistance.TabIndex = 10;
            // 
            // MapFrmAddLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MapFrmAddLocation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MapFrm";
            this.Load += new System.EventHandler(this.MapFrm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private GMap.NET.WindowsForms.GMapControl gMapAPI;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearchArea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLng;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLat;
        private System.Windows.Forms.Button btnSearchPoint;
        private System.Windows.Forms.RichTextBox rtxtArea;
        private System.Windows.Forms.CheckBox checkBoxMouse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDistance;
    }
}