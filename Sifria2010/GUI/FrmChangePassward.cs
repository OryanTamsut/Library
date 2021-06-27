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
    
    public partial class FrmChangePassward : Form
    {
        DataRow drToUpdate = null;
        private LibirianTable myLibrianTable;
        private Libirian myLibrian;
        public FrmChangePassward()
        {
            InitializeComponent();
            this.myLibrianTable = new LibirianTable();
            myLibrian = new Libirian();
        }

        private void FrmChangePassward_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
            txtPassward.Visible = false;
            btnFinish.Visible = false;

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            
            if (!Isid(txtId.Text)) errorp1.SetError(txtId,"תעודת הזהות לא חוקית");
           else   drToUpdate = myLibrianTable.find(txtId.Text);
            if (drToUpdate != null)
            {
                label2.Visible = true;
                txtPassward.Visible = true;
                btnFinish.Visible = true;
                btnNext.Visible = false;
            }
            
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (txtPassward.Text == "" || txtPassward.Text.Length < 4) errorp1.SetError(txtPassward, "סיסמה מכילה מעל 4 תווים");
            else
            {
                if (BuildObjectByFields())
                {
                    DataRow myRow = this.myLibrian.BuildRow();
                    if (this.myLibrianTable.Update(myRow))
                        MessageBox.Show("הסיסמה עודכן בהצלחה");
                    else
                        MessageBox.Show("הספרנית לא קיימת במאגר");
                }

            }
        }

        public bool BuildObjectByFields()
        {
            
            errorp1.Clear();
            bool ok = true;
            myLibrian.LibirianFirstName = Convert.ToString(drToUpdate["libirianFirstName"]);
            myLibrian.LibirianLastName = Convert.ToString(drToUpdate["libirianLastName"]);
            myLibrian.Status = true;
            try { myLibrian.LibirianId = txtId.Text; }
            catch (Exception ex) { errorp1.SetError(txtId, ex.Message); ok = false; }
            try { myLibrian.Passward = txtPassward.Text; }
            catch (Exception ex) { errorp1.SetError(txtPassward, ex.Message); ok = false; }
           
            return ok;
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

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (((txtId.Text.Length < 9) && (c >= '0' && c <= '9')) || c == '\b') e.Handled = false;
            else { e.Handled = true; Console.Beep(); }
        }
    }
}
