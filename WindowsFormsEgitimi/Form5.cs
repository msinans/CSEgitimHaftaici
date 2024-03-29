﻿using System;
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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKullaniciAdi.Text))
                MessageBox.Show("Kullanıcı Adı ve Şifre Boş Geçilemez!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Question); //string.IsNullOrEmpty metodu string bir elemanın null veya boş olup olmadığını kontrol eder  
            else if (string.IsNullOrWhiteSpace(txtSifre.Text))
            MessageBox.Show("Kullanıcı Adı ve Şifre Boş Geçilemez!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Question);
            else
            {
                string veritabanindakiKullanici = "Admin", veritabanindakiSifre = "123456789";
                if (txtKullaniciAdi.Text == veritabanindakiKullanici && txtSifre.Text == veritabanindakiSifre) // eğer textbox lardan girilen kullanıcı adı ve şifre veritabanındakilerle eşleşiyorsa hoş geldin mesajı ver
                {
                    groupBox1.Visible = false;
                    MessageBox.Show("Hoşgeldin" + txtKullaniciAdi.Text + "\n" + "Şifren :" + txtSifre.Text);
                    this.Hide(); // bu formu (Form5) gizle
                    Form4 form4 = new Form4();
                    form4.ShowDialog();

                }
                else MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop); // giriş başarısızsa uyarı penceresi göser
            }
        }
    }
}
