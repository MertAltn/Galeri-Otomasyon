using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veritabani_proje_Sonn
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        Oto_GaleriEntities galeri = new Oto_GaleriEntities();
        private void button4_Click(object sender, EventArgs e)
        {
            Form form = new Form2();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form form = new Form3();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form form = new Form4();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                List<Arac> liste3 = galeri.Arac.Where(p => p.marka.EndsWith("a")).ToList();
                dataGridView1.DataSource = liste3;
            }

            if (radioButton2.Checked == true)
            {
                int toplam = galeri.Arac.Count();
                MessageBox.Show(toplam.ToString(), "Toplam arac sayisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = galeri.Arac.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var sorgu = from d1 in galeri.Satıs
                        join d2 in galeri.Müsteri
                        on d1.satno equals d2.mno
                        select new
                        {
                            Müsteri = d2.madi,
                            satısfiyati1 = d1.sfiyat

                        };
            dataGridView1.DataSource = sorgu.ToList();

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
