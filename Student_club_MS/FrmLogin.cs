using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_club_MS
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            //Executes when the user enters the wrong username or user press on login button without entering username.
            //Executes when the user enters the wrong password or user press on login button without entering password.

            if (txtUsername.Text == "" || !(txtUsername.Text == "Admin") || txtPassword.Text == "" || !(txtPassword.Text == "Password")) 
            {
                pnlValidation.Visible = true;
                txtUsername.Clear();
                return;
            }


            //When the correct username and password are entered, the system's dashboard will open.
            else 
            {
                if(txtUsername.Text == "Admin" && txtPassword.Text == "Password")
                { 
                    this.Hide();
                    FrmStudent student = new FrmStudent();
                    student.Show();
                }

            }


        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
