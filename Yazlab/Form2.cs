using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yazlab
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void temizle(String seri)
        {
            this.chart1.Series[seri].Points.Clear();
        }

        public void ekle(String seri, int i, int dizi)
        {
            this.chart1.Series[seri].Points.AddXY(i, dizi);
        }

    }
}
