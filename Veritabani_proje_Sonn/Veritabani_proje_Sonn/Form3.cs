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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        Oto_GaleriEntities galeri = new Oto_GaleriEntities();
        private void Form3_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = galeri.Arac.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new Form2();
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

        private void button1_Click(object sender, EventArgs e)
        {
            
            string Marka_2 = dataGridView1.Columns[1].ValueType.ToString();
            var sil = galeri.Arac.Where(w => w.marka == Marka_2).FirstOrDefault();
            galeri.Arac.Remove(sil);
            galeri.SaveChanges();
            foreach(Control ıtem in Controls)
            {
                if (ıtem is TextBox) ıtem.Text = "";
            }
            dataGridView1.DataSource = galeri.Arac.ToList();
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
