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
        int userID=0;
        List<user> users = new List<user>();

        public Personalcabinet(int ID)
        {
            InitializeComponent();
            userID= ID;
        }

        private void Personalcabinet_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (userID == users[i].ID)
                {
                    string sql = "SELECT * FROM studente WHERE ID=@ID AND FIO=@FIO";
                    SQLiteConnection connection = new SQLiteConnection("Data Source='studente.db'");
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@ID", IDtext.Text);
                        command.Parameters.AddWithValue("@FIO", FIOtext.Text);
                        using (SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(command))
                        {
                            using (DataTable dataTable = new DataTable())
                            {
                                dataAdapter.Fill(dataTable);
                            }
                        }
                    }
                    connection.Close();
                }
            }
        }
    }
}
