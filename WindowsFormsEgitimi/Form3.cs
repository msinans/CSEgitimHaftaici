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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            this.BackColor = Color.FromArgb(random.Next(1,100), random.Next(1,100), random.Next(1,100));
            //this.BackColor = Color.DarkBlue;
        }
    }
}
