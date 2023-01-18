
using System;

namespace IpScanner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lokallbl = new System.Windows.Forms.Label();
            this.lokaltxt = new System.Windows.Forms.TextBox();
            this.qlobaltxt = new System.Windows.Forms.TextBox();
            this.pingbtn = new System.Windows.Forms.Button();
            this.PingIptxt = new System.Windows.Forms.TextBox();
            this.pingoutputtxt = new System.Windows.Forms.TextBox();
            this.iplbl = new System.Windows.Forms.Label();
            this.firstIptxt = new System.Windows.Forms.TextBox();
            this.searchbtn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // lokallbl
            // 
            this.lokallbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lokallbl.AutoSize = true;
            this.lokallbl.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lokallbl.ForeColor = System.Drawing.Color.Navy;
            this.lokallbl.Location = new System.Drawing.Point(507, 10);
            this.lokallbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lokallbl.Name = "lokallbl";
            this.lokallbl.Size = new System.Drawing.Size(77, 19);
            this.lokallbl.TabIndex = 0;
            this.lokallbl.Text = "Lokal İP:";
            // 
            // lokaltxt
            // 
            this.lokaltxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lokaltxt.BackColor = System.Drawing.Color.White;
            this.lokaltxt.Location = new System.Drawing.Point(600, 6);
            this.lokaltxt.Margin = new System.Windows.Forms.Padding(4);
            this.lokaltxt.Name = "lokaltxt";
            this.lokaltxt.ReadOnly = true;
            this.lokaltxt.Size = new System.Drawing.Size(132, 22);
            this.lokaltxt.TabIndex = 2;
            // 
            // qlobaltxt
            // 
            this.qlobaltxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.qlobaltxt.BackColor = System.Drawing.Color.White;
            this.qlobaltxt.Location = new System.Drawing.Point(600, 50);
            this.qlobaltxt.Margin = new System.Windows.Forms.Padding(4);
            this.qlobaltxt.Name = "qlobaltxt";
            this.qlobaltxt.ReadOnly = true;
            this.qlobaltxt.Size = new System.Drawing.Size(132, 22);
            this.qlobaltxt.TabIndex = 3;
            // 
            // pingbtn
            // 
            this.pingbtn.BackColor = System.Drawing.Color.White;
            this.pingbtn.Location = new System.Drawing.Point(217, 10);
            this.pingbtn.Margin = new System.Windows.Forms.Padding(4);
            this.pingbtn.Name = "pingbtn";
            this.pingbtn.Size = new System.Drawing.Size(68, 28);
            this.pingbtn.TabIndex = 4;
            this.pingbtn.Text = "Ping";
            this.pingbtn.UseVisualStyleBackColor = false;
            this.pingbtn.Click += new System.EventHandler(this.pingbtn_Click);
            // 
            // PingIptxt
            // 
            this.PingIptxt.BackColor = System.Drawing.Color.White;
            this.PingIptxt.Location = new System.Drawing.Point(293, 13);
            this.PingIptxt.Margin = new System.Windows.Forms.Padding(4);
            this.PingIptxt.Name = "PingIptxt";
            this.PingIptxt.Size = new System.Drawing.Size(132, 22);
            this.PingIptxt.TabIndex = 5;
            // 
            // pingoutputtxt
            // 
            this.pingoutputtxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pingoutputtxt.BackColor = System.Drawing.Color.White;
            this.pingoutputtxt.Location = new System.Drawing.Point(217, 46);
            this.pingoutputtxt.Margin = new System.Windows.Forms.Padding(4);
            this.pingoutputtxt.Multiline = true;
            this.pingoutputtxt.Name = "pingoutputtxt";
            this.pingoutputtxt.Size = new System.Drawing.Size(223, 122);
            this.pingoutputtxt.TabIndex = 9;
            // 
            // iplbl
            // 
            this.iplbl.Location = new System.Drawing.Point(0, 0);
            this.iplbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.iplbl.Name = "iplbl";
            this.iplbl.Size = new System.Drawing.Size(133, 28);
            this.iplbl.TabIndex = 15;
            // 
            // firstIptxt
            // 
            this.firstIptxt.BackColor = System.Drawing.Color.White;
            this.firstIptxt.Location = new System.Drawing.Point(217, 184);
            this.firstIptxt.Margin = new System.Windows.Forms.Padding(4);
            this.firstIptxt.Name = "firstIptxt";
            this.firstIptxt.ReadOnly = true;
            this.firstIptxt.Size = new System.Drawing.Size(289, 22);
            this.firstIptxt.TabIndex = 11;
            this.firstIptxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // searchbtn
            // 
            this.searchbtn.AutoSize = true;
            this.searchbtn.BackColor = System.Drawing.Color.White;
            this.searchbtn.Location = new System.Drawing.Point(514, 181);
            this.searchbtn.Margin = new System.Windows.Forms.Padding(4);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(78, 28);
            this.searchbtn.TabIndex = 13;
            this.searchbtn.Text = "Axtar";
            this.searchbtn.UseVisualStyleBackColor = false;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // listView1
            // 
            this.listView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.listView1.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listView1.AllowColumnReorder = true;
            this.listView1.AllowDrop = true;
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.HoverSelection = true;
            this.listView1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.listView1.Location = new System.Drawing.Point(87, 214);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listView1.Size = new System.Drawing.Size(658, 206);
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "İP ünvan";
            this.columnHeader1.Width = 179;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "HostName";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 479;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(109, 184);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "İP aralığı";
            // 
            // dataGrid1
            // 
            this.dataGrid1.DataMember = "";
            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid1.Location = new System.Drawing.Point(111, 31);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(130, 80);
            this.dataGrid1.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(600, 181);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 28);
            this.button1.TabIndex = 18;
            this.button1.Text = "Çap";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 9);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(140, 123);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(499, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Qlobal İP:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(4, 131);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 30);
            this.button2.TabIndex = 21;
            this.button2.Text = "Haqqımızda";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(782, 423);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.firstIptxt);
            this.Controls.Add(this.iplbl);
            this.Controls.Add(this.pingoutputtxt);
            this.Controls.Add(this.PingIptxt);
            this.Controls.Add(this.pingbtn);
            this.Controls.Add(this.qlobaltxt);
            this.Controls.Add(this.lokaltxt);
            this.Controls.Add(this.lokallbl);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(800, 470);
            this.Name = "Form1";
            this.Text = "Free IP Scanner";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion
        private System.Windows.Forms.Label lokallbl;
        private System.Windows.Forms.TextBox lokaltxt;
        private System.Windows.Forms.TextBox qlobaltxt;
        private System.Windows.Forms.Button pingbtn;
        private System.Windows.Forms.TextBox PingIptxt;
        private System.Windows.Forms.TextBox pingoutputtxt;
        private System.Windows.Forms.Label iplbl;
        private System.Windows.Forms.TextBox firstIptxt;
        private System.Windows.Forms.Button searchbtn;
        public System.Windows.Forms.ColumnHeader columnHeader1;
        public System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGrid dataGrid1;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}

