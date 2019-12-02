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
        public Family()
        {
            InitializeComponent();
        }

        private void btnFamily_Click(object sender, EventArgs e)
        {
            family.FamilyMember = txtFamily.Text;
            SqliteDataAccess.SaveFamily(family);
            MessageBox.Show("Successfully Added Family Member");
            this.Close();
        }
    }
}
