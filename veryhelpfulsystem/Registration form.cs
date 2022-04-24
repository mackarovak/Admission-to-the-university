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
    public partial class Registration_form : Form
    {
        public Registration_form()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            Passwordfield.UseSystemPasswordChar = true;
        }

        private void Registration_form_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            DataBaseHelper dataBase = new DataBaseHelper();
            if (LoginField.Text.Trim() == "" && Passwordfield.Text.Trim() == "")
            {
                MessageBox.Show("Ошибка, пожалуйста, придумайте логин и пароль");
            }

            if (checkUser())
            {
                return;
            }

            else { 
                string sql = "INSERT INTO 'users' ('login', 'password') VALUES (@login, @password)";
                SQLiteConnection connection = new SQLiteConnection("Data Source='users.db'");
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@login", LoginField.Text);
                    command.Parameters.AddWithValue("@password", Passwordfield.Text);
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Супер, аккаунт был создан");
                        formavhoda formavhoda = new formavhoda();
                        formavhoda.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Ошибка, аккаунт не был создан");
                    }
                }
                connection.Close();
            }
        }

        public Boolean checkUser()
        {
            DataBaseHelper dataBaseHelper=new DataBaseHelper();
            string sql = "SELECT * FROM users WHERE login=@login";
            SQLiteConnection connection = new SQLiteConnection("Data Source='users.db'");
            connection.Open();
            using (SQLiteCommand command = new SQLiteCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@login", LoginField.Text);
                using (SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(command))
                {
                    using (DataTable dataTable = new DataTable())
                    {
                        dataAdapter.Fill(dataTable);
                        if (dataTable.Rows.Count > 0)
                        {
                            MessageBox.Show("Такой логин уже существует, введите другой");
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
        }

        private void checkPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPass.Checked)
            {
                Passwordfield.UseSystemPasswordChar = false;
            }
            else
            {
                Passwordfield.UseSystemPasswordChar = true;
            }
        }
    }

}