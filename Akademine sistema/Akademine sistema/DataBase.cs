using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Akademine_sistema
{
    class DataBase
    {

        private SQLiteConnection sqlconn;
        private SQLiteCommand sqlCmd;
        private DataTable sqlDT = new DataTable();
        private DataSet DS = new DataSet();
        private SQLiteDataAdapter DB;

        public string LoggedInUser;
        public string LoggedInTeacher;

        public void SetConnection()
        {
            sqlconn = new SQLiteConnection("Data Source = C:\\Users\\Ignas Norkus\\source\\repos\\Akademine sistema\\Akademine sistema\\bin\\Debug\\akademine_sistema.db");
        }
        public DataTable LoadData(string CmdText)
        {
            SetConnection();
            sqlconn.Open();

            sqlCmd = sqlconn.CreateCommand();
            string CommandText = CmdText;
            DB = new SQLiteDataAdapter(CommandText, sqlconn);
            DS.Reset();
            DB.Fill(DS);
            sqlDT = DS.Tables[0];
            sqlconn.Close();
            return sqlDT;

        }

        public void ExecuteQuery(string StudentIDq)
        {
            SetConnection();
            sqlconn.Open();
            sqlCmd = sqlconn.CreateCommand();
            sqlCmd.CommandText = StudentIDq;
            sqlCmd.ExecuteNonQuery();
            sqlCmd.Dispose();
            sqlconn.Close();
        }

        public void LogInStudent(string username, string password)
        {
            if ((username == "") && (password == "") || (username == "") || (password == ""))
            {
                MessageBox.Show("Iveskite prisijungimo varda ir slaptazodi", "Klaida", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SetConnection();
                try
                {
                    sqlconn.Open();
                    string quary = "Select * FROM Students WHERE username='" + username + "' AND password='" + password + "'";
                    SQLiteCommand com = new SQLiteCommand(quary, sqlconn);
                    com.ExecuteNonQuery();
                    SQLiteDataReader dr = com.ExecuteReader();

                    int count = 0;

                    while (dr.Read())
                    {
                        count++;
                    }

                    if (count == 1)
                    {
                        LoggedInTeacher = username;
                        Studentams s = new Studentams();
                        s.labelLoggedIn.Text = username;
                        s.Show();
                    }

                    if (count < 1)
                    {
                        MessageBox.Show("Tokio studento nera!", "Klaida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Klaida prisijungiant: " + ex);
                }
            }
        }

        public void LogInTeacher(string username, string password)
        {
            if ((username == "") && (password == "") || (username == "") || (password == ""))
            {
                MessageBox.Show("Iveskite prisijungimo varda ir slaptazodi", "Klaida", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SetConnection();
                try
                {
                    sqlconn.Open();
                    string quary = "Select * FROM Teachers WHERE username='" + username + "' AND password='" + password + "'";
                    SQLiteCommand com = new SQLiteCommand(quary, sqlconn);
                    com.ExecuteNonQuery();
                    SQLiteDataReader dr = com.ExecuteReader();

                    int count = 0;

                    while (dr.Read())
                    {
                        count++;
                    }

                    if (count == 1)
                    {
                       LoggedInTeacher = username;
                        Form1 f = new Form1();
                        f.labelName.Text = "Prisijunges destytojas: "+username;
                        f.Show();
                    }

                    if (count < 1)
                    {
                        MessageBox.Show("Tokio destytojo nera!", "Klaida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Klaida prisijungiant: " + ex);
                }
            }
        }
    }
}
