using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sifria2010.BLL;
using Sifria2010.GUI;

namespace Sifria2010
{
    public partial class frmMain : Form
    {
        private Libirian myLibirian;
        private LibirianTable myLibiriansTable;
        public frmMain()
        {
            DAL.DAL.ConnectToDB();
            InitializeComponent();
            this.myLibiriansTable = new LibirianTable();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (BuildObjectByFields())
            {
                DataRow myRow = this.myLibirian.BuildRow();
                if (myLibirian.IsEqual(myRow)) { Form1 f = new Form1(); f.Show(); }
                else MessageBox.Show("שם המשתמש או הסיסמא שהזנת- שגויים");
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
            return ok;
         }

        private void label4_Click(object sender, EventArgs e)
        {
            FrmChangePassward f = new FrmChangePassward();
            f.ShowDialog();
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            label4.ForeColor = Color.DarkOrange;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Black;
        }

        private void txtLibrianId_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (((txtLibrianId.Text.Length < 9) && (c >= '0' && c <= '9')) || c == '\b') e.Handled = false;
            else { e.Handled = true; Console.Beep(); }
        }

        private void btnFinish_MouseHover(object sender, EventArgs e)
        {
            
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
