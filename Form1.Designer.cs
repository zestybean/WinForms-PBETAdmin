
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1286, 409);
            this.dataGridView1.TabIndex = 999;
            // 
            // dateTimeFrom
            // 
            this.dateTimeFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeFrom.Location = new System.Drawing.Point(70, 457);
            this.dateTimeFrom.Name = "dateTimeFrom";
            this.dateTimeFrom.Size = new System.Drawing.Size(200, 22);
            this.dateTimeFrom.TabIndex = 1;
            this.dateTimeFrom.Value = new System.DateTime(2021, 11, 22, 15, 46, 56, 0);
            this.dateTimeFrom.ValueChanged += new System.EventHandler(this.dateTimeFrom_ValueChanged);
            // 
            // dateTimeTo
            // 
            this.dateTimeTo.Location = new System.Drawing.Point(390, 457);
            this.dateTimeTo.Name = "dateTimeTo";
            this.dateTimeTo.Size = new System.Drawing.Size(200, 20);
            this.dateTimeTo.TabIndex = 1000;
            this.dateTimeTo.Value = new System.DateTime(2021, 11, 22, 15, 47, 3, 0);
            // 
            // dateTimeLbl1
            // 
            this.dateTimeLbl1.AutoSize = true;
            this.dateTimeLbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeLbl1.Location = new System.Drawing.Point(8, 457);
            this.dateTimeLbl1.Name = "dateTimeLbl1";
            this.dateTimeLbl1.Size = new System.Drawing.Size(54, 20);
            this.dateTimeLbl1.TabIndex = 1001;
            this.dateTimeLbl1.Text = "Start:";
            // 
            // dateTimeLbl2
            // 
            this.dateTimeLbl2.AutoSize = true;
            this.dateTimeLbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeLbl2.Location = new System.Drawing.Point(342, 457);
            this.dateTimeLbl2.Name = "dateTimeLbl2";
            this.dateTimeLbl2.Size = new System.Drawing.Size(46, 20);
            this.dateTimeLbl2.TabIndex = 1002;
            this.dateTimeLbl2.Text = "End:";
            // 
            // machineLbl
            // 
            this.machineLbl.AutoSize = true;
            this.machineLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machineLbl.Location = new System.Drawing.Point(8, 434);
            this.machineLbl.Name = "machineLbl";
            this.machineLbl.Size = new System.Drawing.Size(81, 20);
            this.machineLbl.TabIndex = 1003;
            this.machineLbl.Text = "Machine:";
            // 
            // machineTxtBox
            // 
            this.machineTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machineTxtBox.Location = new System.Drawing.Point(95, 429);
            this.machineTxtBox.Name = "machineTxtBox";
            this.machineTxtBox.Size = new System.Drawing.Size(100, 22);
            this.machineTxtBox.TabIndex = 1004;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 639);
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
    }
}

