using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veryhelpfulsystem
{
    public partial class NewItemPanel : UserControl
    {
        public NewItemPanel()
        {
            InitializeComponent();
        }
        public void Build(NewsItem item)
        {
            lbTime.Text = item.Date.ToShortDateString();
            lbTitle.Text = item.Title;
            tbContent.Text = item.Content;
            pbImage.ImageLocation = item.ImageURL;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
