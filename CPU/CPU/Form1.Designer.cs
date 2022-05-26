
namespace CPU
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
            this.Console = new System.Windows.Forms.TextBox();
            this.Quantum = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.KDQ = new System.Windows.Forms.RadioButton();
            this.DQ = new System.Windows.Forms.RadioButton();
            this.Thuattoan = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.roundRobinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priorityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sJFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fCFSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chọnThuậtToánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Quantum)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Console
            // 
            this.Console.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Console.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Console.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Console.ForeColor = System.Drawing.Color.Lime;
            this.Console.Location = new System.Drawing.Point(200, 327);
            this.Console.Margin = new System.Windows.Forms.Padding(4);
            this.Console.Multiline = true;
            this.Console.Name = "Console";
            this.Console.ReadOnly = true;
            this.Console.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Console.Size = new System.Drawing.Size(715, 145);
            this.Console.TabIndex = 36;
            this.Console.WordWrap = false;
            this.Console.TextChanged += new System.EventHandler(this.Console_TextChanged);
            // 
            // Quantum
            // 
            this.Quantum.Location = new System.Drawing.Point(76, 8);
            this.Quantum.Name = "Quantum";
            this.Quantum.Size = new System.Drawing.Size(76, 22);
            this.Quantum.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Quantum);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(75, 207);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 37);
            this.panel1.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "quantum";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(884, 250);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 37);
            this.button3.TabIndex = 34;
            this.button3.Text = "Run";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // remove
            // 
            this.remove.BackColor = System.Drawing.SystemColors.ControlDark;
            this.remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.remove.Location = new System.Drawing.Point(884, 90);
            this.remove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(99, 42);
            this.remove.TabIndex = 33;
            this.remove.Text = "Remove";
            this.remove.UseVisualStyleBackColor = false;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.addBtn.Location = new System.Drawing.Point(884, 147);
            this.addBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(99, 39);
            this.addBtn.TabIndex = 32;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // KDQ
            // 
            this.KDQ.AutoSize = true;
            this.KDQ.BackColor = System.Drawing.SystemColors.Menu;
            this.KDQ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.KDQ.Checked = true;
            this.KDQ.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.KDQ.Location = new System.Drawing.Point(87, 147);
            this.KDQ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.KDQ.Name = "KDQ";
            this.KDQ.Size = new System.Drawing.Size(140, 21);
            this.KDQ.TabIndex = 30;
            this.KDQ.TabStop = true;
            this.KDQ.Text = "Không độc quyền";
            this.KDQ.UseVisualStyleBackColor = false;
            // 
            // DQ
            // 
            this.DQ.AutoSize = true;
            this.DQ.BackColor = System.Drawing.SystemColors.Menu;
            this.DQ.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DQ.Location = new System.Drawing.Point(87, 172);
            this.DQ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DQ.Name = "DQ";
            this.DQ.Size = new System.Drawing.Size(97, 21);
            this.DQ.TabIndex = 29;
            this.DQ.TabStop = true;
            this.DQ.Text = "Độc quyền";
            this.DQ.UseVisualStyleBackColor = false;
            this.DQ.CheckedChanged += new System.EventHandler(this.DQ_CheckedChanged);
            // 
            // Thuattoan
            // 
            this.Thuattoan.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Thuattoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Thuattoan.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Thuattoan.Location = new System.Drawing.Point(87, 104);
            this.Thuattoan.Name = "Thuattoan";
            this.Thuattoan.Size = new System.Drawing.Size(129, 15);
            this.Thuattoan.TabIndex = 27;
            this.Thuattoan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(75, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 47);
            this.label2.TabIndex = 26;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Priority";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Burst_Time";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Arrival_Time";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID process";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // dgvdata
            // 
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvdata.Location = new System.Drawing.Point(245, 90);
            this.dgvdata.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.RowHeadersWidth = 51;
            this.dgvdata.RowTemplate.Height = 24;
            this.dgvdata.Size = new System.Drawing.Size(605, 197);
            this.dgvdata.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(332, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 39);
            this.label3.TabIndex = 28;
            this.label3.Text = "Định thời CPU";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 25;
            // 
            // roundRobinToolStripMenuItem
            // 
            this.roundRobinToolStripMenuItem.Name = "roundRobinToolStripMenuItem";
            this.roundRobinToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.roundRobinToolStripMenuItem.Text = "RoundRobin";
            this.roundRobinToolStripMenuItem.Click += new System.EventHandler(this.roundRobinToolStripMenuItem_Click);
            // 
            // priorityToolStripMenuItem
            // 
            this.priorityToolStripMenuItem.Name = "priorityToolStripMenuItem";
            this.priorityToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.priorityToolStripMenuItem.Text = "Priority";
            this.priorityToolStripMenuItem.Click += new System.EventHandler(this.priorityToolStripMenuItem_Click);
            // 
            // sJFToolStripMenuItem
            // 
            this.sJFToolStripMenuItem.Name = "sJFToolStripMenuItem";
            this.sJFToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sJFToolStripMenuItem.Text = "SJF";
            this.sJFToolStripMenuItem.Click += new System.EventHandler(this.sJFToolStripMenuItem_Click);
            // 
            // fCFSToolStripMenuItem
            // 
            this.fCFSToolStripMenuItem.Name = "fCFSToolStripMenuItem";
            this.fCFSToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.fCFSToolStripMenuItem.Text = "FCFS";
            this.fCFSToolStripMenuItem.Click += new System.EventHandler(this.fCFSToolStripMenuItem_Click);
            // 
            // chọnThuậtToánToolStripMenuItem
            // 
            this.chọnThuậtToánToolStripMenuItem.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.chọnThuậtToánToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fCFSToolStripMenuItem,
            this.sJFToolStripMenuItem,
            this.priorityToolStripMenuItem,
            this.roundRobinToolStripMenuItem});
            this.chọnThuậtToánToolStripMenuItem.Name = "chọnThuậtToánToolStripMenuItem";
            this.chọnThuậtToánToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.chọnThuậtToánToolStripMenuItem.Text = "Chọn Thuật Toán";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chọnThuậtToánToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1030, 28);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 37);
            this.button1.TabIndex = 37;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.NavajoWhite;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(682, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(301, 39);
            this.label5.TabIndex = 38;
            this.label5.Text = "2001215906-12DHTH12-Nguyễn Ngọc Lâm";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CPU.Properties.Resources._1959300;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1030, 475);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Console);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.KDQ);
            this.Controls.Add(this.DQ);
            this.Controls.Add(this.Thuattoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Định Thời CPU";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Quantum)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Console;
        private System.Windows.Forms.NumericUpDown Quantum;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.RadioButton KDQ;
        private System.Windows.Forms.RadioButton DQ;
        private System.Windows.Forms.Label Thuattoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem roundRobinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem priorityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sJFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fCFSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chọnThuậtToánToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
    }
}

