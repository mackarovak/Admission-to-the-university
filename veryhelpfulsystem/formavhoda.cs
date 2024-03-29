﻿using System;
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
    public partial class formavhoda : Form
    {
        List<user> users = new List<user>();
        public formavhoda()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            Passwordfield.UseSystemPasswordChar = true;
        }

        private void formavhoda_Load(object sender, EventArgs e)
        {
            Passwordfield.PasswordChar = '\0';
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (LoginField.Text.Trim() == "" && Passwordfield.Text.Trim() == "")
            {
                MessageBox.Show("Ошибка, пожалуйста, введите логин и пароль");
            }

            else
            {
                string sql = "SELECT * FROM users WHERE login=@login AND password=@password";
                SQLiteConnection connection = new SQLiteConnection("Data Source='users.db'");
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@login", LoginField.Text);
                    command.Parameters.AddWithValue("@password", Passwordfield.Text);
                    using (SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(command))
                    {
                        using (DataTable dataTable = new DataTable())
                        {
                            dataAdapter.Fill(dataTable);

                            if (dataTable.Rows.Count > 0)
                            {
                                foreach (DataRow row in dataTable.Rows)
                                {
                                    Int64 ID = (long)row["ID"];
                                    MessageBox.Show("Вы успешно вошли в систему");
                                    this.Hide();
                                    Personalcabinet personalcabinet = new Personalcabinet((int)ID);
                                    personalcabinet.Show();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ошибка, вы неверно ввели логин и пароль, попробуйте заново");
                            }

                        }
                    }
                }
                connection.Close();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration_form registration = new Registration_form();
            registration.Show();
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
