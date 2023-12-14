namespace TOKO_SEPATU
{
    partial class spt_d
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
            this.lanjut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lanjut
            // 
            this.lanjut.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lanjut.Location = new System.Drawing.Point(584, 400);
            this.lanjut.Name = "lanjut";
            this.lanjut.Size = new System.Drawing.Size(204, 38);
            this.lanjut.TabIndex = 1;
            this.lanjut.Text = "LANJTKAN PEMESANAN";
            this.lanjut.UseVisualStyleBackColor = true;
            this.lanjut.Click += new System.EventHandler(this.lanjut_Click);
            // 
            // spt_d
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lanjut);
            this.Name = "spt_d";
            this.Text = "spt_d";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button lanjut;
    }
}