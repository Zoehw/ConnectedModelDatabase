namespace ConnectedModelDatabase
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabFlightInfo = new System.Windows.Forms.TabPage();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbSelect = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbAirplane = new System.Windows.Forms.ComboBox();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.txtFlightNum = new System.Windows.Forms.TextBox();
            this.txtAirline = new System.Windows.Forms.TextBox();
            this.lblAirplaneType = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblFlightNum = new System.Windows.Forms.Label();
            this.lblAirline = new System.Windows.Forms.Label();
            this.tabUserInfo = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabFlightInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabFlightInfo);
            this.tabControl1.Controls.Add(this.tabUserInfo);
            this.tabControl1.Location = new System.Drawing.Point(5, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(831, 658);
            this.tabControl1.TabIndex = 0;
            // 
            // tabFlightInfo
            // 
            this.tabFlightInfo.Controls.Add(this.btnRefresh);
            this.tabFlightInfo.Controls.Add(this.dataGridView1);
            this.tabFlightInfo.Controls.Add(this.btnUpdate);
            this.tabFlightInfo.Controls.Add(this.btnDelete);
            this.tabFlightInfo.Controls.Add(this.cmbSelect);
            this.tabFlightInfo.Controls.Add(this.btnAdd);
            this.tabFlightInfo.Controls.Add(this.cmbAirplane);
            this.tabFlightInfo.Controls.Add(this.txtDestination);
            this.tabFlightInfo.Controls.Add(this.txtFlightNum);
            this.tabFlightInfo.Controls.Add(this.txtAirline);
            this.tabFlightInfo.Controls.Add(this.lblAirplaneType);
            this.tabFlightInfo.Controls.Add(this.lblDestination);
            this.tabFlightInfo.Controls.Add(this.lblFlightNum);
            this.tabFlightInfo.Controls.Add(this.lblAirline);
            this.tabFlightInfo.Location = new System.Drawing.Point(4, 29);
            this.tabFlightInfo.Name = "tabFlightInfo";
            this.tabFlightInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabFlightInfo.Size = new System.Drawing.Size(823, 625);
            this.tabFlightInfo.TabIndex = 0;
            this.tabFlightInfo.Text = "FlightInfo";
            this.tabFlightInfo.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(663, 564);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(114, 36);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 250);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(764, 308);
            this.dataGridView1.TabIndex = 12;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(663, 190);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(131, 34);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(491, 190);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(114, 34);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // cmbSelect
            // 
            this.cmbSelect.FormattingEnabled = true;
            this.cmbSelect.Location = new System.Drawing.Point(491, 112);
            this.cmbSelect.Name = "cmbSelect";
            this.cmbSelect.Size = new System.Drawing.Size(303, 28);
            this.cmbSelect.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(491, 39);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(303, 32);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbAirplane
            // 
            this.cmbAirplane.FormattingEnabled = true;
            this.cmbAirplane.Items.AddRange(new object[] {
            "Boing 345",
            "Boing 123",
            "Boing 396",
            "Boing 777",
            "Airbus 590"});
            this.cmbAirplane.Location = new System.Drawing.Point(186, 196);
            this.cmbAirplane.Name = "cmbAirplane";
            this.cmbAirplane.Size = new System.Drawing.Size(229, 28);
            this.cmbAirplane.TabIndex = 7;
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(186, 144);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(229, 26);
            this.txtDestination.TabIndex = 6;
            // 
            // txtFlightNum
            // 
            this.txtFlightNum.Location = new System.Drawing.Point(186, 92);
            this.txtFlightNum.Name = "txtFlightNum";
            this.txtFlightNum.Size = new System.Drawing.Size(229, 26);
            this.txtFlightNum.TabIndex = 5;
            // 
            // txtAirline
            // 
            this.txtAirline.Location = new System.Drawing.Point(186, 45);
            this.txtAirline.Name = "txtAirline";
            this.txtAirline.Size = new System.Drawing.Size(229, 26);
            this.txtAirline.TabIndex = 4;
            // 
            // lblAirplaneType
            // 
            this.lblAirplaneType.AutoSize = true;
            this.lblAirplaneType.Location = new System.Drawing.Point(42, 196);
            this.lblAirplaneType.Name = "lblAirplaneType";
            this.lblAirplaneType.Size = new System.Drawing.Size(105, 20);
            this.lblAirplaneType.TabIndex = 3;
            this.lblAirplaneType.Text = "Airplane Type";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(42, 144);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(90, 20);
            this.lblDestination.TabIndex = 2;
            this.lblDestination.Text = "Destination";
            // 
            // lblFlightNum
            // 
            this.lblFlightNum.AutoSize = true;
            this.lblFlightNum.Location = new System.Drawing.Point(42, 92);
            this.lblFlightNum.Name = "lblFlightNum";
            this.lblFlightNum.Size = new System.Drawing.Size(108, 20);
            this.lblFlightNum.TabIndex = 1;
            this.lblFlightNum.Text = "Flight Number";
            // 
            // lblAirline
            // 
            this.lblAirline.AutoSize = true;
            this.lblAirline.Location = new System.Drawing.Point(42, 45);
            this.lblAirline.Name = "lblAirline";
            this.lblAirline.Size = new System.Drawing.Size(52, 20);
            this.lblAirline.TabIndex = 0;
            this.lblAirline.Text = "Airline";
            // 
            // tabUserInfo
            // 
            this.tabUserInfo.Location = new System.Drawing.Point(4, 29);
            this.tabUserInfo.Name = "tabUserInfo";
            this.tabUserInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabUserInfo.Size = new System.Drawing.Size(823, 625);
            this.tabUserInfo.TabIndex = 1;
            this.tabUserInfo.Text = "UserInfo";
            this.tabUserInfo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 695);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabFlightInfo.ResumeLayout(false);
            this.tabFlightInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabFlightInfo;
        private System.Windows.Forms.TabPage tabUserInfo;
        private System.Windows.Forms.ComboBox cmbAirplane;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.TextBox txtFlightNum;
        private System.Windows.Forms.TextBox txtAirline;
        private System.Windows.Forms.Label lblAirplaneType;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label lblFlightNum;
        private System.Windows.Forms.Label lblAirline;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbSelect;
        private System.Windows.Forms.Button btnRefresh;
    }
}

