using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace veryhelpfulsystem
{
    public class DataBaseHelper
    {
        SQLiteConnection connection1;
        SQLiteConnection connection2;
        public DataBaseHelper()
        {
            connection1 = new SQLiteConnection("Data Source='users.db'");
            connection2 = new SQLiteConnection("Data Source='studente.db'");
            connection1.Open();
            connection2.Open();
        }


        public List<user> GetsAllUsers()
        {
            string sql = "SELECT ID, login, password FROM users";
            List<user> users = new List<user>();

            using (SQLiteCommand command = new SQLiteCommand(sql, connection1))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        user user = new user((int)reader["ID"], (string)reader["login"], (string)reader["password"]);
                        users.Add(user);
                    }
                }
            }
            return users;
        }

        public List<studente> GetsAllStudents()
        {
            string sql = "SELECT ID, FIO, adres, EGE, progressballs, consent FROM studente";
            List<studente> students = new List <studente>();

            using (SQLiteCommand command = new SQLiteCommand(sql, connection2))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        studente student = new studente((int)reader["ID"], (string)reader["FIO"], (string)reader["adres"], (int)reader["EGE"], (int)reader["progressballs"], (string)reader["consent"]);
                        students.Add(student);
                    }
                }
            }
            return students;
        }

        public void Close1()
        {
            connection1.Close();
        }

        public void Close2()
        {
            connection2.Close();
        }
    }
}
