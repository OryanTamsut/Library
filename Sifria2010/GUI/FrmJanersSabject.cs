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
    public partial class FrmJanersSabject : Form
    {
        private statusKind statusFrm;
        private Subjects myJaner;
        private SubjectsTable myJanersTable;
        public frmBooks myFrmBooks;
        
        public FrmJanersSabject(statusKind statusF)
        {
            InitializeComponent();
            this.statusFrm = statusF;
            myJanersTable = new SubjectsTable();
        
        }
        public FrmJanersSabject(statusKind statusF,frmBooks f)
        {
            InitializeComponent();
            this.statusFrm = statusF;
            myJanersTable = new SubjectsTable();
            this.myFrmBooks = f;
        }

        private void FrmJanersSabject_Load(object sender, EventArgs e)
        {
            if (statusFrm == statusKind.add)
            {
                lblHeadLine.Text = "הוסף ז'אנר ספר";
                lblCode.Text = Convert.ToString(myJanersTable.GetNextKod());
                cmbChooseJaner.Visible = false;
                label1.Visible = false;
                btnFinish.Text = "הוסף ז'אנר";
            }
            else if (this.statusFrm == statusKind.delete)
            {
                lblHeadLine.Text = "מחק ז'אנר";
                btnFinish.Text = "מחק ז'אנר";
                cmbChooseJaner.DataSource = myJanersTable.GetTable();
                cmbChooseJaner.DisplayMember = "subjectName";
                cmbChooseJaner.ValueMember = "subjectId";
                cmbChooseJaner.Text = "-בחר ז'אנר-";
                grbJanerDetails.Enabled = false;
            }
        }
            public bool BuildObjectByFields()
            {
                errorp1.Clear();
                bool ok = true;
                this.myJaner = new Subjects();
                try
                { this.myJaner.SubjectId = Convert.ToInt32(lblCode.Text); }
                catch (Exception ex)
                { errorp1.SetError(lblCode, ex.Message); 
                ok = false; }
                try
                { this.myJaner.SubjectName = Convert.ToString(txtName.Text); }
                catch (Exception ex)
                { errorp1.SetError(txtName, ex.Message);
                ok = false; }
                return ok;
            }

            public void FillFieldsByObject()
            {
                lblCode.Text = Convert.ToString(this.myJaner.SubjectId);
                txtName.Text = Convert.ToString(this.myJaner.SubjectName);
            }



       

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (BuildObjectByFields())
            {
                DataRow myRow = this.myJaner.BuildRow();
                if (this.statusFrm == statusKind.add)
                {
                    if (this.myJanersTable.Add(myRow))

                    { MessageBox.Show("הז'אנר התווסף בהצלחה"); if (myFrmBooks != null) { myFrmBooks.indexJaner = myJaner.SubjectId; this.Close(); } }

                    else
                        MessageBox.Show("הז'אנר קיים במאגר");
                    lblCode.Text = Convert.ToString(myJanersTable.GetNextKod());
                    txtName.Text = "";
                }
                else if (statusFrm == statusKind.delete)
                {
                    if (this.myJanersTable.Delete(myRow))
                        MessageBox.Show("הז'אנר נמחק");
                    else
                        MessageBox.Show("הז'אנר לא נמצא");
                    lblCode.Text = "";
                    txtName.Text = "";
                    lblHeadLine.Text = "מחק ז'אנר";
                    btnFinish.Text = "מחק ז'אנר";
                    cmbChooseJaner.DataSource = myJanersTable.GetTable();
                    cmbChooseJaner.DisplayMember = "subjectName";
                    cmbChooseJaner.ValueMember = "subjectId";
                    cmbChooseJaner.Text = "-בחר ז'אנר-";
                    grbJanerDetails.Enabled = false;
                }
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            string hebrowTav = "אבגדהוזחטיכלמנסעפצקרשתםןךץף";
            if (hebrowTav.IndexOf(c) == -1 && c != ' ' && c != '\b')
            { e.Handled = true; Console.Beep(); }
        }

        private void cmbChooseJaner_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int janerId = Convert.ToInt32(cmbChooseJaner.SelectedValue);
            DataRow dr = myJanersTable.find(janerId);
            this.myJaner = new Subjects(dr);
            grbJanerDetails.Enabled = true;
            btnFinish.Enabled = true;
            FillFieldsByObject();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text != "") btnFinish.Enabled = true;
            else btnFinish.Enabled = false;
        }
    }
}



