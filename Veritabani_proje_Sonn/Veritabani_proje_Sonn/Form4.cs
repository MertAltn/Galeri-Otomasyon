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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        Oto_GaleriEntities galeri = new Oto_GaleriEntities();
        private void button3_Click(object sender, EventArgs e)
        {
            Form form = new Form3();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form form = new Form2();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form form = new Form5();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                List<Arac> liste1 = galeri.Arac.OrderBy(p => p.marka).ToList();
                dataGridView1.DataSource = liste1;
            }
            if (radioButton2.Checked == true)
            {
                List<Arac> liste2 = galeri.Arac.Where(p => p.aracno == 1).ToList();
                dataGridView1.DataSource = liste2;
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = galeri.Arac.ToList();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
