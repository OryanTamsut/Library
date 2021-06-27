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
    public partial class FrmMember : Form
    {
        private statusKind statusFrm;
        private Members myMember;
        private MembersTable myMembersTable;
        private DateTime birthday;
        private int cmbIndex = 0;
        private FrmFinishLending myFrmFinishLending;
        private bool isFinishClick;
        public FrmMember(statusKind statusF)
        {
            InitializeComponent();
            myMembersTable = new MembersTable();
            this.statusFrm = statusF;
        }
        public FrmMember(statusKind statusF,int indexChooseMember)
        {
            InitializeComponent();
            myMembersTable = new MembersTable();
            this.statusFrm = statusF;
            this.cmbIndex = indexChooseMember;
        }
        public FrmMember(statusKind statusF,FrmFinishLending f )
        {
            InitializeComponent();
            myMembersTable = new MembersTable();
            this.statusFrm = statusF;
            this.myFrmFinishLending = f;
            isFinishClick = false;
        }
        private void FrmMember_Load(object sender, EventArgs e)
        {
            int x= Convert.ToInt32(DateTime.Today.Year)-120;
            int y =Convert.ToInt32(DateTime.Today.Year);
            for (int i =x; i < y; i++)
            {
                cmbYear.Items.Add(i); 
            
            }

            if (this.statusFrm == statusKind.add)
            {
                lblAdd.Text = "הוספת מנוי חדש";
                lblMemberId.Text = Convert.ToString(myMembersTable.GetNextKod());
                cmbChhoseMember.Visible = false;
                lblChooseMember.Visible = false;
                btnLending.Visible = true;
            }
            else
                if (this.statusFrm == statusKind.update)
            {
                lblAdd.Text = "עדכון מנוי";
                cmbChhoseMember.Visible = true;
                cmbChhoseMember.DataSource = myMembersTable.GetTableForCombobox("firstNameMember", "lastNameMember");
                cmbChhoseMember.DisplayMember = "fullName";
                cmbChhoseMember.ValueMember = "MemberId";
                cmbChhoseMember.SelectedValue = -1;
                cmbChhoseMember.Text = "-בחר מנוי לעדכון-";
                grpMemberDetails.Enabled = false;
                btnAdd.Enabled = false;
                btnAdd.Text = "עדכן מנוי ";
                btnLending.Visible = false;
            }
            else
                    if (this.statusFrm == statusKind.delete)
            {
                lblAdd.Text = "מחיקת מנוי";
                cmbChhoseMember.Visible = true;
                cmbChhoseMember.DataSource = myMembersTable.GetTableForCombobox("firstNameMember", "lastNameMember");
                cmbChhoseMember.DisplayMember = "fullName";
                cmbChhoseMember.ValueMember = "MemberId";
                cmbChhoseMember.SelectedValue = -1;
                cmbChhoseMember.Text = "-בחר מנוי למחיקה-";
                grpMemberDetails.Enabled = false;
                btnAdd.Enabled = false;
                btnAdd.Text = "מחק מנוי ";
                btnLending.Visible = false;
            }
            else if (statusFrm == statusKind.show)
            {
                lblAdd.Text = "הצגת פרטי מנוי";
                cmbChhoseMember.Visible = true;
                cmbChhoseMember.DataSource = myMembersTable.GetTableForCombobox("firstNameMember", "lastNameMember");
                cmbChhoseMember.DisplayMember = "fullName";
                cmbChhoseMember.ValueMember = "MemberId";
                cmbChhoseMember.SelectedValue = -1;
                cmbChhoseMember.Text = "-בחר מנוי להצגה-";
                grpMemberDetails.Enabled = false;
                btnAdd.Visible = false;
                if(cmbIndex > 0)
                cmbChhoseMember.SelectedValue = cmbIndex;
                btnNext.Visible = true;
                btnLending.Visible = false;
            }

        }
        //בונה אובייקט ע"י הפרטים שהוזנו בשדות
        public bool BuildObjectByFields()
        {
            errop1.Clear();
            bool ok = true;
            this.myMember = new Members();
            try
            {
                this.myMember.MemberId = Convert.ToInt32(lblMemberId.Text);
            }
            catch (Exception ex)
            {
                errop1.SetError(lblMemberId, ex.Message);
                ok = false;
            }
            // מטעין קוד מנוי
            try
            {
                this.myMember.MemberId = Convert.ToInt32(lblMemberId.Text);
            }
            catch (Exception ex)
            {
                errop1.SetError(lblMemberId, ex.Message);
                ok = false;
            }
            // מטעין שם פרטי
            try
            {
                this.myMember.FirstNameMember = Convert.ToString(txtMemberFN.Text);
            }
            catch (Exception ex)
            {
                errop1.SetError(txtMemberFN, ex.Message);
                ok = false;
            }
            //מטעין שם משפחה
            try
            {
                this.myMember.LastNameMember = Convert.ToString(txtMemberLN.Text);
            }
            catch (Exception ex)
            {
                errop1.SetError(txtMemberLN, ex.Message);
                ok = false;
            }
            // מטעין כתובת
            try
            {
                this.myMember.Street = Convert.ToString(txtMemberStreet.Text);
            }
            catch (Exception ex)
            {
                errop1.SetError(txtMemberStreet, ex.Message);
                ok = false;
            }
            // מטעין מספר בית
            try
            {
                this.myMember.HomeNumber = Convert.ToInt32(txtMemberNamHouse.Text);
            }
            catch (Exception ex)
            {
                errop1.SetError(txtMemberNamHouse, ex.Message);
                ok = false;
            }
            //מטעין עיר
            try
            {
                this.myMember.City = Convert.ToString(txtMemberCity.Text);
            }
            catch (Exception ex)
            {
                errop1.SetError(txtMemberCity, ex.Message);
                ok = false;
            }
            //מטעין טלפון1
            try
            {
                this.myMember.PhonA = Convert.ToString(txtMemberPhon1.Text);
            }
            catch (Exception ex)
            {
                errop1.SetError(txtMemberPhon1, ex.Message);
                ok = false;
            }
            //מטעין טלפון2
            try
            {
                this.myMember.PhonB = Convert.ToString(txtMemberPhon2.Text);
            }
            catch (Exception ex)
            {
                errop1.SetError(txtMemberPhon2, ex.Message);
                ok = false;
            }
            //מטעין תאריך לידה
            try
            {
                birthday = new DateTime(Convert.ToInt32(cmbYear.SelectedItem), Convert.ToInt32(cmbMonth.SelectedItem), Convert.ToInt32(cmbDay.SelectedItem));
                this.myMember.BirthDay = birthday;
            }
            catch (Exception ex)
            {
                errop1.SetError(cmbYear, ex.Message);
                ok = false;
            }
            //מטעין מספר ספרים בהשאלה
            try
            {
                this.myMember.NumBooksForlending = Convert.ToInt32(txtNumBooks.Text);
            }
            catch (Exception ex)
            {
                errop1.SetError(txtNumBooks, ex.Message);
                ok = false;
            }
            //מטעין תעודת זהות
            try
            {
                this.myMember.IsraelId = txtIsralId.Text;
            }
            catch (Exception ex)
            {
                errop1.SetError(txtIsralId, ex.Message);
                ok = false;
            }


            return ok;
        }
        //בונה אובייקט ע"פ הערך שנבחר בקומבו בוקס
        public void FillFieldsByObject()
        {
            lblMemberId.Text = Convert.ToString(this.myMember.MemberId);
            txtMemberFN.Text = Convert.ToString(this.myMember.FirstNameMember);
            txtMemberLN.Text = Convert.ToString(this.myMember.LastNameMember);
            txtMemberStreet.Text = Convert.ToString(this.myMember.Street);
            txtMemberNamHouse.Text = Convert.ToString(this.myMember.HomeNumber);
            txtMemberCity.Text = Convert.ToString(this.myMember.City);
            txtMemberPhon1.Text = Convert.ToString(this.myMember.PhonA);
            txtMemberPhon2.Text = Convert.ToString(this.myMember.PhonB);
            cmbYear.Text = Convert.ToString(this.myMember.BirthDay.Year);
            cmbMonth.Text = Convert.ToString(this.myMember.BirthDay.Month);
            cmbDay.Text = Convert.ToString(this.myMember.BirthDay.Day);
            txtNumBooks.Text = Convert.ToString(this.myMember.NumBooksForlending);
            txtIsralId.Text = Convert.ToString(this.myMember.IsraelId);
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (BuildObjectByFields())
            {
                DataRow myRow = this.myMember.BuildRow();
                if (statusFrm == statusKind.add)
                {
                    if (this.myMembersTable.Add(myRow))
                    {
                        MessageBox.Show("המנוי התווסף בהצלחה");
                        if (myFrmFinishLending!=null) {isFinishClick=true; myFrmFinishLending.newMemberId = myMember.MemberId; this.Close(); }
                    }
                    else
                        MessageBox.Show("המנוי כבר קיים ");
                    lblAdd.Text = "הוספת מנוי חדש";
                    lblMemberId.Text = Convert.ToString(myMembersTable.GetNextKod());
                    cmbChhoseMember.Visible = false;
                    lblChooseMember.Visible = false;
                    clearFrm();

                }
                else
                    if (statusFrm == statusKind.update)
                    {
                        if (this.myMembersTable.Update(myRow))
                            MessageBox.Show("המנוי עודכן בהצלחה");
                        else
                            MessageBox.Show("המנוי לא קיים במאגר");
                        lblAdd.Text = "עדכון מנוי";
                        cmbChhoseMember.Visible = true;
                        cmbChhoseMember.DataSource = myMembersTable.GetTable();
                        cmbChhoseMember.DisplayMember = "firstNameMember";
                        cmbChhoseMember.ValueMember = "MemberId";
                        grpMemberDetails.Enabled = false;
                        cmbChhoseMember.Text = "-בחר מנוי לעדכון-";

                        btnAdd.Text = "עדכן מנוי ";
                        clearFrm();

                    }
                 else
                     if (statusFrm == statusKind.delete)
                        {
                            if (this.myMembersTable.Delete(myRow))
                                MessageBox.Show("המנוי נמחק בהצלחה");
                            else
                                MessageBox.Show("המנוי לא קיים במאגר");
                            lblAdd.Text = "מחיקת מנוי";
                            cmbChhoseMember.Visible = true;
                            cmbChhoseMember.DataSource = myMembersTable.GetTable();
                            cmbChhoseMember.DisplayMember = "firstNameMember";
                            cmbChhoseMember.ValueMember = "MemberId";
                            grpMemberDetails.Enabled = false;
                            cmbChhoseMember.Text = "-בחר מנוי למחיקה-";

                            btnAdd.Text = "מחק מנוי ";
                            clearFrm();
                     }
            }
        }

        
        //תקינות קלט
        private void txtMemberFN_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            string hebrowTav = "אבגדהוזחטיכלמנסעפצקרשתםןךץף";
            if (hebrowTav.IndexOf(c) == -1 && c != ' ' && c != '\b')
            { e.Handled = true; Console.Beep(); }
            
        }

        private void txtMemberLN_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            string hebrowTav = "אבגדהוזחטיכלמנסעפצקרשתםןךץף";
            if (hebrowTav.IndexOf(c) == -1 && c != ' ' && c != '\b')
            { e.Handled = true; Console.Beep(); }
            
        }

        private void txtMemberStreet_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            string hebrowTav = "אבגדהוזחטיכלמנסעפצקרשתםןךץף";
            if (hebrowTav.IndexOf(c) == -1 && c != ' ' && c != '\b')
            { e.Handled = true; Console.Beep(); }
        }

        private void txtMemberNamHouse_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if ((c >= '0' && c <= '9') || c == '\b') e.Handled = false;
            else { e.Handled = true; Console.Beep(); }
        }

        private void txtMemberCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            string hebrowTav = "אבגדהוזחטיכלמנסעפצקרשתםןךץף";
            if (hebrowTav.IndexOf(c) == -1 && c != ' ' && c != '\b')
            { e.Handled = true; Console.Beep(); }
        }

        private void txtMemberPhon1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (((txtMemberPhon1.Text.Length < 10) &&(c >= '0' && c <= '9')) || c == '\b')  e.Handled = false;
            else { e.Handled = true; Console.Beep(); }
            
        }

        private void txtMemberPhon2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            char c = e.KeyChar;
            if (((txtMemberPhon2.Text.Length < 10) && (c >= '0' && c <= '9')) || c == '\b') e.Handled = false;
            else { e.Handled = true; Console.Beep(); }
        }

        private void txtNumBooks_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if ((c >= '0' && c <= '9') || c == '\b') e.Handled = false;
            else { e.Handled = true; Console.Beep(); }
        }

        private void cmbChhoseMember_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int memberId = Convert.ToInt32(cmbChhoseMember.SelectedValue);
            DataRow dr = myMembersTable.find(memberId);
            this.myMember = new Members(dr);
            grpMemberDetails.Enabled = true;
            btnAdd.Enabled = true;
            if (statusFrm == statusKind.show)
            { btnAdd.Visible = false; btnNext.Visible = true; }
            FillFieldsByObject();

        }
        public void clearFrm()
        {
            lblMemberId.Text =Convert.ToString( myMembersTable.GetNextKod());
            txtMemberFN.Text = "";
            txtMemberLN.Text = "";
            txtMemberNamHouse.Text = "";
            txtMemberCity.Text = "";
            txtMemberStreet.Text = "";
            txtMemberPhon1.Text = "";
            txtMemberPhon2.Text = "";
            txtNumBooks.Text = "";
            cmbYear.Text = "";
            cmbMonth.Text = "";
            cmbDay.Text = "";
            txtIsralId.Text = "";
            cmbChhoseMember.SelectedValue = -1;
            cmbChhoseMember.Text = "בחר מנוי";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int memberId = Convert.ToInt32(cmbChhoseMember.SelectedValue);
            DataRow dr = myMembersTable.find(memberId);
            this.myMember = new Members(dr);
            grpMemberDetails.Enabled = true;
            btnAdd.Enabled = true;
            if (statusFrm == statusKind.show) btnAdd.Visible = false;
            FillFieldsByObject();
        }

        private void btnLending_Click(object sender, EventArgs e)
        {
            if (BuildObjectByFields())
            {
                DataRow myRow = this.myMember.BuildRow();
                if (statusFrm == statusKind.add)
                {
                    if (this.myMembersTable.Add(myRow))
                    {
                        MessageBox.Show("המנוי התווסף בהצלחה");
                        if (myFrmFinishLending != null) { myFrmFinishLending.newMemberId = myMember.MemberId; this.Close(); }
                    }
                    else
                        MessageBox.Show("המנוי כבר קיים ");
                    lblAdd.Text = "הוספת מנוי חדש";
                    lblMemberId.Text = Convert.ToString(myMembersTable.GetNextKod());
                    cmbChhoseMember.Visible = false;
                    lblChooseMember.Visible = false;
                    clearFrm();
                }

                FrmFinishLending f = new FrmFinishLending(Convert.ToInt32(lblMemberId.Text));
                f.Show();
            }
        }

        private void txtIsralId_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (((txtIsralId.Text.Length < 9) && (c >= '0' && c <= '9')) || c == '\b') e.Handled = false;
            else { e.Handled = true; Console.Beep(); }

        }

        private void FrmMember_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(this.myFrmFinishLending!=null)
                if(isFinishClick==false) myFrmFinishLending.newMemberId = 0;
        }
    }
}
