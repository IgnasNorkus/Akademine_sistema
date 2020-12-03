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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentLogin l = new StudentLogin();
            l.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            TeacherLogin D = new TeacherLogin();
            D.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            a.ShowDialog();
        }
    }
}
