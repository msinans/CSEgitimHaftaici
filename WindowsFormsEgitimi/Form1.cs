using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsEgitimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Burası form yüklenirken devreye girerf
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(); // Form2 sınıfından nesne oluştur
            //form2.Show(); // Oluşan formu ekranda göster
            form2.ShowDialog(); // Form2 üstte kalır ve açılan kapanmadan diğer pencerelere geçemeyiz bir üsttekinde ise böyle olmaz, show da
         }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
