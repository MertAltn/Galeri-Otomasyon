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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Oto_GaleriEntities galeri = new Oto_GaleriEntities();

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new Form1();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form = new Form3();
            form.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Müsteri mst = new Müsteri();
            mst.madi = textBox1.Text;
            mst.msoyadi = textBox2.Text;
            mst.madres = textBox3.Text;
            mst.mtelefon = textBox4.Text;
           
            galeri.Müsteri.Add(mst);
            galeri.SaveChanges();




            foreach (Control item in Controls)
            {
                if (item is TextBox) item.Text = "";
            }

            dataGridView1.DataSource = galeri.Müsteri.ToList();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
            Arac arc = new Arac();
            arc.model = textBox1.Text;
            arc.marka = textBox2.Text;
            arc.plaka = textBox3.Text;
            arc.fiyat =Convert.ToInt32(textBox4.Text);
            

            galeri.Arac.Add(arc);
            galeri.SaveChanges();

            foreach (Control item in Controls)
            {
                if (item is TextBox) item.Text = "";
            }

            dataGridView1.DataSource = galeri.Arac.ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Satıs st = new Satıs();
            


            st.satno = Convert.ToInt32(textBox1.Text);
            st.sfiyat = Convert.ToInt32(textBox2.Text);
            st.mno = Convert.ToInt32(textBox3.Text);
            st.sat_tarih = Convert.ToDateTime(textBox4.Text);
            
            
            



            galeri.Satıs.Add(st);

       
            galeri.SaveChanges();

            foreach (Control item in Controls)
            {
                if (item is TextBox) item.Text = "";
            }

            dataGridView1.DataSource = galeri.Satıs.ToList();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Alım al = new Alım();

           
            al.afiyat = Convert.ToDecimal(textBox1.Text);
            al.mno = Convert.ToInt32(textBox2.Text);
            al.alim_tarih = Convert.ToDateTime(textBox3.Text);
            al.aracno = Convert.ToInt32(textBox4.Text);
            



            galeri.Alım.Add(al);
            galeri.SaveChanges();

            foreach (Control item in Controls)
            {
                if (item is TextBox) item.Text = "";
            }

            dataGridView1.DataSource = galeri.Alım.ToList();

        }
    }
    
}
