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
    public partial class frmSearchMemberById : Form
    {
        MembersTable myMembersTable;
        public frmSearchMemberById()
        {
            InitializeComponent();
            myMembersTable = new MembersTable();
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (((txtId.Text.Length < 9) && (c >= '0' && c <= '9')) || c == '\b') e.Handled = false;
            else { e.Handled = true; Console.Beep(); }
        }

        public bool Isid(string id)
        {
            int mikum = 0;
            int[] a = new int[9];
            int sum = 0; int temp = 0;
            for (int i = 0; i < 9; i++) a[i] = 0;
            for (int i = (a.Length - id.Length); i < 9; i++) { a[i] = Convert.ToInt32(id[mikum] - '0'); mikum++; }

            for (int i = 0; i < 9; i++)
            {

                if (i % 2 == 0) sum += a[i];

                else
                {

                    temp = a[i] * 2;
                    if (temp > 9) { temp = temp % 10 + temp / 10; }
                    sum += temp;
                }
            }
            if (sum % 10 == 0) return true;
            else return false;


        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (Isid(txtId.Text))
            {
                DataRow myRow = myMembersTable.findById(txtId.Text);

                if (myRow != null)
                {
                    FrmMember f = new FrmMember(statusKind.show, Convert.ToInt32(myRow["memberId"]));
                    f.Show();
                }
                else MessageBox.Show("המנוי לא נמצא");
            }
            else errorProvider1.SetError(txtId,"הקש תעודת זהות תקינה");
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if (txtId.Text == "") btnNext.Enabled = false;
            else btnNext.Enabled = true;
            
        }
    }
}
