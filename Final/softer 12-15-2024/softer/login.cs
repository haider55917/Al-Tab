﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace softer
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            if (username.Text == "admin" & pass.Text == "admin")
            {

                home home = new home();
                home.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("تأكد من اسم المستخدم و كلمة المرور");
            }
        }
    }
}
