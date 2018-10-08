namespace Model_sys_2
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
            this.start = new System.Windows.Forms.Button();
            this.randbox = new System.Windows.Forms.TextBox();
            this.tUSERS = new System.Windows.Forms.TextBox();
            this.tWAIT_max = new System.Windows.Forms.TextBox();
            this.tWAIT_min = new System.Windows.Forms.TextBox();
            this.tRECEIPT_min = new System.Windows.Forms.TextBox();
            this.tRECEIPT_max = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tt1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tt2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tt3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tt4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tt5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tt6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tt7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(417, 36);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 0;
            this.start.Text = "start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // randbox
            // 
            this.randbox.Location = new System.Drawing.Point(43, 9);
            this.randbox.Name = "randbox";
            this.randbox.Size = new System.Drawing.Size(79, 20);
            this.randbox.TabIndex = 1;
            this.randbox.Text = "97851";
            this.randbox.TextChanged += new System.EventHandler(this.randbox_TextChanged);
            // 
            // tUSERS
            // 
            this.tUSERS.Location = new System.Drawing.Point(289, 9);
            this.tUSERS.Name = "tUSERS";
            this.tUSERS.Size = new System.Drawing.Size(74, 20);
            this.tUSERS.TabIndex = 2;
            this.tUSERS.Text = "20";
            // 
            // tWAIT_max
            // 
            this.tWAIT_max.Location = new System.Drawing.Point(289, 69);
            this.tWAIT_max.Name = "tWAIT_max";
            this.tWAIT_max.Size = new System.Drawing.Size(74, 20);
            this.tWAIT_max.TabIndex = 3;
            this.tWAIT_max.Text = "24";
            // 
            // tWAIT_min
            // 
            this.tWAIT_min.Location = new System.Drawing.Point(204, 69);
            this.tWAIT_min.Name = "tWAIT_min";
            this.tWAIT_min.Size = new System.Drawing.Size(79, 20);
            this.tWAIT_min.TabIndex = 4;
            this.tWAIT_min.Text = "1";
            // 
            // tRECEIPT_min
            // 
            this.tRECEIPT_min.Location = new System.Drawing.Point(204, 38);
            this.tRECEIPT_min.Name = "tRECEIPT_min";
            this.tRECEIPT_min.Size = new System.Drawing.Size(79, 20);
            this.tRECEIPT_min.TabIndex = 5;
            this.tRECEIPT_min.Text = "1";
            // 
            // tRECEIPT_max
            // 
            this.tRECEIPT_max.Location = new System.Drawing.Point(289, 38);
            this.tRECEIPT_max.Name = "tRECEIPT_max";
            this.tRECEIPT_max.Size = new System.Drawing.Size(74, 20);
            this.tRECEIPT_max.TabIndex = 6;
            this.tRECEIPT_max.Text = "29";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Xo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(128, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Кількість користувачів";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Час поступлення заявок";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Час обслуговування";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.User,
            this.tt1,
            this.tt2,
            this.tt3,
            this.tt4,
            this.tt5,
            this.tt6,
            this.tt7});
            this.dataGridView1.Location = new System.Drawing.Point(15, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(348, 245);
            this.dataGridView1.TabIndex = 11;
            // 
            // User
            // 
            this.User.HeaderText = "user";
            this.User.Name = "User";
            this.User.ReadOnly = true;
            this.User.Width = 50;
            // 
            // tt1
            // 
            this.tt1.HeaderText = "t1";
            this.tt1.Name = "tt1";
            this.tt1.ReadOnly = true;
            this.tt1.Width = 40;
            // 
            // tt2
            // 
            this.tt2.HeaderText = "t2";
            this.tt2.Name = "tt2";
            this.tt2.ReadOnly = true;
            this.tt2.Width = 40;
            // 
            // tt3
            // 
            this.tt3.HeaderText = "t3";
            this.tt3.Name = "tt3";
            this.tt3.ReadOnly = true;
            this.tt3.Width = 40;
            // 
            // tt4
            // 
            this.tt4.HeaderText = "t4";
            this.tt4.Name = "tt4";
            this.tt4.ReadOnly = true;
            this.tt4.Width = 40;
            // 
            // tt5
            // 
            this.tt5.HeaderText = "t5";
            this.tt5.Name = "tt5";
            this.tt5.ReadOnly = true;
            this.tt5.Width = 40;
            // 
            // tt6
            // 
            this.tt6.HeaderText = "t6";
            this.tt6.Name = "tt6";
            this.tt6.ReadOnly = true;
            this.tt6.Width = 40;
            // 
            // tt7
            // 
            this.tt7.HeaderText = "t7";
            this.tt7.Name = "tt7";
            this.tt7.ReadOnly = true;
            this.tt7.Width = 40;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 357);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tRECEIPT_max);
            this.Controls.Add(this.tRECEIPT_min);
            this.Controls.Add(this.tWAIT_min);
            this.Controls.Add(this.tWAIT_max);
            this.Controls.Add(this.tUSERS);
            this.Controls.Add(this.randbox);
            this.Controls.Add(this.start);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = " Single-channel mass service system";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.TextBox randbox;
        private System.Windows.Forms.TextBox tUSERS;
        private System.Windows.Forms.TextBox tWAIT_max;
        private System.Windows.Forms.TextBox tWAIT_min;
        private System.Windows.Forms.TextBox tRECEIPT_min;
        private System.Windows.Forms.TextBox tRECEIPT_max;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn tt1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tt2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tt3;
        private System.Windows.Forms.DataGridViewTextBoxColumn tt4;
        private System.Windows.Forms.DataGridViewTextBoxColumn tt5;
        private System.Windows.Forms.DataGridViewTextBoxColumn tt6;
        private System.Windows.Forms.DataGridViewTextBoxColumn tt7;
    }
}

