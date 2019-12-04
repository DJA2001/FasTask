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
    public partial class Family : Form
    {
        familyClass family = new familyClass();
        List<familyClass> familyComboList = new List<familyClass>();
        public Family()
        {
            InitializeComponent();
            LoadComboFamily();
        }

        private void LoadComboFamily()
        {
            familyComboList = SqliteDataAccess.LoadFamily();
            comboBoxManage.DataSource = familyComboList;
            comboBoxManage.DisplayMember = "FamilyMember";
            comboBoxManage.DisplayMember = "FamilyMember";
        }

        private void btnFamily_Click(object sender, EventArgs e)
        {
            family.FamilyMember = txtFamily.Text;
            SqliteDataAccess.SaveFamily(family);
            MessageBox.Show("Successfully Added Family Member");
            this.Close();
        }

        private void btnFamilyDelete_Click(object sender, EventArgs e)
        {
            family.FamilyMember = comboBoxManage.Text;
            SqliteDataAccess.DeleteFamily(family);
            MessageBox.Show("Successfully Deleted Family Member");
            this.Close();

        }
    }
}
