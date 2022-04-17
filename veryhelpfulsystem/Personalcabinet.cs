using System; 
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veryhelpfulsystem
{
    public partial class Personalcabinet : Form
    {
        List<user> users = new List<user>();
        private long ID;

        public Personalcabinet(int ID)
        {
            InitializeComponent();
            this.ID = ID;
        }


        private void Personalcabinet_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM studente WHERE ID=@ID";
            SQLiteConnection connection = new SQLiteConnection("Data Source='studente.db'");
            connection.Open();
            using (SQLiteCommand command = new SQLiteCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@ID", ID);
                SQLiteDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    IDtext.Text = dataReader.GetValue(0).ToString();
                    FIOtext.Text = dataReader.GetValue(1).ToString();
                    textIndivid.Text = dataReader.GetValue(4).ToString();
                }
            }
            connection.Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
