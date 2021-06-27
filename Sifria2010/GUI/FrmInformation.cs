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
    public partial class FrmInformation : Form
    {
        private Information myInfo ;
        private InformationTable myTable;
        private statusKind statusFrm;

        public FrmInformation(statusKind statusf)
        {
            InitializeComponent();
            this.myTable = new InformationTable();
            this.statusFrm = statusf;
        }

        public bool buildObjectByFields()
        {
            errorp1.Clear();
            this.myInfo = new Information();
            bool ok = true;
            try
            {
                this.myInfo.MemberPriceForOneBook = Convert.ToInt32(txtPrice.Text);
            }
            catch (Exception ex)
            {
                ok = false;
                errorp1.SetError(txtPrice, ex.Message);
            }
            try
            {
                this.myInfo.MemberPriceForOneBook = Convert.ToInt32(txtPrice.Text);
            }
            catch (Exception ex)
            {
                ok = false;
                errorp1.SetError(txtPrice, ex.Message);
            }
            try
            {
                this.myInfo.MaxDaysLending = Convert.ToInt32(txtNumDays.Text);
            }
            catch (Exception ex)
            {
                ok = false;
                errorp1.SetError(txtNumDays, ex.Message);
            }
            try
            {
                this.myInfo.MaxNumLoanExtension = Convert.ToInt32(txtAddLending.Text);
            }
            catch (Exception ex)
            {
                ok = false;
                errorp1.SetError(txtAddLending, ex.Message);
            }
            try
            {
                this.myInfo.PrecentOfTheBookPriceForFine = Convert.ToInt32(txtPrecent.Text);
            }
            catch (Exception ex)
            {
                ok = false;
                errorp1.SetError(txtPrecent, ex.Message);
            }
            try
            {
                this.myInfo.FinePriceForOneDay = Convert.ToInt32(txtFinePriceForOneDay.Text);
            }
            catch (Exception ex)
            {
                ok = false;
                errorp1.SetError(txtFinePriceForOneDay, ex.Message);
            }
            return ok;
        }

        public void fillFieldsByObject()
        {
            this.txtPrecent.Text = Convert.ToString(myInfo.PrecentOfTheBookPriceForFine);
            this.txtAddLending.Text = Convert.ToString(myInfo.MaxNumLoanExtension);
            this.txtNumDays.Text = Convert.ToString(myInfo.MaxDaysLending);
            this.txtPrice.Text = Convert.ToString(myInfo.MemberPriceForOneBook);
            this.txtFinePriceForOneDay.Text = Convert.ToString(myInfo.FinePriceForOneDay);
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (buildObjectByFields())
            {
                DataRow dr = this.myInfo.BuildRow();
                if (statusFrm == statusKind.add)
                {
                    if (this.myTable.Add(dr))
                        MessageBox.Show("התווסף בהצלחה");
                    else MessageBox.Show("לא התווסף");
                }

                if (statusFrm == statusKind.update)
                {
                    if (this.myTable.Update(dr))
                        MessageBox.Show("הפרטים עודכנו בצלחה");
                    else MessageBox.Show("לא היה ניתן לעדכן");
                }
            }
            
            
        }

        private void FrmInformation_Load(object sender, EventArgs e)
        {
            DataRow dr = myTable .find(1);
            this.myInfo = new Information(dr);
           
            fillFieldsByObject();
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if ((c >= '0' && c <= '9') || c == '\b') e.Handled = false;
            else { e.Handled = true; Console.Beep(); }
        }

        private void txtPrecent_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if ((c >= '0' && c <= '9') || c == '\b') e.Handled = false;
            else { e.Handled = true; Console.Beep(); }
        }

        private void txtNumDays_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if ((c >= '0' && c <= '9') || c == '\b') e.Handled = false;
            else { e.Handled = true; Console.Beep(); }
        }

        private void txtAddLending_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if ((c >= '0' && c <= '9') || c == '\b') e.Handled = false;
            else { e.Handled = true; Console.Beep(); }
        }

        private void txtFinePriceForOneDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if ((c >= '0' && c <= '9') || c == '\b') e.Handled = false;
            else { e.Handled = true; Console.Beep(); }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            if (isFieldFull()) btnFinish.Enabled = true;
            else btnFinish.Enabled = false;
        }

        private void txtPrecent_TextChanged(object sender, EventArgs e)
        {
            if (isFieldFull()) btnFinish.Enabled = true;
            else btnFinish.Enabled = false;
        }

        private void txtNumDays_TextChanged(object sender, EventArgs e)
        {
            if (isFieldFull()) btnFinish.Enabled = true;
            else btnFinish.Enabled = false;
        }

        private void txtAddLending_TextChanged(object sender, EventArgs e)
        {
            if (isFieldFull()) btnFinish.Enabled = true;
            else btnFinish.Enabled = false;
        }

        private void txtFinePriceForOneDay_TextChanged(object sender, EventArgs e)
        {
            if (isFieldFull()) btnFinish.Enabled = true;
            else btnFinish.Enabled = false;
        }

        public bool isFieldFull()
        {
            if (txtAddLending.Text != "" && txtFinePriceForOneDay.Text != "" && txtNumDays.Text != "" && txtPrecent.Text != "" && txtPrice.Text != "")
                return true;
            else return false;
        }
    }
}
