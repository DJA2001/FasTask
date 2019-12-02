using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskApp.TigerTaskClasses;
using System.Configuration;
using System.Data.SQLite;
using Dapper;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace TaskApp
{
    public partial class TigerTask : Form
    {
        List<taskClass> tasks = new List<taskClass>();
        taskClass d = new taskClass();
        //test

        public TigerTask()
        {
            InitializeComponent();
            LoadTaskList();
            dgvColumns();
        }


        public void newTaskButton_Click(object sender, EventArgs e)
        {
            Form addTask = new NewTask();
            addTask.Show();
        }

        private void LoadTaskList()
        {
            tasks = SqliteDataAccess.LoadTasks();
            dgvTasks.DataSource = tasks;

        }


        private void TigerTask_Activated(object sender, EventArgs e)
        {
            LoadTaskList();
        }

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearchBox.Text;
            List<taskClass> tasks = new List<taskClass>();
            using (IDbConnection cnn = new SQLiteConnection(SqliteDataAccess.LoadConnectionString()))
            {
                var output = cnn.Query<taskClass>("SELECT * FROM tbl_tasks WHERE TaskTitle LIKE '%" + keyword + "%' OR AssignedPerson LIKE '%" + keyword + "%' OR Date LIKE '%" + keyword + "%' OR Time LIKE '%" + keyword + "%' OR Priority LIKE '%" + keyword + "%' OR Description LIKE '&" + keyword + "%'", new DynamicParameters());
                tasks = output.ToList();
                dgvTasks.DataSource = tasks;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (d.TaskID != null)
            { 
                SqliteDataAccess.Delete(d);
                MessageBox.Show("Successfully Deleted Task");
            }
            d.TaskID = null;
        }

        private void dgvTasks_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            d.TaskID = dgvTasks.Rows[dgvTasks.SelectedRows[0].Index].Cells[0].Value.ToString();
        }

        private void dgvColumns()
        {
            dgvTasks.Columns[0].Visible = false;// The id column 
            dgvTasks.Columns[1].Width = 100;//Task Name Column
            dgvTasks.Columns[2].Width = 90;
            dgvTasks.Columns[3].Width = 75;
            dgvTasks.Columns[4].Width = 53;
            dgvTasks.Columns[5].Width = 45;
            dgvTasks.Columns[6].Width = dgvTasks.Width - 406;
        }

        private void btn_FamilyAdd_Click(object sender, EventArgs e)
        {
            Form a = new Family();
            a.Show();
        }

    }
}
