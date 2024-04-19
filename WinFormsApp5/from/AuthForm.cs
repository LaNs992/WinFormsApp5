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
    public partial class AuthForm : Form
    {

        public static User user;
        public AuthForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(var db=new A_EKZAMENContext())
            {
                if (db.Users.Any(x => x.IdNumber ==Convert.ToInt16(textBox1.Text) && x.Password == textBox2.Text))
                {
                    var users = db.Users.FirstOrDefault(x => x.IdNumber == Convert.ToInt16(textBox1.Text) && x.Password == textBox2.Text);
                    user = users;
                    var main = new mainForm();
                   
                    MessageBox.Show($"добро пожаловать{user.Name} {user.Surname} {user.Patronymic}");
                    main.Show();
                    this.Hide();
                    var f = new Form1();
                    f.Hide();


                }
                else  MessageBox.Show($"идинахцй");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
