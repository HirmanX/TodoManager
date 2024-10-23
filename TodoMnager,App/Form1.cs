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
using TodoMnager_App.SubForms;

namespace TodoMnager_App
{
    public partial class Form1 : Form
    {
        private int _CurentUserId ;
        public int CurentUserId
        {
            get
            {
                return _CurentUserId;
            }
            set
            {
                _CurentUserId=value;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void BindGrid()
        {
            using (TodoManagerContext db = new TodoManagerContext())
            {
                dgvTodos.DataSource = db.TodoRepository.Get(t => t.CreateBy == CurentUserId,t=>t.priority == false);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            dgvTodos.AutoGenerateColumns = false;
            BindGrid();
            cbDone.Enabled = false;
            cbPriority.Enabled = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddOrEditForm AddForm = new AddOrEditForm();
            AddForm.CurentUserId =Intermediary.UserId;
            if(AddForm.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int todoId = int.Parse(dgvTodos.CurrentRow.Cells[0].Value.ToString());
            if (todoId != 0)
            {
                using (TodoManagerContext db = new TodoManagerContext())
                {
                    db.TodoRepository.Delete(todoId);
                    db.SaveChange();
                }
                BindGrid();
            }
            else
                MessageBox.Show("Please select a row in table!");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            AddOrEditForm EditForm = new AddOrEditForm();
            EditForm.Text = "Edit";
            EditForm.CurentUserId = Intermediary.UserId;
            EditForm.TodoId = int.Parse(dgvTodos.CurrentRow.Cells[0].Value.ToString());
            if (EditForm.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
            }

        }

        private void dgvTodos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rtxtDescription.Text = dgvTodos.CurrentRow.Cells[3].Value.ToString().Trim();
            cbDone.Enabled = true;
            cbPriority.Enabled = true;
            cbDone.Checked = Convert.ToBoolean(dgvTodos.CurrentRow.Cells[2].Value);
            cbPriority.Checked = Convert.ToBoolean(dgvTodos.CurrentRow.Cells[5].Value);
        }


        private void ChangeStatus(string field)
        {
            int todoId = int.Parse(dgvTodos.CurrentRow.Cells[0].Value.ToString());
            using (TodoManagerContext db = new TodoManagerContext())
            {
                Todo todo = db.TodoRepository.GetById(todoId);
                if (field == "done")
                {
                    todo.Status = cbDone.Checked ? true : false;
                }
                else
                {
                    todo.priority = cbPriority.Checked ? true : false;
                }
                db.SaveChange();
                
            }
        }


        private void cbDone_CheckedChanged(object sender, EventArgs e)
        {
            ChangeStatus("done");
        }

        private void cbPriority_CheckedChanged(object sender, EventArgs e)
        {
            ChangeStatus("Priority");
        }
    }
}
