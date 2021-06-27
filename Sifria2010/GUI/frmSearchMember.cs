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
    public partial class frmSearchMember : Form
    {
        private MembersTable myMeberTable;
        public frmSearchMember()
        {
            InitializeComponent();
            this.myMeberTable = new MembersTable();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //צריך לבדוק למה עובד רק בשביל הראל ולא בשביל אנשים אחרים
            if (txtPhone.Text[0] != '0') errorp1.SetError(txtPhone, "מספר טלפון לא תקין");
            else
            {
                int MemberId = myMeberTable.findMemberByFnLnPhon(txtFn.Text, txtLn.Text, txtPhone.Text);
                if (MemberId > 0)
                {
                    int index = MemberId;
                    FrmMember f = new FrmMember(statusKind.show, index);
                    f.ShowDialog();
                }
                else MessageBox.Show("לא נמצא מנוי העונה על הפרטים הללו");

            }
            clearFrm();
        }

        private void txtFn_TextChanged(object sender, EventArgs e)
        {
            isFinish();
        }

        private void txtLn_TextChanged(object sender, EventArgs e)
        {
            isFinish();
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            isFinish();
        }

        private void txtFn_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            string hebrowTav = "אבגדהוזחטיכלמנסעפצקרשתםןךץף";
            if (hebrowTav.IndexOf(c) == -1 && c != ' ' && c != '\b')
            { e.Handled = true; Console.Beep(); }
            
        }

        private void txtLn_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            string hebrowTav = "אבגדהוזחטיכלמנסעפצקרשתםןךץף";
            if (hebrowTav.IndexOf(c) == -1 && c != ' ' && c != '\b')
            { e.Handled = true; Console.Beep(); }
           
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (((txtPhone.Text.Length < 10) && (c >= '0' && c <= '9')) || c == '\b') e.Handled = false;
            else { e.Handled = true; Console.Beep(); }

        }
        public void isFinish()
        {
            if (txtFn.Text != "" && txtLn.Text != "" && txtPhone.Text != "")
                btnSearch.Enabled = true;
            else btnSearch.Enabled = false;
        }
    private void clearFrm()
        {
            txtFn.Text = "";
            txtLn.Text = "";
            txtPhone.Text = "";
            btnSearch.Enabled = false;
        }
    }
}
