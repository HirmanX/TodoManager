namespace TodoMnager_App
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvTodos = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.cbDone = new System.Windows.Forms.CheckBox();
            this.cbPriority = new System.Windows.Forms.CheckBox();
            this.todoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.todoTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.todoStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.todoDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.todoCreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.todoPriority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodos)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvTodos);
            this.groupBox1.Location = new System.Drawing.Point(13, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(718, 408);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Todos";
            // 
            // dgvTodos
            // 
            this.dgvTodos.AllowUserToAddRows = false;
            this.dgvTodos.AllowUserToDeleteRows = false;
            this.dgvTodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTodos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.todoId,
            this.todoTitle,
            this.todoStatus,
            this.todoDescription,
            this.todoCreateDate,
            this.todoPriority});
            this.dgvTodos.Location = new System.Drawing.Point(6, 21);
            this.dgvTodos.Name = "dgvTodos";
            this.dgvTodos.ReadOnly = true;
            this.dgvTodos.RowHeadersWidth = 51;
            this.dgvTodos.RowTemplate.Height = 24;
            this.dgvTodos.Size = new System.Drawing.Size(705, 381);
            this.dgvTodos.TabIndex = 0;
            this.dgvTodos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTodos_CellClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnEdit,
            this.btnDelete,
            this.btnRefresh});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1004, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(41, 24);
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(39, 24);
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(57, 24);
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(62, 24);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtxtDescription);
            this.groupBox2.Location = new System.Drawing.Point(738, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 271);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Description";
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.Location = new System.Drawing.Point(6, 21);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.ReadOnly = true;
            this.rtxtDescription.Size = new System.Drawing.Size(242, 233);
            this.rtxtDescription.TabIndex = 0;
            this.rtxtDescription.Text = "";
            // 
            // cbDone
            // 
            this.cbDone.AutoSize = true;
            this.cbDone.Location = new System.Drawing.Point(744, 342);
            this.cbDone.Name = "cbDone";
            this.cbDone.Size = new System.Drawing.Size(152, 20);
            this.cbDone.TabIndex = 3;
            this.cbDone.Text = "Has this been done?";
            this.cbDone.UseVisualStyleBackColor = true;
            this.cbDone.CheckedChanged += new System.EventHandler(this.cbDone_CheckedChanged);
            // 
            // cbPriority
            // 
            this.cbPriority.AutoSize = true;
            this.cbPriority.Location = new System.Drawing.Point(744, 384);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Size = new System.Drawing.Size(123, 20);
            this.cbPriority.TabIndex = 4;
            this.cbPriority.Text = "Is this a priority?";
            this.cbPriority.UseVisualStyleBackColor = true;
            this.cbPriority.CheckedChanged += new System.EventHandler(this.cbPriority_CheckedChanged);
            // 
            // todoId
            // 
            this.todoId.DataPropertyName = "TodoID";
            this.todoId.HeaderText = "TodoId";
            this.todoId.MinimumWidth = 6;
            this.todoId.Name = "todoId";
            this.todoId.ReadOnly = true;
            this.todoId.Visible = false;
            this.todoId.Width = 125;
            // 
            // todoTitle
            // 
            this.todoTitle.DataPropertyName = "Title";
            this.todoTitle.HeaderText = "Title";
            this.todoTitle.MinimumWidth = 6;
            this.todoTitle.Name = "todoTitle";
            this.todoTitle.ReadOnly = true;
            this.todoTitle.Width = 125;
            // 
            // todoStatus
            // 
            this.todoStatus.DataPropertyName = "Status";
            this.todoStatus.HeaderText = "Status";
            this.todoStatus.MinimumWidth = 6;
            this.todoStatus.Name = "todoStatus";
            this.todoStatus.ReadOnly = true;
            this.todoStatus.Width = 125;
            // 
            // todoDescription
            // 
            this.todoDescription.DataPropertyName = "Description";
            this.todoDescription.HeaderText = "Description";
            this.todoDescription.MinimumWidth = 6;
            this.todoDescription.Name = "todoDescription";
            this.todoDescription.ReadOnly = true;
            this.todoDescription.Width = 125;
            // 
            // todoCreateDate
            // 
            this.todoCreateDate.DataPropertyName = "CreateDate";
            this.todoCreateDate.HeaderText = "Create Date";
            this.todoCreateDate.MinimumWidth = 6;
            this.todoCreateDate.Name = "todoCreateDate";
            this.todoCreateDate.ReadOnly = true;
            this.todoCreateDate.Width = 125;
            // 
            // todoPriority
            // 
            this.todoPriority.DataPropertyName = "priority";
            this.todoPriority.HeaderText = "Priority";
            this.todoPriority.MinimumWidth = 6;
            this.todoPriority.Name = "todoPriority";
            this.todoPriority.ReadOnly = true;
            this.todoPriority.Visible = false;
            this.todoPriority.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 453);
            this.Controls.Add(this.cbPriority);
            this.Controls.Add(this.cbDone);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Todo Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodos)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.DataGridView dgvTodos;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox cbDone;
        private System.Windows.Forms.CheckBox cbPriority;
        private System.Windows.Forms.DataGridViewTextBoxColumn todoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn todoTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn todoStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn todoDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn todoCreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn todoPriority;
    }
}

