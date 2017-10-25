namespace Yazlab
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.resimSec = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.histogram = new System.Windows.Forms.Button();
            this.tersleme = new System.Windows.Forms.Button();
            this.aynalama = new System.Windows.Forms.Button();
            this.sagDondur = new System.Windows.Forms.Button();
            this.solDondur = new System.Windows.Forms.Button();
            this.orj = new System.Windows.Forms.Button();
            this.kapat = new System.Windows.Forms.Button();
            this.gri = new System.Windows.Forms.Button();
            this.kirmizi = new System.Windows.Forms.Button();
            this.yesil = new System.Windows.Forms.Button();
            this.mavi = new System.Windows.Forms.Button();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // resimSec
            // 
            this.resimSec.AllowDrop = true;
            this.resimSec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resimSec.AutoSize = true;
            this.resimSec.Location = new System.Drawing.Point(549, 12);
            this.resimSec.Name = "resimSec";
            this.resimSec.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.resimSec.Size = new System.Drawing.Size(75, 25);
            this.resimSec.TabIndex = 1;
            this.resimSec.Text = "Resim Seç";
            this.resimSec.UseVisualStyleBackColor = true;
            this.resimSec.Click += new System.EventHandler(this.button1_Click);
            // 
            // histogram
            // 
            this.histogram.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.histogram.Location = new System.Drawing.Point(549, 43);
            this.histogram.Name = "histogram";
            this.histogram.Size = new System.Drawing.Size(75, 23);
            this.histogram.TabIndex = 2;
            this.histogram.Text = "Histogram";
            this.histogram.UseVisualStyleBackColor = true;
            this.histogram.Click += new System.EventHandler(this.histogram_Click);
            // 
            // tersleme
            // 
            this.tersleme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tersleme.Location = new System.Drawing.Point(549, 72);
            this.tersleme.Name = "tersleme";
            this.tersleme.Size = new System.Drawing.Size(75, 23);
            this.tersleme.TabIndex = 4;
            this.tersleme.Text = "Tersleme";
            this.tersleme.UseVisualStyleBackColor = true;
            this.tersleme.Click += new System.EventHandler(this.tersleme_Click);
            // 
            // aynalama
            // 
            this.aynalama.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aynalama.Location = new System.Drawing.Point(549, 101);
            this.aynalama.Name = "aynalama";
            this.aynalama.Size = new System.Drawing.Size(75, 23);
            this.aynalama.TabIndex = 5;
            this.aynalama.Text = "Aynalama";
            this.aynalama.UseVisualStyleBackColor = true;
            this.aynalama.Click += new System.EventHandler(this.aynalama_Click);
            // 
            // sagDondur
            // 
            this.sagDondur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sagDondur.Image = ((System.Drawing.Image)(resources.GetObject("sagDondur.Image")));
            this.sagDondur.Location = new System.Drawing.Point(589, 130);
            this.sagDondur.Name = "sagDondur";
            this.sagDondur.Size = new System.Drawing.Size(34, 35);
            this.sagDondur.TabIndex = 6;
            this.sagDondur.UseVisualStyleBackColor = true;
            this.sagDondur.Click += new System.EventHandler(this.sagDondur_Click);
            // 
            // solDondur
            // 
            this.solDondur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.solDondur.Image = ((System.Drawing.Image)(resources.GetObject("solDondur.Image")));
            this.solDondur.Location = new System.Drawing.Point(549, 130);
            this.solDondur.Name = "solDondur";
            this.solDondur.Size = new System.Drawing.Size(34, 35);
            this.solDondur.TabIndex = 7;
            this.solDondur.UseVisualStyleBackColor = true;
            this.solDondur.Click += new System.EventHandler(this.solDondur_Click);
            // 
            // orj
            // 
            this.orj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.orj.Location = new System.Drawing.Point(549, 346);
            this.orj.Name = "orj";
            this.orj.Size = new System.Drawing.Size(75, 23);
            this.orj.TabIndex = 8;
            this.orj.Text = "Orijinal";
            this.orj.UseVisualStyleBackColor = true;
            this.orj.Click += new System.EventHandler(this.orj_Click);
            // 
            // kapat
            // 
            this.kapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kapat.Location = new System.Drawing.Point(549, 375);
            this.kapat.Name = "kapat";
            this.kapat.Size = new System.Drawing.Size(75, 23);
            this.kapat.TabIndex = 9;
            this.kapat.Text = "Kapat";
            this.kapat.UseVisualStyleBackColor = true;
            this.kapat.Click += new System.EventHandler(this.kapat_Click);
            // 
            // gri
            // 
            this.gri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gri.Location = new System.Drawing.Point(549, 171);
            this.gri.Name = "gri";
            this.gri.Size = new System.Drawing.Size(75, 23);
            this.gri.TabIndex = 10;
            this.gri.Text = "Gri Tonlama";
            this.gri.UseVisualStyleBackColor = true;
            this.gri.Click += new System.EventHandler(this.gri_Click);
            // 
            // kirmizi
            // 
            this.kirmizi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kirmizi.Location = new System.Drawing.Point(549, 200);
            this.kirmizi.Name = "kirmizi";
            this.kirmizi.Size = new System.Drawing.Size(75, 23);
            this.kirmizi.TabIndex = 11;
            this.kirmizi.Text = "Kırmızı";
            this.kirmizi.UseVisualStyleBackColor = true;
            this.kirmizi.Click += new System.EventHandler(this.kirmizi_Click);
            // 
            // yesil
            // 
            this.yesil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.yesil.Location = new System.Drawing.Point(549, 229);
            this.yesil.Name = "yesil";
            this.yesil.Size = new System.Drawing.Size(75, 23);
            this.yesil.TabIndex = 12;
            this.yesil.Text = "Yeşil";
            this.yesil.UseVisualStyleBackColor = true;
            this.yesil.Click += new System.EventHandler(this.yesil_Click);
            // 
            // mavi
            // 
            this.mavi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mavi.Location = new System.Drawing.Point(549, 258);
            this.mavi.Name = "mavi";
            this.mavi.Size = new System.Drawing.Size(75, 23);
            this.mavi.TabIndex = 13;
            this.mavi.Text = "Mavi";
            this.mavi.UseVisualStyleBackColor = true;
            this.mavi.Click += new System.EventHandler(this.mavi_Click);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hScrollBar1.LargeChange = 2;
            this.hScrollBar1.Location = new System.Drawing.Point(12, 382);
            this.hScrollBar1.Maximum = 10;
            this.hScrollBar1.Minimum = -9;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.hScrollBar1.Size = new System.Drawing.Size(531, 16);
            this.hScrollBar1.TabIndex = 14;
            this.hScrollBar1.Value = 10;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 357);
            this.panel1.TabIndex = 16;
            // 
            // kaydet
            // 
            this.kaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.kaydet.Location = new System.Drawing.Point(549, 317);
            this.kaydet.Name = "kaydet";
            this.kaydet.Size = new System.Drawing.Size(75, 23);
            this.kaydet.TabIndex = 17;
            this.kaydet.Text = "Kaydet";
            this.kaydet.UseVisualStyleBackColor = true;
            this.kaydet.Click += new System.EventHandler(this.kaydet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 417);
            this.Controls.Add(this.kaydet);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.mavi);
            this.Controls.Add(this.yesil);
            this.Controls.Add(this.kirmizi);
            this.Controls.Add(this.gri);
            this.Controls.Add(this.kapat);
            this.Controls.Add(this.orj);
            this.Controls.Add(this.solDondur);
            this.Controls.Add(this.sagDondur);
            this.Controls.Add(this.aynalama);
            this.Controls.Add(this.tersleme);
            this.Controls.Add(this.histogram);
            this.Controls.Add(this.resimSec);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Görüntü İşleme Editörü";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button resimSec;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button histogram;
        private System.Windows.Forms.Button tersleme;
        private System.Windows.Forms.Button aynalama;
        private System.Windows.Forms.Button sagDondur;
        private System.Windows.Forms.Button solDondur;
        private System.Windows.Forms.Button orj;
        private System.Windows.Forms.Button kapat;
        private System.Windows.Forms.Button gri;
        private System.Windows.Forms.Button kirmizi;
        private System.Windows.Forms.Button yesil;
        private System.Windows.Forms.Button mavi;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button kaydet;
    }
}

