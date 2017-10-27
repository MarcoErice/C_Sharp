namespace FakturaWinApp
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
            this.gbKund = new System.Windows.Forms.GroupBox();
            this.txtNamn = new System.Windows.Forms.TextBox();
            this.txtJuridiskId = new System.Windows.Forms.TextBox();
            this.btnSkapaPart = new System.Windows.Forms.Button();
            this.gbVäljProdukt = new System.Windows.Forms.GroupBox();
            this.cbVäljProdukt = new System.Windows.Forms.ComboBox();
            this.lbProdukt = new System.Windows.Forms.ListBox();
            this.cbAntal = new System.Windows.Forms.ComboBox();
            this.btnNyRad = new System.Windows.Forms.Button();
            this.btnLäggBeställning = new System.Windows.Forms.Button();
            this.gbKund.SuspendLayout();
            this.gbVäljProdukt.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbKund
            // 
            this.gbKund.Controls.Add(this.btnSkapaPart);
            this.gbKund.Controls.Add(this.txtJuridiskId);
            this.gbKund.Controls.Add(this.txtNamn);
            this.gbKund.Location = new System.Drawing.Point(87, 59);
            this.gbKund.Name = "gbKund";
            this.gbKund.Size = new System.Drawing.Size(557, 275);
            this.gbKund.TabIndex = 0;
            this.gbKund.TabStop = false;
            this.gbKund.Text = "Kund";
            // 
            // txtNamn
            // 
            this.txtNamn.Location = new System.Drawing.Point(6, 62);
            this.txtNamn.Name = "txtNamn";
            this.txtNamn.Size = new System.Drawing.Size(527, 31);
            this.txtNamn.TabIndex = 1;
            // 
            // txtJuridiskId
            // 
            this.txtJuridiskId.Location = new System.Drawing.Point(7, 116);
            this.txtJuridiskId.Name = "txtJuridiskId";
            this.txtJuridiskId.Size = new System.Drawing.Size(526, 31);
            this.txtJuridiskId.TabIndex = 2;
            // 
            // btnSkapaPart
            // 
            this.btnSkapaPart.Location = new System.Drawing.Point(7, 172);
            this.btnSkapaPart.Name = "btnSkapaPart";
            this.btnSkapaPart.Size = new System.Drawing.Size(526, 71);
            this.btnSkapaPart.TabIndex = 3;
            this.btnSkapaPart.Text = "Skapa Part";
            this.btnSkapaPart.UseVisualStyleBackColor = true;
            this.btnSkapaPart.Click += new System.EventHandler(this.btnSkapaPart_Click);
            // 
            // gbVäljProdukt
            // 
            this.gbVäljProdukt.Controls.Add(this.btnNyRad);
            this.gbVäljProdukt.Controls.Add(this.cbAntal);
            this.gbVäljProdukt.Controls.Add(this.lbProdukt);
            this.gbVäljProdukt.Controls.Add(this.cbVäljProdukt);
            this.gbVäljProdukt.Location = new System.Drawing.Point(87, 358);
            this.gbVäljProdukt.Name = "gbVäljProdukt";
            this.gbVäljProdukt.Size = new System.Drawing.Size(557, 225);
            this.gbVäljProdukt.TabIndex = 1;
            this.gbVäljProdukt.TabStop = false;
            this.gbVäljProdukt.Text = "Välj produkt";
            // 
            // cbVäljProdukt
            // 
            this.cbVäljProdukt.FormattingEnabled = true;
            this.cbVäljProdukt.Location = new System.Drawing.Point(7, 31);
            this.cbVäljProdukt.Name = "cbVäljProdukt";
            this.cbVäljProdukt.Size = new System.Drawing.Size(200, 33);
            this.cbVäljProdukt.TabIndex = 0;
            // 
            // lbProdukt
            // 
            this.lbProdukt.FormattingEnabled = true;
            this.lbProdukt.ItemHeight = 25;
            this.lbProdukt.Location = new System.Drawing.Point(239, 31);
            this.lbProdukt.Name = "lbProdukt";
            this.lbProdukt.Size = new System.Drawing.Size(294, 79);
            this.lbProdukt.TabIndex = 1;
            // 
            // cbAntal
            // 
            this.cbAntal.FormattingEnabled = true;
            this.cbAntal.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbAntal.Location = new System.Drawing.Point(6, 77);
            this.cbAntal.Name = "cbAntal";
            this.cbAntal.Size = new System.Drawing.Size(201, 33);
            this.cbAntal.TabIndex = 2;
            // 
            // btnNyRad
            // 
            this.btnNyRad.Location = new System.Drawing.Point(7, 143);
            this.btnNyRad.Name = "btnNyRad";
            this.btnNyRad.Size = new System.Drawing.Size(200, 76);
            this.btnNyRad.TabIndex = 3;
            this.btnNyRad.Text = "Ny Rad";
            this.btnNyRad.UseVisualStyleBackColor = true;
            this.btnNyRad.Click += new System.EventHandler(this.btnNyRad_Click);
            // 
            // btnLäggBeställning
            // 
            this.btnLäggBeställning.Location = new System.Drawing.Point(94, 590);
            this.btnLäggBeställning.Name = "btnLäggBeställning";
            this.btnLäggBeställning.Size = new System.Drawing.Size(550, 102);
            this.btnLäggBeställning.TabIndex = 2;
            this.btnLäggBeställning.Text = "Lägg beställning";
            this.btnLäggBeställning.UseVisualStyleBackColor = true;
            this.btnLäggBeställning.Click += new System.EventHandler(this.btnLäggBeställning_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 721);
            this.Controls.Add(this.btnLäggBeställning);
            this.Controls.Add(this.gbVäljProdukt);
            this.Controls.Add(this.gbKund);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbKund.ResumeLayout(false);
            this.gbKund.PerformLayout();
            this.gbVäljProdukt.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbKund;
        private System.Windows.Forms.Button btnSkapaPart;
        private System.Windows.Forms.TextBox txtJuridiskId;
        private System.Windows.Forms.TextBox txtNamn;
        private System.Windows.Forms.GroupBox gbVäljProdukt;
        private System.Windows.Forms.Button btnNyRad;
        private System.Windows.Forms.ComboBox cbAntal;
        private System.Windows.Forms.ListBox lbProdukt;
        private System.Windows.Forms.ComboBox cbVäljProdukt;
        private System.Windows.Forms.Button btnLäggBeställning;
    }
}

