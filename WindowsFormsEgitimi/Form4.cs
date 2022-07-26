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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test"); // Ekranda mesaj penceresi açma

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult sonuc; //Mesaj penceresinden basılan tuşun değerini tutacak değişken
            sonuc = MessageBox.Show("Çıkmak istiyor musunuz?", "Uyarı", MessageBoxButtons.OKCancel);// MessageBox pencerimize uyarıların yanısıra ok ve iptal tuşlarının çıkmasını sağlıyoruz

            if (sonuc == DialogResult.OK) this.Close(); // eğer mesaj penceresinde basılan tuş ok ise formu kapat
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Çıkmak istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) == DialogResult.Yes) Application.Exit(); // Eğer kullanıcı mesaj penceresinde çıkan uyarı penceresinde evet e basmışsa uygulamadan çık. 
            // exclamation yerine warning, question gibi farklı uyarılar da yazılabilir.
            // MessageBox.Show metodu geriye değer DialogResult türünde bir değer döner. DialogResult ise kullanııcının pencereden bastığı butondur
        }
    }
}
