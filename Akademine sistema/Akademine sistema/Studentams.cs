using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Akademine_sistema
{
    public partial class Studentams : Form
    {
        DataBase db = new DataBase();

        public Studentams()
        {
            InitializeComponent();
        }

        private void Studentams_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Prisijunges naudotojas: " + labelLoggedIn.Text, "Logged In", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string dbCommand = "Select student_ID,subject_ID,grade from Grades Where username= '" + labelLoggedIn.Text+"'";
            dataGridView1.DataSource = db.LoadData(dbCommand);          
        }


    }
}
