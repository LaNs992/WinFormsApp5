using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp5.from
{
    public partial class mainForm : Form
    {

        public mainForm()
        {
            InitializeComponent();
            InitUser();
        }

        public void InitUser()
        {
            var user = AuthForm.user;
            pictureBox1.Image = Bitmap.FromFile(Path.Combine("Resurces", user.Photo));

            label1.Text = user.Email;
            label2.Text = user.Phone;
            label3.Text = user.Birthday.ToString();
            if (user.RoleId == 1) label4.Text = "Участник";
            if (user.RoleId == 2) label4.Text = "Модер ";
            if (user.RoleId == 3) label4.Text = "Жюри";
            if (user.RoleId == 4) label4.Text = "Орагнизватор";
            label5.Text= ($"{user.Name} {user.Surname} {user.Patronymic}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var f = new Form1();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var add= new AddZhurForm();
            add.ShowDialog();
        }
    }
}
