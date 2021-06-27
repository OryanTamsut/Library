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
    public partial class FrmWritersTable : Form
    {
        private WritersTable writers;
        public FrmWritersTable()
        {
            InitializeComponent();
            writers = new WritersTable();
        }

        private void FrmWritersTable_Load(object sender, EventArgs e)
        {
            DataTable dt = writers.GetTable();
            DGVwritersTable.DataSource = dt;
            DGVwritersTable.Columns[0].HeaderText = "קוד סופר";
            DGVwritersTable.Columns[1].HeaderText = "שם מנוי";
            DGVwritersTable.Columns[2].Visible = false;
        }
    }
}
