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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Oto_GaleriEntities galeri = new Oto_GaleriEntities();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = galeri.Arac.ToList();
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new Form2();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new Form3();
                form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form = new Form4();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form form = new Form5();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = galeri.Müsteri.ToList();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = galeri.Alım.ToList();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = galeri.Satıs.ToList();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = galeri.Arac.ToList();
        }
    }
}
