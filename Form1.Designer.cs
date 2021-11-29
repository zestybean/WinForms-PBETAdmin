
namespace PBET_Admin
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimeTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimeLbl1 = new System.Windows.Forms.Label();
            this.dateTimeLbl2 = new System.Windows.Forms.Label();
            this.machineLbl = new System.Windows.Forms.Label();
            this.machineTxtBox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.exportBtn = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1286, 409);
            this.dataGridView1.TabIndex = 999;
            // 
            // dateTimeFrom
            // 
            this.dateTimeFrom.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeFrom.Location = new System.Drawing.Point(76, 497);
            this.dateTimeFrom.Name = "dateTimeFrom";
            this.dateTimeFrom.Size = new System.Drawing.Size(222, 21);
            this.dateTimeFrom.TabIndex = 1;
            this.dateTimeFrom.Value = new System.DateTime(2021, 11, 22, 15, 46, 56, 0);
            // 
            // dateTimeTo
            // 
            this.dateTimeTo.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeTo.Location = new System.Drawing.Point(400, 497);
            this.dateTimeTo.Name = "dateTimeTo";
            this.dateTimeTo.Size = new System.Drawing.Size(222, 21);
            this.dateTimeTo.TabIndex = 1000;
            this.dateTimeTo.Value = new System.DateTime(2021, 11, 22, 15, 47, 3, 0);
            // 
            // dateTimeLbl1
            // 
            this.dateTimeLbl1.AutoSize = true;
            this.dateTimeLbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeLbl1.Location = new System.Drawing.Point(14, 497);
            this.dateTimeLbl1.Name = "dateTimeLbl1";
            this.dateTimeLbl1.Size = new System.Drawing.Size(54, 20);
            this.dateTimeLbl1.TabIndex = 1001;
            this.dateTimeLbl1.Text = "Start:";
            // 
            // dateTimeLbl2
            // 
            this.dateTimeLbl2.AutoSize = true;
            this.dateTimeLbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeLbl2.Location = new System.Drawing.Point(348, 497);
            this.dateTimeLbl2.Name = "dateTimeLbl2";
            this.dateTimeLbl2.Size = new System.Drawing.Size(46, 20);
            this.dateTimeLbl2.TabIndex = 1002;
            this.dateTimeLbl2.Text = "End:";
            // 
            // machineLbl
            // 
            this.machineLbl.AutoSize = true;
            this.machineLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machineLbl.Location = new System.Drawing.Point(12, 424);
            this.machineLbl.Name = "machineLbl";
            this.machineLbl.Size = new System.Drawing.Size(102, 20);
            this.machineLbl.TabIndex = 1003;
            this.machineLbl.Text = "Machine(s):";
            // 
            // machineTxtBox
            // 
            this.machineTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machineTxtBox.Location = new System.Drawing.Point(669, 442);
            this.machineTxtBox.Name = "machineTxtBox";
            this.machineTxtBox.Size = new System.Drawing.Size(100, 22);
            this.machineTxtBox.TabIndex = 1004;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(14, 588);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 1005;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // exportBtn
            // 
            this.exportBtn.Location = new System.Drawing.Point(14, 559);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(75, 23);
            this.exportBtn.TabIndex = 1006;
            this.exportBtn.Text = "Export";
            this.exportBtn.UseVisualStyleBackColor = true;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.ColumnWidth = 150;
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "MAINLINE\t",
            "SPOVEN 1",
            "SPOVEN 2",
            "SPOVEN 3",
            "HZ BUMPERS",
            "TEST MACHINE",
            "TEST MACHINE",
            "TEST MACHINE",
            "TEST MACHINE"});
            this.checkedListBox1.Location = new System.Drawing.Point(120, 424);
            this.checkedListBox1.MultiColumn = true;
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(502, 67);
            this.checkedListBox1.TabIndex = 1007;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 639);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.exportBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.machineTxtBox);
            this.Controls.Add(this.machineLbl);
            this.Controls.Add(this.dateTimeLbl2);
            this.Controls.Add(this.dateTimeLbl1);
            this.Controls.Add(this.dateTimeTo);
            this.Controls.Add(this.dateTimeFrom);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "PBET Admin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimeFrom;
        private System.Windows.Forms.DateTimePicker dateTimeTo;
        private System.Windows.Forms.Label dateTimeLbl1;
        private System.Windows.Forms.Label dateTimeLbl2;
        private System.Windows.Forms.Label machineLbl;
        private System.Windows.Forms.TextBox machineTxtBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button exportBtn;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}

