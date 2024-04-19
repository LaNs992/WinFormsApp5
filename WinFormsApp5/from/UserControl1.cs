using Microsoft.Extensions.Logging;
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
    public partial class UserControl1 : UserControl
    {
        public UserControl1(Event events)
        {
            InitializeComponent();
            InitlEvent(events);
        }
        public void InitlEvent(Event events)
        {
            using (var db = new A_EKZAMENContext())
            {
                var citys= db.Cities.FirstOrDefault(x=>x.Id==events.Id);
                var winnrer = db.Users.FirstOrDefault(x=>x.Id== events.WinnerId);
                label1.Text = events.Title;
                if (events.WinnerId != null)
                {
                    label2.Text = winnrer.Name+" "+ winnrer.Surname + " " + winnrer.Patronymic;

                }
               
                label3.Text = events.Course.EventTitle;
                label4.Text = citys.Title;


            }
        }
    }
}
