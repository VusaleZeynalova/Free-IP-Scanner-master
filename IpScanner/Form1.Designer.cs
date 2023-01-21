
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // lokallbl
            // 
            resources.ApplyResources(this.lokallbl, "lokallbl");
            this.lokallbl.ForeColor = System.Drawing.Color.Navy;
            this.lokallbl.Name = "lokallbl";
            // 
            // lokaltxt
            // 
            resources.ApplyResources(this.lokaltxt, "lokaltxt");
            this.lokaltxt.BackColor = System.Drawing.Color.White;
            this.lokaltxt.Name = "lokaltxt";
            this.lokaltxt.ReadOnly = true;
            // 
            // qlobaltxt
            // 
            resources.ApplyResources(this.qlobaltxt, "qlobaltxt");
            this.qlobaltxt.BackColor = System.Drawing.Color.White;
            this.qlobaltxt.Name = "qlobaltxt";
            this.qlobaltxt.ReadOnly = true;
            // 
            // pingbtn
            // 
            resources.ApplyResources(this.pingbtn, "pingbtn");
            this.pingbtn.BackColor = System.Drawing.Color.White;
            this.pingbtn.Name = "pingbtn";
            this.pingbtn.UseVisualStyleBackColor = false;
            this.pingbtn.Click += new System.EventHandler(this.pingbtn_Click);
            // 
            // PingIptxt
            // 
            resources.ApplyResources(this.PingIptxt, "PingIptxt");
            this.PingIptxt.BackColor = System.Drawing.Color.White;
            this.PingIptxt.Name = "PingIptxt";
            // 
            // pingoutputtxt
            // 
            resources.ApplyResources(this.pingoutputtxt, "pingoutputtxt");
            this.pingoutputtxt.BackColor = System.Drawing.Color.White;
            this.pingoutputtxt.Name = "pingoutputtxt";
            // 
            // iplbl
            // 
            resources.ApplyResources(this.iplbl, "iplbl");
            this.iplbl.Name = "iplbl";
            // 
            // firstIptxt
            // 
            resources.ApplyResources(this.firstIptxt, "firstIptxt");
            this.firstIptxt.BackColor = System.Drawing.Color.White;
            this.firstIptxt.Name = "firstIptxt";
            this.firstIptxt.ReadOnly = true;
            // 
            // searchbtn
            // 
            resources.ApplyResources(this.searchbtn, "searchbtn");
            this.searchbtn.BackColor = System.Drawing.Color.White;
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.UseVisualStyleBackColor = false;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // listView1
            // 
            resources.ApplyResources(this.listView1, "listView1");
            this.listView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.listView1.AllowColumnReorder = true;
            this.listView1.AllowDrop = true;
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.listView1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.HoverSelection = true;
            this.listView1.Name = "listView1";
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Name = "label1";
            // 
            // dataGrid1
            // 
            resources.ApplyResources(this.dataGrid1, "dataGrid1");
            this.dataGrid1.DataMember = "";
            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid1.Name = "dataGrid1";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Name = "label2";
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1")});
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.comboBox1);
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
            this.Name = "Form1";
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
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

