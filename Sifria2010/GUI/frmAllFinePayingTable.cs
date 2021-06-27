using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sifria2010.GUI
{
    public partial class frmAllFinePayingTable : Form
    {
        public frmAllFinePayingTable()
        {
            InitializeComponent();
        }

        private void frmAllFinePayingTable_Load(object sender, EventArgs e)
        {
            string st = "SELECT finePaying.payId, finePaying.memberId, members.firstNameMember, members.lastNameMember, finePaying.sumFine, members.fine, finePaying.payingDate FROM members INNER JOIN finePaying ON members.memberId = finePaying.memberId; ";
            DataTable dt = DAL.DAL.GetQuery(st);
            dgvAllPaying.DataSource = dt;
            dgvAllPaying.Columns[0].HeaderText = "קוד תשלום";
            dgvAllPaying.Columns[1].HeaderText = "קוד מנוי";
            dgvAllPaying.Columns[2].HeaderText = "שם פרטי מנוי";
            dgvAllPaying.Columns[3].HeaderText = "שם משפחה מנוי";
            dgvAllPaying.Columns[4].HeaderText = "סכום התשלום";
            dgvAllPaying.Columns[5].HeaderText = "הקנס שנותר למנוי";
            dgvAllPaying.Columns[6].HeaderText = "תאריך התשלום";
        }
    }
}
