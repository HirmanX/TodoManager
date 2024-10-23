using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TodoManager.DataLayer;
using TodoManager.DataLayer.Context;
using TodoManager.DataLayer.Service;


namespace TodoMnager_App.SubForms
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private bool IsValid()
        {
            if (txtUserName.Text != "" && txtPassword.Text != "")
                return true;
            else
                return false;
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using(TodoManagerContext db =  new TodoManagerContext())
            {
                bool isValid = IsValid();
                if (isValid)
                {
                    string userName = txtUserName.Text;
                    string password = txtPassword.Text;
                    var CurentUser = db.UserRepository.Get(u => u.Name == userName && u.Password == password);

                    if (CurentUser.Any())
                    {
                        Intermediary.UserId = CurentUser.First().UserID;
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("user name or password is not valid!");
                    }
                }

            }

        }
    }
}
