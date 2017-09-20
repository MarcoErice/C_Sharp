namespace ExamWindowsApp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAssign = new System.Windows.Forms.Button();
            this.tB1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGrade = new System.Windows.Forms.Button();
            this.cB2 = new System.Windows.Forms.ComboBox();
            this.cB1 = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGenerateStatistics = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAssign);
            this.groupBox1.Controls.Add(this.tB1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1308, 143);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Information";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(951, 42);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(118, 47);
            this.btnAssign.TabIndex = 1;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // tB1
            // 
            this.tB1.Location = new System.Drawing.Point(12, 42);
            this.tB1.Name = "tB1";
            this.tB1.Size = new System.Drawing.Size(868, 31);
            this.tB1.TabIndex = 0;
            this.tB1.TextChanged += new System.EventHandler(this.tB1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGrade);
            this.groupBox2.Controls.Add(this.cB2);
            this.groupBox2.Controls.Add(this.cB1);
            this.groupBox2.Location = new System.Drawing.Point(3, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1308, 169);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grade";
            // 
            // btnGrade
            // 
            this.btnGrade.Location = new System.Drawing.Point(209, 86);
            this.btnGrade.Name = "btnGrade";
            this.btnGrade.Size = new System.Drawing.Size(99, 41);
            this.btnGrade.TabIndex = 2;
            this.btnGrade.Text = "Grade";
            this.btnGrade.UseVisualStyleBackColor = true;
            this.btnGrade.Click += new System.EventHandler(this.btnGrade_Click);
            // 
            // cB2
            // 
            this.cB2.FormattingEnabled = true;
            this.cB2.Items.AddRange(new object[] {
            "IG",
            "G",
            "VG"});
            this.cB2.Location = new System.Drawing.Point(3, 82);
            this.cB2.Name = "cB2";
            this.cB2.Size = new System.Drawing.Size(157, 33);
            this.cB2.TabIndex = 1;
            this.cB2.SelectedIndexChanged += new System.EventHandler(this.cB2_SelectedIndexChanged);
            // 
            // cB1
            // 
            this.cB1.FormattingEnabled = true;
            this.cB1.Location = new System.Drawing.Point(3, 27);
            this.cB1.Name = "cB1";
            this.cB1.Size = new System.Drawing.Size(1066, 33);
            this.cB1.TabIndex = 0;
            this.cB1.SelectedIndexChanged += new System.EventHandler(this.cB1_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnGenerateStatistics);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(3, 324);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1308, 380);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Statistics";
            // 
            // btnGenerateStatistics
            // 
            this.btnGenerateStatistics.Location = new System.Drawing.Point(1050, 262);
            this.btnGenerateStatistics.Name = "btnGenerateStatistics";
            this.btnGenerateStatistics.Size = new System.Drawing.Size(241, 112);
            this.btnGenerateStatistics.TabIndex = 3;
            this.btnGenerateStatistics.Text = "Generate statistics";
            this.btnGenerateStatistics.UseVisualStyleBackColor = true;
            this.btnGenerateStatistics.Click += new System.EventHandler(this.btnGenerateStatistics_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(435, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 51);
            this.label3.TabIndex = 2;
            this.label3.Text = "VG:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(435, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 51);
            this.label2.TabIndex = 1;
            this.label2.Text = "G:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(435, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "IG:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1512, 885);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Grade Students";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.TextBox tB1;
        private System.Windows.Forms.ComboBox cB1;
        private System.Windows.Forms.Button btnGrade;
        private System.Windows.Forms.ComboBox cB2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerateStatistics;
    }
}

