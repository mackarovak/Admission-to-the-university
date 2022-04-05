using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veryhelpfulsystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tg_Click(object sender, EventArgs e)
        {
            Process.Start("https://t.me/KPFU_AbiturBot");
        }

        private void vk_Click(object sender, EventArgs e)
        {
            Process.Start("https://vk.com/kazan_federal_university");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            formavhoda formavhoda = new formavhoda();
            formavhoda.Show();
        }
    }
}
