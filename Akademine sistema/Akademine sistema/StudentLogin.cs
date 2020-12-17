using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Akademine_sistema
{
    public partial class StudentLogin : Form
    {
        DataBase db = new DataBase();

        public StudentLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string UsernameBox = textBoxUsername.Text;
            string PasswordBox = textBoxPassword.Text;

            db.LogInStudent(UsernameBox, PasswordBox);
        }
    }
}
