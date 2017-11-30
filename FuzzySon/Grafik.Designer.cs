namespace FuzzySon
{
    partial class Grafik
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.zedGraphSicaklik = new ZedGraph.ZedGraphControl();
            this.btnGeri = new System.Windows.Forms.Button();
            this.zedGraphSeviye = new ZedGraph.ZedGraphControl();
            this.Sicaklik = new System.Windows.Forms.Label();
            this.Seviye = new System.Windows.Forms.Label();
            this.lblSicaklikDegeri = new System.Windows.Forms.Label();
            this.lblSeviyeDeger = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.zedGraphSicaklik);
            this.groupBox1.Controls.Add(this.btnGeri);
            this.groupBox1.Controls.Add(this.zedGraphSeviye);
            this.groupBox1.Location = new System.Drawing.Point(31, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1087, 547);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GİRİŞLER";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // zedGraphSicaklik
            // 
            this.zedGraphSicaklik.Location = new System.Drawing.Point(21, 41);
            this.zedGraphSicaklik.Name = "zedGraphSicaklik";
            this.zedGraphSicaklik.ScrollGrace = 0D;
            this.zedGraphSicaklik.ScrollMaxX = 0D;
            this.zedGraphSicaklik.ScrollMaxY = 0D;
            this.zedGraphSicaklik.ScrollMaxY2 = 0D;
            this.zedGraphSicaklik.ScrollMinX = 0D;
            this.zedGraphSicaklik.ScrollMinY = 0D;
            this.zedGraphSicaklik.ScrollMinY2 = 0D;
            this.zedGraphSicaklik.Size = new System.Drawing.Size(472, 367);
            this.zedGraphSicaklik.TabIndex = 0;
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGeri.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.btnGeri.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnGeri.Location = new System.Drawing.Point(381, 430);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(266, 47);
            this.btnGeri.TabIndex = 5;
            this.btnGeri.Text = "Rezistans Çıkışı";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // zedGraphSeviye
            // 
            this.zedGraphSeviye.Location = new System.Drawing.Point(603, 41);
            this.zedGraphSeviye.Name = "zedGraphSeviye";
            this.zedGraphSeviye.ScrollGrace = 0D;
            this.zedGraphSeviye.ScrollMaxX = 0D;
            this.zedGraphSeviye.ScrollMaxY = 0D;
            this.zedGraphSeviye.ScrollMaxY2 = 0D;
            this.zedGraphSeviye.ScrollMinX = 0D;
            this.zedGraphSeviye.ScrollMinY = 0D;
            this.zedGraphSeviye.ScrollMinY2 = 0D;
            this.zedGraphSeviye.Size = new System.Drawing.Size(484, 367);
            this.zedGraphSeviye.TabIndex = 1;
            // 
            // Sicaklik
            // 
            this.Sicaklik.AutoSize = true;
            this.Sicaklik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sicaklik.Location = new System.Drawing.Point(108, 19);
            this.Sicaklik.Name = "Sicaklik";
            this.Sicaklik.Size = new System.Drawing.Size(62, 20);
            this.Sicaklik.TabIndex = 7;
            this.Sicaklik.Text = "Sicaklik";
            // 
            // Seviye
            // 
            this.Seviye.AutoSize = true;
            this.Seviye.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Seviye.Location = new System.Drawing.Point(286, 19);
            this.Seviye.Name = "Seviye";
            this.Seviye.Size = new System.Drawing.Size(55, 20);
            this.Seviye.TabIndex = 9;
            this.Seviye.Text = "Seviye";
            // 
            // lblSicaklikDegeri
            // 
            this.lblSicaklikDegeri.AutoSize = true;
            this.lblSicaklikDegeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSicaklikDegeri.Location = new System.Drawing.Point(184, 19);
            this.lblSicaklikDegeri.Name = "lblSicaklikDegeri";
            this.lblSicaklikDegeri.Size = new System.Drawing.Size(19, 20);
            this.lblSicaklikDegeri.TabIndex = 8;
            this.lblSicaklikDegeri.Text = "0";
            // 
            // lblSeviyeDeger
            // 
            this.lblSeviyeDeger.AutoSize = true;
            this.lblSeviyeDeger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSeviyeDeger.Location = new System.Drawing.Point(362, 19);
            this.lblSeviyeDeger.Name = "lblSeviyeDeger";
            this.lblSeviyeDeger.Size = new System.Drawing.Size(19, 20);
            this.lblSeviyeDeger.TabIndex = 10;
            this.lblSeviyeDeger.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(863, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(929, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 12;
            this.textBox1.Visible = false;
            // 
            // Grafik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 605);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSeviyeDeger);
            this.Controls.Add(this.Seviye);
            this.Controls.Add(this.lblSicaklikDegeri);
            this.Controls.Add(this.Sicaklik);
            this.Controls.Add(this.groupBox1);
            this.Name = "Grafik";
            this.Text = "Grafik";
            this.Load += new System.EventHandler(this.Grafik_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private ZedGraph.ZedGraphControl zedGraphSicaklik;
        private ZedGraph.ZedGraphControl zedGraphSeviye;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Label Sicaklik;
        private System.Windows.Forms.Label Seviye;
        public System.Windows.Forms.Label lblSicaklikDegeri;
        public System.Windows.Forms.Label lblSeviyeDeger;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox1;
    }
}