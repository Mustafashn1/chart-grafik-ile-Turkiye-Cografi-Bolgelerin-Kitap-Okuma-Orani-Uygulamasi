using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chart_grafik_kullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Series["kitap"].Points.AddXY("Akdeniz", 5);
            chart1.Series["kitap"].Points.AddXY("Ege", 8);
            chart1.Series["kitap"].Points.AddXY("Marmara", 14);
            chart1.Series["kitap"].Points.AddXY("Karadeniz", 4);
            chart1.Series["kitap"].Points.AddXY("İç Anadolu", 3);
            chart1.Series["kitap"].Points.AddXY("Güneydoğu Anadolu", 4);
            chart1.Series["kitap"].Points.AddXY("Doğu Anadolu", 2);
        }
    }
}
