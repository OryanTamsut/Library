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
    public partial class FrmLibirians : Form
    {
        private statusKind statusFrm;
        private Libirian myLibirian;
        private LibirianTable myTable;
        public FrmLibirians(statusKind statusF)
        {
            InitializeComponent();
            this.myTable = new LibirianTable();
            this.statusFrm = statusF;
        }

        private void FrmLibirians_Load(object sender, EventArgs e)
        {
            if (this.statusFrm == statusKind.add)
            {
                
                label1.Visible = false;
                cmbLibrians.Visible = false;
                lblHeadLine.Text = "הוסף ספרנית";
            }
            else if (this.statusFrm == statusKind.delete)
            {
                lblHeadLine.Text = "מחק ספרנית";
                btnFinish.Text = "מחק ספרנית";
                cmbLibrians.DataSource = myTable.GetTableForCombobox("libirianFirstName", "libirianLastName");
                cmbLibrians.DisplayMember = "fullName";
                
                cmbLibrians.ValueMember = "libirianId";
                cmbLibrians.Text = "-בחר ספרנית-";
                grbDetails.Enabled = false;

            }

            else if (this.statusFrm == statusKind.update)
            {
                lblHeadLine.Text = "עדכן פרטי ספרנית";
                btnFinish.Text = "עדכן";
                cmbLibrians.DataSource = myTable.GetTableForCombobox("libirianFirstName", "libirianLastName");
                cmbLibrians.DisplayMember = "fullName";
                cmbLibrians.ValueMember = "libirianId";
                cmbLibrians.Text = "-בחר ספרנית-";
                grbDetails.Enabled = false;
            }

        }

        public bool BuildObjectByFields()
        {
            errop1.Clear();
            bool ok = true;
            this.myLibirian = new Libirian();
            try
            { this.myLibirian.LibirianId = Convert.ToString(txtLibrianId.Text); }
            catch (Exception ex)
            {
                errop1.SetError(txtLibrianId, ex.Message);
                ok = false;
            }

            try
            { this.myLibirian.Passward = Convert.ToString(txtPassward.Text); }
            catch (Exception ex)
            {
                errop1.SetError(txtPassward, ex.Message);
                ok = false;
            }
            try
            {
                this.myLibirian.LibirianFirstName = txtFn.Text;
            }
            catch (Exception ex)
            {
                errop1.SetError(txtFn,ex.Message);
                ok = false;
            }
            try
            {
                this.myLibirian.LibirianLastName = txtLn.Text;
            }
            catch (Exception ex)
            {
                errop1.SetError(txtLn, ex.Message);
                ok = false;
            }
            return ok;
        }

        public void FillFieldsByObject()
        {
            txtLibrianId.Text = Convert.ToString(this.myLibirian.LibirianId);
            txtPassward.Text = Convert.ToString(this.myLibirian.Passward);
            txtFn.Text = Convert.ToString(this.myLibirian.LibirianFirstName);
            txtLn.Text = Convert.ToString(this.myLibirian.LibirianLastName);
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (BuildObjectByFields())
            {
                DataRow myRow = this.myLibirian.BuildRow();
                if (statusFrm == statusKind.add)
                {
                    if (this.myTable.Add(myRow))

                        MessageBox.Show("הספרנית התווספה בהצלחה");

                    else
                        MessageBox.Show("הספרנית קיימת במאגר");
                    txtLibrianId.Text = "";
                    txtLn.Text = "";
                    txtPassward.Text = "";
                    txtFn.Text = "";

                }
                else if (statusFrm == statusKind.delete)
                {
                    if (this.myTable.Delete(myRow))
                        MessageBox.Show("הספרנית נמחקה");
                    else
                        MessageBox.Show("הספרנית לא נמצאה");
                    txtLibrianId.Text = "";
                    txtLn.Text = "";
                    txtPassward.Text = "";
                    txtFn.Text = "";
                    lblHeadLine.Text = "מחק ספרנית";
                    btnFinish.Text = "מחק ספרנית";
                    cmbLibrians.DataSource = myTable.GetTable();
                    cmbLibrians.DisplayMember = "libirianFirstName";
                    //צריך לשנות כך שיציג גם שם פרטי וגם שם משפחה וגם תעודת זהות
                    cmbLibrians.ValueMember = "libirianId";
                    cmbLibrians.Text = "-בחר ספרנית-";
                    grbDetails.Enabled = false;

                }
                else if (statusFrm == statusKind.update)
                {
                    if (this.myTable.Update(myRow))
                        MessageBox.Show("הספרנית עודכנה");
                    else
                        MessageBox.Show("הספרנית לא נמצאה");
                    txtLibrianId.Text = "";
                    txtLn.Text = "";
                    txtPassward.Text = "";
                    txtFn.Text = "";
                    lblHeadLine.Text = "עדכן ספרנית";
                    btnFinish.Text = "עדכן ספרנית";
                    cmbLibrians.DataSource = myTable.GetTable();
                    cmbLibrians.DisplayMember = "libirianFirstName";
                    //צריך לשנות כך שיציג גם שם פרטי וגם שם משפחה וגם תעודת זהות
                    cmbLibrians.ValueMember = "libirianId";
                    cmbLibrians.Text = "-בחר ספרנית-";
                    grbDetails.Enabled = false;
                }

            }
        }

        private void txtLibrianId_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (((txtLibrianId.Text.Length < 9) && (c >= '0' && c <= '9')) || c == '\b') e.Handled = false;
            else { e.Handled = true; Console.Beep(); }
        }

        private void txtPassward_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            string englishTav = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string hebrowTav = "אבגדהוזחטיכלמנסעפצקרשתםןךץף";
            if ((hebrowTav.IndexOf(c) == -1 && c != ' ' && c != '\b') || (englishTav.IndexOf(c) == -1 && c != ' ' && c != '\b') || ((c >= '0' && c <= '9') || c == '\b'))
                e.Handled = false; 
            else { e.Handled = true; Console.Beep(); }
        }

        private void cmbLibrians_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string librianId = Convert.ToString(cmbLibrians.SelectedValue);
            DataRow dr = myTable.find(librianId);
            this.myLibirian = new Libirian(dr);
            grbDetails.Enabled = true;
            btnFinish.Enabled = true;
            FillFieldsByObject();
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

        private void txtLibrianId_TextChanged(object sender, EventArgs e)
        {
            if (isFieldFull()) btnFinish.Enabled = true;
            else btnFinish.Enabled = false;
        }

        private void txtPassward_TextChanged(object sender, EventArgs e)
        {
            if (isFieldFull()) btnFinish.Enabled = true;
            else btnFinish.Enabled = false;
        }

        private void txtFn_TextChanged(object sender, EventArgs e)
        {
            if (isFieldFull()) btnFinish.Enabled = true;
            else btnFinish.Enabled = false;
        }

        private void txtLn_TextChanged(object sender, EventArgs e)
        {
            if (isFieldFull()) btnFinish.Enabled = true;
            else btnFinish.Enabled = false;
        }
        public bool isFieldFull()
        {
            if (txtFn.Text != "" && txtLibrianId.Text != "" && txtLn.Text != "" && txtPassward.Text != "") return true;
            else return false; ;
        }
    }
}
