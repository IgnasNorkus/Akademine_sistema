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
    public partial class Admin : Form
    {
        DataBase db = new DataBase();

        public Admin()
        {
            InitializeComponent();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string StudentIDq = "select * from Students WHERE name='" + textBoxName.Text + "' OR surname='" + textBoxSurname.Text + "' OR stud_ID='" + textBoxStudentID.Text + "'  OR group_ID = '" + textBoxGroupID.Text+"'";
            db.ExecuteQuery(StudentIDq);
            dataGridView1.DataSource = db.LoadData(StudentIDq);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string StudentIDq = "select * from Teachers WHERE name='" + textBoxTeacherName.Text + "' OR surname='" + textBoxTeacherSurname.Text + "' OR teacher_ID = '" + textBoxTeacher_ID.Text + "' OR subjectID = '" + textBoxTSubjectID.Text+"'";
            db.ExecuteQuery(StudentIDq);
            dataGridView1.DataSource = db.LoadData(StudentIDq);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string StudentIDq = "select * from Subjects WHERE subject='" + textBoxSubject.Text + "' OR subjectID=" + textBoxSubjectID.Text;
            db.ExecuteQuery(StudentIDq);
            dataGridView1.DataSource = db.LoadData(StudentIDq);
        }

        private void buttonDeleteStudent_Click(object sender, EventArgs e)
        {
            string StudentIDq = "Delete from Students WHERE name='" + textBoxName.Text + "' AND surname='" + textBoxSurname.Text + "' AND stud_ID='" + textBoxStudentID.Text + "'  AND group_ID = '" + textBoxGroupID.Text + "'";
            db.ExecuteQuery(StudentIDq);
        }

        private void buttonRegisterStudent_Click(object sender, EventArgs e)
        {
            string StudentIDq = "Insert Into Students (name, surname, username,password,group_ID) values ('"+ textBoxName.Text+ "','"+ textBoxSurname .Text+ "','"+ textBoxName.Text + "','"+ textBoxSurname.Text + "','"+ textBoxGroupID.Text + "')";
            db.ExecuteQuery(StudentIDq);
        }

        private void buttonDeleteTeacher_Click(object sender, EventArgs e)
        {
            string StudentIDq = "Delete from Teachers WHERE name='" + textBoxTeacherName.Text + "' AND surname='" + textBoxTeacherSurname.Text + "' AND teacher_ID='" + textBoxTeacher_ID.Text + "'  AND subjectID = '" + textBoxSubjectID.Text + "'";
            db.ExecuteQuery(StudentIDq);
        }

        private void buttonRegisterTeacher_Click(object sender, EventArgs e)
        {
            string StudentIDq = "Insert Into Teachers (name, surname, username, password, subjectID) values ('" + textBoxTeacherName.Text + "','" + textBoxTeacherSurname.Text + "','" + textBoxTeacherName.Text + "','" + textBoxTeacherSurname.Text + "','" + textBoxTSubjectID.Text + "')";
            db.ExecuteQuery(StudentIDq);
        }

        private void buttonDeleteSubject_Click(object sender, EventArgs e)
        {
            string StudentIDq = "Delete from Subjects WHERE subject='" + textBoxSubject.Text + "' AND subjectID='" + textBoxSubjectID.Text + "'";
            db.ExecuteQuery(StudentIDq);
        }

        private void buttonRegisterSubject_Click(object sender, EventArgs e)
        {
            string StudentIDq = "Insert Into Subjects (subject) values ('" + textBoxSubject.Text + "')";
            db.ExecuteQuery(StudentIDq);
        }

        private void buttonAllStudents_Click(object sender, EventArgs e)
        {
            string StudentIDq = "select * from Students";
            db.ExecuteQuery(StudentIDq);
            dataGridView1.DataSource = db.LoadData(StudentIDq);
        }

        private void buttonAllTeachers_Click(object sender, EventArgs e)
        {
            string StudentIDq = "select * from Teachers";
            db.ExecuteQuery(StudentIDq);
            dataGridView1.DataSource = db.LoadData(StudentIDq);
        }

        private void buttonAllSubjects_Click(object sender, EventArgs e)
        {
            string StudentIDq = "select * from Subjects";
            db.ExecuteQuery(StudentIDq);
            dataGridView1.DataSource = db.LoadData(StudentIDq);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string StudentIDq = "select * from Groups WHERE groupID = '" + textBox2GroupCode.Text + "' AND group_name ='" + textBoxGroupName.Text + "' AND subject_ID = '" + textBoxGroupSubject.Text + "'";
            db.ExecuteQuery(StudentIDq);
            dataGridView1.DataSource = db.LoadData(StudentIDq);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string StudentIDq = "select * from Groups";
            db.ExecuteQuery(StudentIDq);
            dataGridView1.DataSource = db.LoadData(StudentIDq);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string StudentIDq = "Insert INTO Groups (group_name, subject_ID) values ('"+ textBoxGroupName.Text+"','"+ textBoxGroupSubject.Text+"')";
            db.ExecuteQuery(StudentIDq);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string StudentIDq = "Delete from Groups WHERE group_name='" + textBoxGroupName.Text + "' OR groupID='" + textBox2GroupCode.Text + "'";
            db.ExecuteQuery(StudentIDq);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
