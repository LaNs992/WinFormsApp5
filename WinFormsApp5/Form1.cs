using Microsoft.EntityFrameworkCore;
using WinFormsApp5.from;
using WinFormsApp5.models;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadUser();
        }

        public void LoadUser()
        {
            using (var db=new A_EKZAMENContext())
            {
                var events = db.Events.Include(nameof(Event.Course));
                foreach(var eventes in events)
                {
                    var infoev = new UserControl1(eventes);
                    infoev.Parent = flowLayoutPanel1;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var auth = new AuthForm();
            this.Hide();
            auth.ShowDialog();
        }
    }
}