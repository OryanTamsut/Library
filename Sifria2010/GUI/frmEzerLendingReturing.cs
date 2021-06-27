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
    public partial class frmEzerLendingReturing : Form
    {
        DataRow myLendingRow;
        public frmEzerLendingReturing(DataRow myLendingRow1)
        {
            InitializeComponent();
            myLendingRow = myLendingRow1;
        }
        //צריך להוסיף תקינות ולוודא שגם אחרי שהבנ"א מוחק את הכתוב הכפתור לא מאפשר לחיצה
        private void txtFineForDefect_TextChanged(object sender, EventArgs e)
        {
            if (txtFineForDefect.Text != "")
            {
                label3.Visible = true;
                txtInfoOfDefect.Visible = true;
                btnFinish.Enabled = true;
            }
            else {
                label3.Visible = false;
                txtInfoOfDefect.Visible = false;
                btnFinish.Enabled = false;
                 }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            myLendingRow["fineForDefect"] = Convert.ToInt32(txtFineForDefect.Text);
            if(txtInfoOfDefect.Text!="")
            myLendingRow["infoOfDefect"] = Convert.ToString(txtInfoOfDefect.Text);
            this.Close();
        }

        private void txtInfoOfDefect_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            string hebrowTav = "אבגדהוזחטיכלמנסעפצקרשתםןךץף1234567890";
            if (hebrowTav.IndexOf(c) == -1 && c != ' ' && c != '\b')
            { e.Handled = true; Console.Beep(); }
        }

        private void txtFineForDefect_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if ((c >= '0' && c <= '9') || c == '\b') e.Handled = false;
            else { e.Handled = true; Console.Beep(); }
        }

        private void frmEzerLendingReturing_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
