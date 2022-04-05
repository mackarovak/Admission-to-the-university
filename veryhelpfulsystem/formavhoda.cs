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
    public partial class formavhoda : Form
    {
        DataBaseHelper DataBase;
        List<user> users = new List<user>();
        public formavhoda()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void formavhoda_Load(object sender, EventArgs e)
        {
            DataBase = new DataBaseHelper();
            users = DataBase.GetsAllUsers();
        }
    }
}
