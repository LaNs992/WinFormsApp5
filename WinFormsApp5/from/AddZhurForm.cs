using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp5.models;

namespace WinFormsApp5.from
{
    public partial class AddZhurForm : Form
    {
        public User user;
        public AddZhurForm()
        {
            InitializeComponent();
            comboBox1.DisplayMember = nameof(Gender.Title);
            comboBox1.ValueMember = nameof(Gender.Id);
            comboBox2.DisplayMember = nameof(Role.Title);
            comboBox2.ValueMember = nameof(Role.Id);
            comboBox3.DisplayMember = nameof(Course.CourseId);
            comboBox3.ValueMember = nameof(Course.Id);
            comboBox4.DisplayMember = nameof(Activity.Title);
            comboBox4.ValueMember = nameof(Course.Id);

            using (var db = new A_EKZAMENContext())
            {
                comboBox1.Items.AddRange(db.Genders.ToArray());
                comboBox2.Items.AddRange(db.Roles.ToArray());
                comboBox4.Items.AddRange(db.Activities.ToArray());
                comboBox3.Items.AddRange(db.Courses.ToArray());

            }
            comboBox4.Enabled = false;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox4.UseSystemPasswordChar = true;
                textBox6.UseSystemPasswordChar = true;

            }
            else
            {
                textBox4.UseSystemPasswordChar = false;
                textBox6.UseSystemPasswordChar = false;
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

             user = new User
            {
                Name = textBox2.Text,
                Surname = textBox7.Text,
                Patronymic = textBox8.Text,
                GenderId = comboBox1.SelectedIndex + 1,
                RoleId = comboBox2.SelectedIndex + 1,
                Email = textBox3.Text,
                Phone= textBox4.Text,
                CourseId= comboBox3.SelectedIndex + 1,
           
            };
            using (var db = new A_EKZAMENContext())
            {
                db.Users.Add(user);
                db.SaveChanges();
            }
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                comboBox4.Enabled = true;
               
            }
            else comboBox4.Enabled = false;
        }
    }
}
