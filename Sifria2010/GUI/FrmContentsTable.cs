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
    public partial class FrmContentsTable : Form
    {
        private ContentTable myContentsTable;
        public FrmContentsTable()
        {
            InitializeComponent();
            myContentsTable = new ContentTable();
        }

        private void FrmContentsTable_Load(object sender, EventArgs e)
        {
            DataTable dt = myContentsTable.GetTable();
            DGVcontents.DataSource = dt;
            DGVcontents.Columns[0].HeaderText = "קוד תוכן";
            DGVcontents.Columns[1].HeaderText = "שם תוכן";
            DGVcontents.Columns[2].Visible = false;
        }
    }
}
