namespace satrancsuresi_1504
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
            this.components = new System.ComponentModel.Container();
            this.btnSıhaSure = new System.Windows.Forms.Button();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.btnBeyazSure = new System.Windows.Forms.Button();
            this.lblBeyaz = new System.Windows.Forms.Label();
            this.timerBeyaz = new System.Windows.Forms.Timer(this.components);
            this.timerSiyah = new System.Windows.Forms.Timer(this.components);
            this.lblSiyah = new System.Windows.Forms.Label();
            this.lblmesaj = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSıhaSure
            // 
            this.btnSıhaSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSıhaSure.Location = new System.Drawing.Point(7, 12);
            this.btnSıhaSure.Name = "btnSıhaSure";
            this.btnSıhaSure.Size = new System.Drawing.Size(221, 69);
            this.btnSıhaSure.TabIndex = 0;
            this.btnSıhaSure.Text = "Siha Süre";
            this.btnSıhaSure.UseVisualStyleBackColor = true;
            this.btnSıhaSure.Click += new System.EventHandler(this.btnSıhaSure_Click);
            // 
            // btnBaslat
            // 
            this.btnBaslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBaslat.Location = new System.Drawing.Point(406, 18);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(216, 57);
            this.btnBaslat.TabIndex = 1;
            this.btnBaslat.Text = "Başlat";
            this.btnBaslat.UseVisualStyleBackColor = true;
            // 
            // btnBeyazSure
            // 
            this.btnBeyazSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBeyazSure.Location = new System.Drawing.Point(12, 122);
            this.btnBeyazSure.Name = "btnBeyazSure";
            this.btnBeyazSure.Size = new System.Drawing.Size(221, 50);
            this.btnBeyazSure.TabIndex = 2;
            this.btnBeyazSure.Text = "Beyaz Süre";
            this.btnBeyazSure.UseVisualStyleBackColor = true;
            this.btnBeyazSure.Click += new System.EventHandler(this.btnBeyazSure_Click);
            // 
            // lblBeyaz
            // 
            this.lblBeyaz.AutoSize = true;
            this.lblBeyaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBeyaz.Location = new System.Drawing.Point(263, 135);
            this.lblBeyaz.Name = "lblBeyaz";
            this.lblBeyaz.Size = new System.Drawing.Size(65, 24);
            this.lblBeyaz.TabIndex = 4;
            this.lblBeyaz.Text = "beyaz";
            // 
            // timerBeyaz
            // 
            this.timerBeyaz.Interval = 1000;
            this.timerBeyaz.Tick += new System.EventHandler(this.timerBeyaz_Tick);
            // 
            // timerSiyah
            // 
            this.timerSiyah.Interval = 1000;
            this.timerSiyah.Tick += new System.EventHandler(this.timerSiyah_Tick);
            // 
            // lblSiyah
            // 
            this.lblSiyah.AutoSize = true;
            this.lblSiyah.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSiyah.Location = new System.Drawing.Point(263, 34);
            this.lblSiyah.Name = "lblSiyah";
            this.lblSiyah.Size = new System.Drawing.Size(61, 24);
            this.lblSiyah.TabIndex = 5;
            this.lblSiyah.Text = "Siyah";
            // 
            // lblmesaj
            // 
            this.lblmesaj.AutoSize = true;
            this.lblmesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblmesaj.Location = new System.Drawing.Point(415, 135);
            this.lblmesaj.Name = "lblmesaj";
            this.lblmesaj.Size = new System.Drawing.Size(66, 24);
            this.lblmesaj.TabIndex = 6;
            this.lblmesaj.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblmesaj);
            this.Controls.Add(this.lblSiyah);
            this.Controls.Add(this.lblBeyaz);
            this.Controls.Add(this.btnBeyazSure);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.btnSıhaSure);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSıhaSure;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Button btnBeyazSure;
        private System.Windows.Forms.Label lblBeyaz;
        private System.Windows.Forms.Timer timerBeyaz;
        private System.Windows.Forms.Timer timerSiyah;
        private System.Windows.Forms.Label lblSiyah;
        private System.Windows.Forms.Label lblmesaj;
    }
}

