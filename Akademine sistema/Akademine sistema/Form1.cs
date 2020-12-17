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
    public partial class Form1 : Form
    {
        
        DataBase db = new DataBase();

        public Form1()
        {
            InitializeComponent();

            labelName.Text = $"My full name is: {db.LoggedInTeacher}";
    }
         
        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void buttonIseiti_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Ar tikrai norite iseiti?", "Akademine sistema", MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void NumbersOnly(object sender, KeyPressEventArgs e)
        {
            int asciiCode = Convert.ToInt32(e.KeyChar);
            if (asciiCode != 8)
            {
                if (asciiCode >= 48 && asciiCode <= 57)
                {
                    e.Handled = false;
                }
                else
                {
                    MessageBox.Show("Veskite tik skaicius!", "Klaida: Veskite tik skaicius!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    e.Handled = true;
                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string StudentIDq = "select stud_ID,name,surname,group_ID from Students WHERE name='"+ textBoxName.Text+ "' AND surname='" + textBoxSurname.Text + "' AND stud_ID='" + textBoxStudentID.Text + "'";
            db.ExecuteQuery(StudentIDq);
            dataGridView1.DataSource = db.LoadData(StudentIDq);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string StudentIDq = "Insert INTO Grades (student_ID,subject_ID, grade, username) values ('" + textBoxStudentGradeID.Text + "','" + textBoxSubjectGradeID.Text + "','" + textBoxGrade.Text + "','"+ textBoxStudName .Text+ "')";
            db.ExecuteQuery(StudentIDq);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string StudentIDq = "Select stud_ID,name,surname,group_ID from Students";
            db.ExecuteQuery(StudentIDq);
            dataGridView1.DataSource = db.LoadData(StudentIDq);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string StudentIDq = "Select student_ID, subject_ID, grade from Grades";
            db.ExecuteQuery(StudentIDq);
            dataGridView1.DataSource = db.LoadData(StudentIDq);
        }
    }
}
