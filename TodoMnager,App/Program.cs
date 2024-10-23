using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;
using TodoManager.DataLayer.Context;
using TodoManager.DataLayer.Service;
using TodoMnager_App.SubForms;

namespace TodoMnager_App
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 form1 = new Form1();
            LogInForm logForm = new LogInForm();
            if (logForm.ShowDialog() == DialogResult.OK)
            {
                form1.CurentUserId = Intermediary.UserId;
                Application.Run(form1);
            }
        }
    }
}
