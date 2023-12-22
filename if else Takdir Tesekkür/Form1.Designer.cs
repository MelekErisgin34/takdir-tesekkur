namespace if_else_Takdir_Tesekkür
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
            this.lblOrtalama = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.txtOrtalamaniz = new System.Windows.Forms.TextBox();
            this.btnKontrolet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOrtalama
            // 
            this.lblOrtalama.AutoSize = true;
            this.lblOrtalama.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrtalama.Location = new System.Drawing.Point(7, 48);
            this.lblOrtalama.Name = "lblOrtalama";
            this.lblOrtalama.Size = new System.Drawing.Size(77, 13);
            this.lblOrtalama.TabIndex = 0;
            this.lblOrtalama.Text = "Ortalamanız:";
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.Location = new System.Drawing.Point(206, 76);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(41, 13);
            this.lblSonuc.TabIndex = 1;
            this.lblSonuc.Text = "label2";
            // 
            // txtOrtalamaniz
            // 
            this.txtOrtalamaniz.Location = new System.Drawing.Point(90, 45);
            this.txtOrtalamaniz.Name = "txtOrtalamaniz";
            this.txtOrtalamaniz.Size = new System.Drawing.Size(100, 20);
            this.txtOrtalamaniz.TabIndex = 2;
            // 
            // btnKontrolet
            // 
            this.btnKontrolet.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnKontrolet.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnKontrolet.Location = new System.Drawing.Point(90, 88);
            this.btnKontrolet.Name = "btnKontrolet";
            this.btnKontrolet.Size = new System.Drawing.Size(100, 31);
            this.btnKontrolet.TabIndex = 3;
            this.btnKontrolet.Text = "Kontrol Et";
            this.btnKontrolet.UseVisualStyleBackColor = false;
            this.btnKontrolet.Click += new System.EventHandler(this.btnKontrolet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(299, 211);
            this.Controls.Add(this.btnKontrolet);
            this.Controls.Add(this.txtOrtalamaniz);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.lblOrtalama);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrtalama;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.TextBox txtOrtalamaniz;
        private System.Windows.Forms.Button btnKontrolet;
    }
}

