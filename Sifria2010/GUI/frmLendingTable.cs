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
    public partial class frmLendingTable : Form
    {
        private LendingTable myTable;
        public frmLendingTable()
        {
            InitializeComponent();
            myTable = new LendingTable();
        }

        private void frmLendingTable_Load(object sender, EventArgs e)
        {
            DataTable dt = myTable.GetTable();
            dgvLendingTable.DataSource = dt;
         
            dgvLendingTable.Columns[0].HeaderText ="קוד השאלה";
            dgvLendingTable.Columns[1].HeaderText = "קוד מנוי";
            dgvLendingTable.Columns[2].HeaderText = "תאריך השאלה";
        }
    }
}
