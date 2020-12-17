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
    public partial class TeacherLogin : Form
    {
        DataBase db = new DataBase();
        public TeacherLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string UsernameBox = textBoxUsername.Text;
            string PasswordBox = textBoxPassword.Text;

            db.LogInTeacher(UsernameBox, PasswordBox);
        }
    }
}
