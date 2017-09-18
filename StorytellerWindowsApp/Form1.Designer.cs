namespace StorytellerWindowsApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbNameOfChild = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.cbScary = new System.Windows.Forms.CheckBox();
            this.tbStory = new System.Windows.Forms.TextBox();
            this.btnTellStory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name of Child";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbNameOfChild
            // 
            this.tbNameOfChild.Location = new System.Drawing.Point(66, 124);
            this.tbNameOfChild.Name = "tbNameOfChild";
            this.tbNameOfChild.Size = new System.Drawing.Size(392, 31);
            this.tbNameOfChild.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Age of Child";
            // 
            // numAge
            // 
            this.numAge.Location = new System.Drawing.Point(66, 270);
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(120, 31);
            this.numAge.TabIndex = 3;
            // 
            // cbScary
            // 
            this.cbScary.AutoSize = true;
            this.cbScary.Location = new System.Drawing.Point(66, 347);
            this.cbScary.Name = "cbScary";
            this.cbScary.Size = new System.Drawing.Size(199, 29);
            this.cbScary.TabIndex = 4;
            this.cbScary.Text = "Should be scary";
            this.cbScary.UseVisualStyleBackColor = true;
            // 
            // tbStory
            // 
            this.tbStory.Location = new System.Drawing.Point(66, 537);
            this.tbStory.Multiline = true;
            this.tbStory.Name = "tbStory";
            this.tbStory.Size = new System.Drawing.Size(1241, 278);
            this.tbStory.TabIndex = 5;
            // 
            // btnTellStory
            // 
            this.btnTellStory.Location = new System.Drawing.Point(66, 437);
            this.btnTellStory.Name = "btnTellStory";
            this.btnTellStory.Size = new System.Drawing.Size(142, 58);
            this.btnTellStory.TabIndex = 6;
            this.btnTellStory.Text = "Tell story!";
            this.btnTellStory.UseVisualStyleBackColor = true;
            this.btnTellStory.Click += new System.EventHandler(this.btnTellStory_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 827);
            this.Controls.Add(this.btnTellStory);
            this.Controls.Add(this.tbStory);
            this.Controls.Add(this.cbScary);
            this.Controls.Add(this.numAge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNameOfChild);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Storyteller App";
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNameOfChild;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.CheckBox cbScary;
        private System.Windows.Forms.TextBox tbStory;
        private System.Windows.Forms.Button btnTellStory;
    }
}

