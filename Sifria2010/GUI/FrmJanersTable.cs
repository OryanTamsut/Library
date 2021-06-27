using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sifria2010.BLL;

namespace Sifria2010.GUI
{
    public partial class FrmJanersTable : Form
    {
        private SubjectsTable myJanersTable;
        public FrmJanersTable()
        {
            InitializeComponent();
            myJanersTable = new SubjectsTable();
        }

        private void FrmJanersTable_Load(object sender, EventArgs e)
        {
            DataTable dt = myJanersTable.GetTable();
            dgvJaners.DataSource = dt;
            dgvJaners.Columns[0].HeaderText ="קוד ז'אנר";
            dgvJaners.Columns[1].HeaderText = "שם ז'אנר";
            dgvJaners.Columns[2].Visible = false;
        }
    }
}
