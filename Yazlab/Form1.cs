using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yazlab {
    public partial class Form1 : Form {

        public Form1(){
            InitializeComponent();
            //WindowState = FormWindowState.Maximized;
            histogram.Enabled = false;
            tersleme.Enabled = false;
            aynalama.Enabled = false;
            sagDondur.Enabled = false;
            solDondur.Enabled = false;
            orj.Enabled = false;
            gri.Enabled = false;
            kirmizi.Enabled = false;
            yesil.Enabled = false;
            mavi.Enabled = false;
            kaydet.Enabled = false;
            hScrollBar1.Enabled = false;
        }

        Bitmap ilkFoto;
        Bitmap foto;
        int rotated = 0;

        private void button1_Click(object sender, EventArgs e){
            // resim yükleme
            OpenFileDialog open = new OpenFileDialog();
            
            // resim filtreleri
            open.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.gif, *.jfif, *.png, *.bmp) | *.jpg; *.jpeg; *.jpe; *.gif; *.jfif; *.png; *.bmp";
            if (open.ShowDialog() == DialogResult.OK){
                ilkFoto = new Bitmap(open.FileName);
                foto = ilkFoto;
                pictureBox1.Image = foto;
            }
            if (foto != null)
            {
                histogram.Enabled = true;
                tersleme.Enabled = true;
                aynalama.Enabled = true;
                sagDondur.Enabled = true;
                solDondur.Enabled = true;
                orj.Enabled = true;
                gri.Enabled = true;
                kirmizi.Enabled = true;
                yesil.Enabled = true;
                mavi.Enabled = true;
                kaydet.Enabled = true;
                hScrollBar1.Enabled = true;
                hScrollBar1.Value = 0;
            }
        }

        private void histogram_Click(object sender, EventArgs e)
        {
            var form = new Form2();
            int[] blue = new int[256];
            int[] green = new int[256];
            int[] red = new int[256];
                
            for (int i = 0; i < foto.Width; i++)
            {
                for (int j = 0; j < foto.Height; j++)
                {
                    Color pixel = foto.GetPixel(i, j);
                    red[pixel.R]++;
                    blue[pixel.B]++;
                    green[pixel.G]++;
                }
            }

            form.temizle("Red");
            form.temizle("Green");
            form.temizle("Blue");
            for (int i = 0; i < 256; i++)
            {
                form.ekle("Red", i, red[i]);
                form.ekle("Green", i, green[i]);
                form.ekle("Blue", i, blue [i]);
            }
            form.ShowDialog();
        }

        private void tersleme_Click(object sender, EventArgs e)
        {
            Color pixelColor;
            Bitmap tersFoto = new Bitmap(foto.Width, foto.Height);
            byte A, R, B, G;
            for (int i = 0; i < foto.Width; i++)
            {
                for (int j = 0; j < foto.Height; j++)
                {
                    pixelColor = foto.GetPixel(i, j);
                    A = pixelColor.A;
                    R = (byte)(255 - pixelColor.R);
                    G = (byte)(255 - pixelColor.G);
                    B = (byte)(255 - pixelColor.B);
                    tersFoto.SetPixel(i, j, Color.FromArgb((int)A, (int)R, (int)G, (int)B));
                }
            }
            foto = tersFoto;
            pictureBox1.Image = foto;
        }

        private void aynalama_Click(object sender, EventArgs e)
        {
            Bitmap aynaFoto = new Bitmap(foto.Width,foto.Height);
            for (int i = 0; i < foto.Width; i++)
            {
                for (int j = 0; j < foto.Height; j++)
                {
                    aynaFoto.SetPixel(i, j, foto.GetPixel(foto.Width-i-1, j));
                }
            }
            foto = aynaFoto;
            pictureBox1.Image = foto;
        }
        
        private void sagDondur_Click(object sender, EventArgs e)
        {
            Bitmap rotFoto = new Bitmap(foto.Height, foto.Width);
            for (int i = 0; i < rotFoto.Width; i++)
            {
                for (int j = 0; j < rotFoto.Height; j++)
                {
                    rotFoto.SetPixel(i, j, foto.GetPixel(j,rotFoto.Width-i-1));
                }
            }
            rotated++;
            foto = rotFoto;
            pictureBox1.Image = foto;
        }

        private void solDondur_Click(object sender, EventArgs e)
        {
            Bitmap rotFoto = new Bitmap(foto.Height, foto.Width);
            for (int i = 0; i < rotFoto.Width; i++)
            {
                for (int j = 0; j < rotFoto.Height; j++)
                {
                    rotFoto.SetPixel(i, j, foto.GetPixel(rotFoto.Height - j - 1, i));
                }
            }
            rotated++;
            foto = rotFoto;
            pictureBox1.Image = rotFoto;
        }

        private void kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void orj_Click(object sender, EventArgs e)
        {
            foto = ilkFoto;
            pictureBox1.Image = foto;
            hScrollBar1.Value = 0;
        }

        private void gri_Click(object sender, EventArgs e)
        {
            Bitmap griFoto = new Bitmap(foto.Width, foto.Height);
            for (int i = 0; i < foto.Width; i++)
            {
                for (int j = 0; j < foto.Height; j++)
                {
                    Color pixelColor = foto.GetPixel(i, j);
                    byte ort = (byte)((pixelColor.R * 0.3) + (pixelColor.G * 0.59) + (pixelColor.B * 0.11) / 3);
                    griFoto.SetPixel(i, j, Color.FromArgb(pixelColor.A, ort, ort, ort));
                }
            }
            foto = griFoto;
            pictureBox1.Image = foto;
        }

        private void kirmizi_Click(object sender, EventArgs e)
        {
            Bitmap redFoto = new Bitmap(foto.Width, foto.Height);
            for (int i = 0; i < foto.Width; i++)
            {
                for (int j = 0; j < foto.Height; j++)
                {
                    Color pixelColor = foto.GetPixel(i, j);
                    redFoto.SetPixel(i, j, Color.FromArgb(pixelColor.R, 0, 0));
                }
            }
            foto = redFoto;
            pictureBox1.Image = foto;
        }

        private void yesil_Click(object sender, EventArgs e)
        {
            Bitmap greenFoto = new Bitmap(foto.Width, foto.Height);
            for (int i = 0; i < foto.Width; i++)
            {
                for (int j = 0; j < foto.Height; j++)
                {
                    Color pixelColor = foto.GetPixel(i, j);
                    greenFoto.SetPixel(i, j, Color.FromArgb(0, pixelColor.G, 0));
                }
            }
            foto = greenFoto;
            pictureBox1.Image = foto;
        }

        private void mavi_Click(object sender, EventArgs e)
        {
            Bitmap blueFoto = new Bitmap(foto.Width, foto.Height);
            for (int i = 0; i < foto.Width; i++)
            {
                for (int j = 0; j < foto.Height; j++)
                {
                    Color pixelColor = foto.GetPixel(i, j);
                    blueFoto.SetPixel(i, j, Color.FromArgb(0, 0, pixelColor.B));
                }
            }
            foto = blueFoto;
            pictureBox1.Image = foto;
        }

        int eskiValue = 0;
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            double zoomFactor = 1+(hScrollBar1.Value*0.1);
            Size newSize;

            if(rotated%2 == 0)
            {
                newSize = new Size((int)(ilkFoto.Width * zoomFactor), (int)(ilkFoto.Height * zoomFactor));
            }
            else
            {
                newSize = new Size((int)(ilkFoto.Height * zoomFactor), (int)(ilkFoto.Width * zoomFactor));
            }

            foto = new Bitmap(foto, newSize);
            if (eskiValue < hScrollBar1.Value)
            {
                int bA, bR, bG, bB, aA, aR, aG, aB;
                Color before, after;
                for (int i = 0; i < foto.Height; i++)
                {
                    for (int j = 0; j < foto.Width - 2; j+=2)
                    {
                        before = foto.GetPixel(j, i);
                        after = foto.GetPixel(j + 2, i);
                        bA = (int)before.A * (int)before.A;
                        bR = (int)before.R * (int)before.R;
                        bG = (int)before.G * (int)before.G;
                        bB = (int)before.B * (int)before.B;
                        aA = (int)after.A * (int)after.A;
                        aR = (int)after.R * (int)after.R;
                        aG = (int)after.G * (int)after.G;
                        aB = (int)after.B * (int)after.B;
                        bA = (int)Math.Sqrt((bA + aA) / 2);
                        bR = (int)Math.Sqrt((bR + aR) / 2);
                        bG = (int)Math.Sqrt((bG + aG) / 2);
                        bB = (int)Math.Sqrt((bB + aB) / 2);
                        foto.SetPixel(j + 1, i, Color.FromArgb(bA, bR, bG, bB));
                    }
                }
                
            }
            eskiValue = hScrollBar1.Value;
            pictureBox1.Image = foto;
        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foto.Save(dialog.FileName+".jpg");
            }
        }

    }
}
