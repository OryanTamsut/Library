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
    
    public partial class FrmMembersTable : Form
    {
        private MembersTable members;
        public FrmMembersTable()
        {
            InitializeComponent();
            members = new MembersTable();
        }

        private void FrmMembersTable_Load(object sender, EventArgs e)
        {
            DataTable dt = members.GetTable();
            DGVmembersTable.DataSource = dt;
            DGVmembersTable.Columns[12].Visible = false;
            DGVmembersTable.Columns[11].Visible = false;
            DGVmembersTable.Columns[0].HeaderText = "קוד מנוי";
            DGVmembersTable.Columns[1].HeaderText = "שם פרטי";
            DGVmembersTable.Columns[2].HeaderText = "שם משפחה";
            DGVmembersTable.Columns[3].HeaderText = "רחוב";
            DGVmembersTable.Columns[4].HeaderText = "מס' בית";
            DGVmembersTable.Columns[5].HeaderText = "עיר";
            DGVmembersTable.Columns[6].HeaderText = "תאריך לידה";
            DGVmembersTable.Columns[7].HeaderText = "פלאפון 1";
            DGVmembersTable.Columns[8].HeaderText = "פלאפון 2";
            DGVmembersTable.Columns[9].HeaderText = "מספר ספרים להשאלה";
            DGVmembersTable.Columns[10].HeaderText = "קנס";
            DGVmembersTable.Columns[13].HeaderText = "תעודת זהות";
        }
       
    }
}
