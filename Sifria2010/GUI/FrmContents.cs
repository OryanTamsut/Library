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
    public partial class FrmContents : Form
    {
        private statusKind statusFrm;
        private Content myContent;
        private ContentTable myContentsTable;
        public frmBooks myFrmBooks;
        public FrmContents(statusKind statusF)
        {
            InitializeComponent();
            this.statusFrm = statusF;
            myContentsTable = new ContentTable(); 
        }

        public FrmContents(statusKind statusF,frmBooks f)
        {
            InitializeComponent();
            this.statusFrm = statusF;
            myContentsTable = new ContentTable();
            this.myFrmBooks = f;
        }
        private void FrmContents_Load(object sender, EventArgs e)
        {
            if (statusFrm == statusKind.add)
            {
                lblHeadLine.Text = "הוסף תוכן ספר";
                lblCode.Text = Convert.ToString(myContentsTable.GetNextKod());
                cmbContents.Visible = false;
                label1.Visible = false;
                btnFinish.Text = "הוסף תוכן";
            }
            else if (this.statusFrm == statusKind.delete)
            {
                lblHeadLine.Text = "מחק תוכן";
                btnFinish.Text = "מחק תוכן";
                cmbContents.DataSource = myContentsTable.GetTable();
                cmbContents.DisplayMember = "contentName";
                cmbContents.ValueMember = "contentId";
                cmbContents.Text = "-בחר תוכן-";
                grbContentsDetails.Enabled = false;
            }
        }
        public bool BuildObjectByFields()
        {
            errorp1.Clear();
            bool ok = true;
            this.myContent = new Content();
            try
            { this.myContent.ContentId = Convert.ToInt32(lblCode.Text); }
            catch(Exception ex)
            { errorp1.SetError(lblCode, ex.Message); ok = false; }
            try
            { this.myContent.ContentName = Convert.ToString(txtContentName.Text);}
            catch(Exception ex)
            { errorp1.SetError(txtContentName, ex.Message); ok = false; }
            return ok;
        }

        public void FillFieldsByObject()
        {
            lblCode.Text = Convert.ToString(this.myContent.ContentId);
            txtContentName.Text = Convert.ToString(this.myContent.ContentName);
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (BuildObjectByFields())
            {
                DataRow myRow = this.myContent.BuildRow();
                if (this.statusFrm == statusKind.add)
                {
                    if (this.myContentsTable.Add(myRow))

                    {
                        MessageBox.Show("התוכן התווסף בהצלחה"); if (myFrmBooks != null) { this.myFrmBooks.indexContent = myContent.ContentId; this.Close(); }
                    }

                    else
                        MessageBox.Show("התוכן קיים במאגר");
                    lblCode.Text = Convert.ToString(myContentsTable.GetNextKod());
                    txtContentName.Text = "";
                }
                else if (statusFrm == statusKind.delete)
                {
                    if (this.myContentsTable.Delete(myRow))
                        MessageBox.Show("התוכן נמחק");
                    else
                        MessageBox.Show("התוכן לא נמצא");
                    lblCode.Text = "";
                    txtContentName.Text = "";
                    lblHeadLine.Text = "מחק תוכן";
                    btnFinish.Text = "מחק תוכן";
                    cmbContents.DataSource = myContentsTable.GetTable();
                    cmbContents.DisplayMember = "contentName";
                    cmbContents.ValueMember = "contentId";
                    cmbContents.Text = "-בחר תוכן-";
                    grbContentsDetails.Enabled = false;
                }
            }
        }

        private void txtContentName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            string hebrowTav = "אבגדהוזחטיכלמנסעפצקרשתםןךץף";
            if (hebrowTav.IndexOf(c) == -1 && c != ' ' && c != '\b')
            { e.Handled = true; Console.Beep(); }
        }

        private void cmbContents_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int contentId = Convert.ToInt32(cmbContents.SelectedValue);
            DataRow dr = myContentsTable.find(contentId);
            this.myContent = new Content(dr);
            grbContentsDetails.Enabled = true;
            btnFinish.Enabled = true;
            FillFieldsByObject();
        }

        private void txtContentName_TextChanged(object sender, EventArgs e)
        {
            if (txtContentName.Text != "") btnFinish.Enabled = true;
            else btnFinish.Enabled = false;
        }
    }
}
