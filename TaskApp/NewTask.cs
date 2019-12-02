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

namespace TaskApp
{
    public partial class NewTask : Form
    {

        public NewTask()
        {
            InitializeComponent();
            LoadFamilyList();
        }

        List<familyClass> familyList = new List<familyClass>();

        public void btnNewTask_Click(object sender, EventArgs e)
        {
            taskClass p = new taskClass();

            p.TaskTitle = txtTaskTitle.Text;
            p.AssignedPerson = comboAssignedPerson.Text;
            p.Date = dateDate.Text;
            p.Time = txtTime.Text;
            p.Priority = comboPriority.Text;
            p.Description = txtDescription.Text;
            SqliteDataAccess.SaveTask(p);
            MessageBox.Show("Task Succesfully Added");
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtTaskTitle.Clear();
            txtDescription.Clear();
            txtTime.Clear();
            comboAssignedPerson.ResetText();
            comboPriority.ResetText();
            dateDate.ResetText();
            MessageBox.Show("Cleared All Fields");
        }
        private void LoadFamilyList()
        {
            familyList = SqliteDataAccess.LoadFamily();
            comboAssignedPerson.DataSource = familyList;
            comboAssignedPerson.DisplayMember = "FamilyMember";
            comboAssignedPerson.DisplayMember = "FamilyMember";


        }
    }
}
