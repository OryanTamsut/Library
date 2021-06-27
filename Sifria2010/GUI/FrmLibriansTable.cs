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
    public partial class FrmLibriansTable : Form
    {
        private LibirianTable myTable;
        public FrmLibriansTable()
        {
            InitializeComponent();
            this.myTable = new LibirianTable();
        }

        private void FrmLibriansTable_Load(object sender, EventArgs e)
        {
            DataTable dt = myTable.GetTable();
            dgvLibrians.DataSource = dt;
            dgvLibrians.Columns[4].Visible = false;
            dgvLibrians.Columns[0].HeaderText = "ת.ז. ספרנית";
            dgvLibrians.Columns[1].HeaderText = "שם פרטי ספרנית";
            dgvLibrians.Columns[2].HeaderText = "שם משפחה ספרנית";
            dgvLibrians.Columns[3].HeaderText = "סיסמה";
        }
    }
}
