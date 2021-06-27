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
    public partial class FrmWriter : Form
    {
        private statusKind statusFrm;
        private Writers myWriter;
        private WritersTable myWritersTable;
        public frmBooks myFrmBooks;
        public FrmWriter(statusKind statusF)
        {
            InitializeComponent();
            this.statusFrm = statusF;
            myWritersTable = new WritersTable ();
        }
        public FrmWriter(statusKind statusF,frmBooks myFrmBooks1)
        {
            InitializeComponent();
            this.statusFrm = statusF;
            myWritersTable = new WritersTable();
            this.myFrmBooks = myFrmBooks1;
        }

        private void FrmWriter_Load(object sender, EventArgs e)
        {
            if (this.statusFrm == statusKind.add)
            {
                lblWriterId.Text = Convert.ToString(myWritersTable.GetNextKod());
                label1.Visible = false;
                cmbChooseWriter.Visible = false;
                lblAddWriter.Text = "הוסף סופר";
            }
            else if(this.statusFrm==statusKind.delete)
            {
                lblAddWriter.Text = "מחק סופר";
                btnAdd.Text = "מחק סופר";
                cmbChooseWriter.DataSource = myWritersTable.GetTable();
                cmbChooseWriter.DisplayMember = "writerName";
                cmbChooseWriter.ValueMember = "writerId";
                cmbChooseWriter.Text = "-בחר סופר-";
                GRBwriterDetails.Enabled = false;
                
            }
        }

        public bool BuildObjectByFields()
        {
            errop1.Clear();
            bool ok = true;
            this.myWriter = new Writers();
            try
            {
                this.myWriter.WriterId = Convert.ToInt32(lblWriterId.Text);
            }
            catch(Exception ex)
            {
                errop1.SetError(lblWriterId, ex.Message);
                ok = false;
            }
            try
            {
                this.myWriter.WriterName  = Convert.ToString(txtWriterName.Text);
            }
            catch (Exception ex)
            {
                errop1.SetError(txtWriterName, ex.Message);
                ok = false;
            }
            return ok;
        }

        public void FillFieldsByObject()
        {
             lblWriterId.Text = Convert.ToString(this.myWriter.WriterId);
            txtWriterName.Text = Convert.ToString(this.myWriter.WriterName);
        
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (BuildObjectByFields())
            {
                DataRow myRow = this.myWriter.BuildRow();
                if (statusFrm == statusKind.add)
                {
                    if (this.myWritersTable.Add(myRow))

                    {
                        MessageBox.Show("הסופר התווסף בהצלחה"); if (myFrmBooks != null) { this.myFrmBooks.indexWriter = myWriter.WriterId; this.Close(); } 
                    }

                    else
                        MessageBox.Show("הסופר קיים במאגר");
                    lblWriterId.Text = Convert.ToString(myWritersTable.GetNextKod());
                    txtWriterName.Text = "";
                }
                else if (statusFrm == statusKind.delete)
                {
                    if (this.myWritersTable.Delete(myRow))
                        MessageBox.Show("הסופר נמחק");
                    else
                        MessageBox.Show("הסופר לא נמצא");
                    lblWriterId.Text = "";
                    txtWriterName.Text = "";
                    lblAddWriter.Text = "מחק סופר";
                    btnAdd.Text = "מחק סופר";
                    cmbChooseWriter.DataSource = myWritersTable.GetTable();
                    cmbChooseWriter.DisplayMember = "writerName";
                    cmbChooseWriter.ValueMember = "writerId";
                    cmbChooseWriter.Text = "-בחר סופר-";
                    GRBwriterDetails.Enabled = false;
                
                }
            }
       
        }

        private void txtWriterName_KeyPress(object sender, KeyPressEventArgs e)
         {
             char c = e.KeyChar;
             string englishTav = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
             string hebrowTav = "אבגדהוזחטיכלמנסעפצקרשתםןךץף";
             if ((hebrowTav.IndexOf(c) == -1 && c != ' ' && c != '\b')&&(englishTav.IndexOf(c) == -1 && c != ' ' && c != '\b'))
             { e.Handled = true; Console.Beep(); }
         }
         
        private void cmbChooseWriter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int writerId = Convert.ToInt32(cmbChooseWriter.SelectedValue);
            DataRow dr = myWritersTable.find(writerId);
            this.myWriter = new Writers(dr);
            GRBwriterDetails.Enabled = true;
            FillFieldsByObject();
        }

        
    
    
    
    
    
    
    
    
    
    
    
    
    }
}
