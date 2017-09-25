namespace GuessNumberGui
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
            this.txtGuess2 = new System.Windows.Forms.TextBox();
            this.btnGuess2 = new System.Windows.Forms.Button();
            this.lblFeedback2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtGuess2
            // 
            this.txtGuess2.Location = new System.Drawing.Point(23, 12);
            this.txtGuess2.Name = "txtGuess2";
            this.txtGuess2.Size = new System.Drawing.Size(803, 31);
            this.txtGuess2.TabIndex = 0;
            this.txtGuess2.TextChanged += new System.EventHandler(this.txtGuess2_TextChanged);
            // 
            // btnGuess2
            // 
            this.btnGuess2.Location = new System.Drawing.Point(23, 78);
            this.btnGuess2.Name = "btnGuess2";
            this.btnGuess2.Size = new System.Drawing.Size(803, 165);
            this.btnGuess2.TabIndex = 1;
            this.btnGuess2.Text = "Guess";
            this.btnGuess2.UseVisualStyleBackColor = true;
            this.btnGuess2.Click += new System.EventHandler(this.btnGuess2_Click_1);
            // 
            // lblFeedback2
            // 
            this.lblFeedback2.AutoSize = true;
            this.lblFeedback2.Location = new System.Drawing.Point(18, 270);
            this.lblFeedback2.Name = "lblFeedback2";
            this.lblFeedback2.Size = new System.Drawing.Size(0, 25);
            this.lblFeedback2.TabIndex = 2;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(947, 503);
            this.Controls.Add(this.lblFeedback2);
            this.Controls.Add(this.btnGuess2);
            this.Controls.Add(this.txtGuess2);
            this.Name = "Form1";
            this.Text = "Guess a Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.TextBox txtGuess2;
        private System.Windows.Forms.Button btnGuess2;
        private System.Windows.Forms.Label lblFeedback2;
    }
}

