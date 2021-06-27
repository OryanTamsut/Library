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
    public partial class frmMemberWithFine : Form
    {
        private DataRow myMemberDr;
        private MembersTable myMembersTable;
        public frmMemberWithFine()
        {
            InitializeComponent();
            myMembersTable = new MembersTable();

        }
        //לוודא בכל הקומבובוקסים שמציג רק נתונים שהסטטוס שלהם הוא טרו
        private void frmMemberWithFine_Load(object sender, EventArgs e)
        {
            string st = "SELECT members.firstNameMember, members.lastNameMember, members.city, members.street, members.homeNumber, members.phonA, members.phonB, members.fine, members.lastDateForFineUpdate, members.memberId FROM members WHERE(((members.fine) > 0) AND((members.status) = True));";
            dgvMemberWithFine.DataSource = DAL.DAL.GetQuery(st);
            dgvMemberWithFine.Columns[0].HeaderText = "שם פרטי מנוי";
            dgvMemberWithFine.Columns[1].HeaderText = "שם משפחה מנוי";
            dgvMemberWithFine.Columns[2].HeaderText = "עיר";
            dgvMemberWithFine.Columns[3].HeaderText = "רחוב";
            dgvMemberWithFine.Columns[4].HeaderText = "מס בית";
            dgvMemberWithFine.Columns[5].HeaderText = "מס' טלפון 1";
            dgvMemberWithFine.Columns[6].HeaderText = "מס' טלפון 2";
            dgvMemberWithFine.Columns[7].HeaderText = "סך החוב";
            dgvMemberWithFine.Columns[8].HeaderText = "תאריך אחרון לעדכון";
            dgvMemberWithFine.Columns[9].Visible = false;
            DataGridViewColumn myColmen = dgvMemberWithFine.Columns["lastDateForFineUpdate"];
            dgvMemberWithFine.Sort(myColmen, ListSortDirection.Ascending);
        }

        private void dgvMemberWithFine_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            int countRows = dgvMemberWithFine.Rows.Count;
            if (e.RowIndex != countRows - 1)
            {
                int memberId = Convert.ToInt32(dgvMemberWithFine.Rows[e.RowIndex].Cells["memberId"].Value);
                btnFinish.Enabled = true;
                this.myMemberDr = myMembersTable.find(memberId);
            }
            else { MessageBox.Show("עליך לבחור שורה מלאה"); btnFinish.Enabled = false; }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            this.myMemberDr["lastDateForFineUpdate"] = DateTime.Today;
            if (myMembersTable.Update(myMemberDr))
            {
                MessageBox.Show("המנוי עודכן על חובו");
                string st = "SELECT members.firstNameMember, members.lastNameMember, members.city, members.street, members.homeNumber, members.phonA, members.phonB, members.fine, members.lastDateForFineUpdate, members.memberId FROM members WHERE(((members.fine) > 0) AND((members.status) = True));";
                dgvMemberWithFine.DataSource = DAL.DAL.GetQuery(st);
                DataGridViewColumn myColmen = dgvMemberWithFine.Columns["lastDateForFineUpdate"];
                dgvMemberWithFine.Sort(myColmen, ListSortDirection.Ascending);
            }
            else MessageBox.Show("המערכת לא הצליחה לעדכן את המנוי על חובו");
        }
    }
}
