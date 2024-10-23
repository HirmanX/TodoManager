using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TodoManager.DataLayer;
using TodoManager.DataLayer.Context;

namespace TodoMnager_App.SubForms
{
    public partial class AddOrEditForm : Form
    {
        private int _CurentUserId = 0;
        private int _todoId = 0;
        public int CurentUserId
        {
            get
            {
                return _CurentUserId;
            }
            set
            {
                _CurentUserId = value;
            }
        }

        public int TodoId
        {
            get
            {
                return _todoId;
            }
            set
            {
                _todoId = value;
            }
        }

        public AddOrEditForm()
        {
            InitializeComponent();
        }

        private bool IsValid()
        {
            if (txtTitle.Text == "")
            {
                MessageBox.Show("Please inter value for TITLE field");
                return false;
            }

            else
                return true;
        }

        private void AddOrEditForm_Load(object sender, EventArgs e)
        {
            using (TodoManagerContext db = new TodoManagerContext())
            {
                txtCreateBy.Text = db.UserRepository.GetById(CurentUserId).Name.ToString();
            }
            if (TodoId != 0)
            {
                using (TodoManagerContext db = new TodoManagerContext())
                {
                    Todo todo = db.TodoRepository.GetById(TodoId);
                    txtTitle.Text = todo.Title.Trim();
                    txtCreateBy.Text = db.UserRepository.GetById(todo.CreateBy).Name.ToString().Trim();
                    txtCreateDate.Value = todo.CreateDate;
                    txtDescription.Text = todo.Description.Trim();
                    cbIsDone.Checked = todo.Status ? true : false;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            bool isValid = IsValid();
            if (isValid)
            {
                using (TodoManagerContext db = new TodoManagerContext())
                {
                    Todo todo = new Todo()
                    {
                        Title = txtTitle.Text,
                        CreateDate = txtCreateDate.Value,
                        Description = txtDescription.Text,
                        Status = cbIsDone.Checked ? true : false,
                        CreateBy = CurentUserId,
                    };

                    if (TodoId == 0)
                    {
                        db.TodoRepository.Insert(todo);
                    }
                    else
                    {
                        todo.TodoID = TodoId;
                        db.TodoRepository.Update(todo);
                    }
                    db.SaveChange();


                    DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
