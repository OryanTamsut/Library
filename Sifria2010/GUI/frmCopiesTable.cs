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
    public partial class frmCopiesTable : Form
    {
        private CopiesTable myCopiesTable;

        public frmCopiesTable()
        {
            InitializeComponent();
            myCopiesTable = new CopiesTable();
        }

        private void frmCopiesTable_Load(object sender, EventArgs e)
        {
            DataTable dt = myCopiesTable.GetTable();
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "קוד ספר";
            dataGridView1.Columns[2].HeaderText = "קוד עותק";
        }
    }
}
