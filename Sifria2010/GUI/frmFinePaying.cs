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
    public partial class frmFinePaying : Form
    {
        private FinePaying myFinePaying;
        private FinePayingTable myFinePayingTable;
        private MembersTable myMembersTable;
        private statusKind statusFrm;
        int sunMemberFine = 0;
        int LastestSumFine = 0;
        int myMemberId = 0;
        int myPayId = 0;
        DateTime myDateTime=new DateTime(2000,10,10);
        private int memberIdUsingWhenFrmFinishLendinghOpenThisFrm = 0;
        public frmFinePaying(statusKind F)
        {
            InitializeComponent();
            this.myFinePayingTable = new FinePayingTable();
            this.statusFrm = F;
            myMembersTable = new MembersTable();
        }

        public frmFinePaying(statusKind F,int memberId1)
        {
            InitializeComponent();
            this.myFinePayingTable = new FinePayingTable();
            this.statusFrm = F;
            myMembersTable = new MembersTable();
            memberIdUsingWhenFrmFinishLendinghOpenThisFrm = memberId1;
        }

        private void frmFinePaying_Load(object sender, EventArgs e)
        {
            if (statusFrm == statusKind.add)
            {
                lblDate.Text = Convert.ToString(DateTime.Today.Day) + "/" + Convert.ToString(DateTime.Today.Month) + "/" + Convert.ToString(DateTime.Today.Year);
                lblCode.Text = Convert.ToString(myFinePayingTable.GetNextKod());
                cmbMembers.DataSource = myMembersTable.GetTableForCombobox("firstNameMember", "lastNameMember");
                cmbMembers.DisplayMember = "fullName";
                cmbMembers.ValueMember = "memberId";
                cmbMembers.Text = "בחר או הקש קוד מנוי";
                lblSumFineUpdate.Visible = false;
                txtSumFineNew.Visible = false;
                dgvUpdateDetail.Visible = false;
                lblUpdate.Visible = false;
                if (memberIdUsingWhenFrmFinishLendinghOpenThisFrm != 0)
                {
                    cmbMembers.SelectedValue = memberIdUsingWhenFrmFinishLendinghOpenThisFrm;
                    btnNext.Enabled = true;

                }
            }
            else if (statusFrm == statusKind.update)
            {
                dgvUpdateDetail.Visible = true;
                string st = "SELECT finePaying.payId, members.memberId, members.firstNameMember, members.lastNameMember, finePaying.payingDate, finePaying.sumFine FROM members INNER JOIN finePaying ON members.memberId = finePaying.memberId; ";
                DataTable dt = DAL.DAL.GetQuery(st);
                dgvUpdateDetail.DataSource = dt;
                dgvUpdateDetail.Columns[0].HeaderText = "קוד תשלום";
                dgvUpdateDetail.Columns[1].HeaderText = "קוד מנוי";
                dgvUpdateDetail.Columns[2].HeaderText = "שם פרטי מנוי";
                dgvUpdateDetail.Columns[3].HeaderText = "שם משפחה מנוי";
                dgvUpdateDetail.Columns[4].HeaderText = "תאריך תשלום הקנס";
                dgvUpdateDetail.Columns[5].HeaderText = "סכום תשלום הקנס";
                panel1.Visible = false;
                
                lblSumFineUpdate.Visible = true;
                txtSumFineNew.Visible = true;
                lblSumFineUpdate.Enabled = false;
                txtSumFineNew.Enabled = false;
                btnFinish.Enabled = false;
            }

        }

        

        private void txtPayingSum_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if ((c >= '0' && c <= '9') || c == '\b') e.Handled = false;
            else { e.Handled = true; Console.Beep(); }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
                if (statusFrm == statusKind.add)
                {
                    if (buildObjectByFields())
                    {
                        DataRow myRow = this.myFinePaying.BuildRow();
                        if (this.myFinePayingTable.Add(myRow))
                         {
                        
                            DataRow myMember = myMembersTable.find(cmbMembers.SelectedValue);
                            myMember["fine"] = Convert.ToInt32 (myMember["fine"]) - Convert.ToInt32(txtPayingSum.Text);
                            if (this.myMembersTable.Update(myMember))
                                MessageBox.Show("החוב שולם");
                            else MessageBox.Show("לא נמצא מנוי או שאין למנוי חוב");
                        }
                        else
                            MessageBox.Show("לא נמצא חוב");
                            cmbMembers.Text = "-בחר או הקש קוד מנוי-";
                            btnNext.Enabled = false;
                            txtPayingSum.Text = "";
                            lblCode.Text = Convert.ToString(myFinePayingTable.GetNextKod());
                            grbDetails.Enabled = false;
                            btnFinish.Enabled = false;
                
                    
                    }
                }
               else if (statusFrm == statusKind.update)
                {
                    DataRow myMember = myMembersTable.find(myMemberId);
                    myMember["fine"] = sunMemberFine + LastestSumFine; 
                        
                    if (buildObjectByFields())
                    {
                        DataRow myRow = this.myFinePaying.BuildRow();
                        if (this.myFinePayingTable.Update(myRow))
                        {
                            myMember["fine"] = Convert.ToInt32(myMember["fine"]) - Convert.ToInt32(txtSumFineNew.Text);
                            if (this.myMembersTable.Update(myMember))
                            {
                                MessageBox.Show("החוב שולם");
                                
                            }
                            else MessageBox.Show("לא נמצא מנוי או שאין למנוי חוב");

                        }
                        string st = "SELECT finePaying.payId, members.memberId, members.firstNameMember, members.lastNameMember, finePaying.payingDate, finePaying.sumFine FROM members INNER JOIN finePaying ON members.memberId = finePaying.memberId; ";
                        DataTable dt = DAL.DAL.GetQuery(st);
                        dgvUpdateDetail.DataSource = dt;
                        lblSumFineUpdate.Enabled = false;
                        txtSumFineNew.Text = "";
                        txtSumFineNew.Enabled = false;
                        btnFinish.Enabled = false;
                    }
                   
                }
            }
            
        
       

        public bool buildObjectByFields()
        {
            bool ok = true;
            errorp1.Clear();
            myFinePaying = new FinePaying();
            if (statusFrm == statusKind.add)
            {
                try
                {
                    myFinePaying.MemberId = Convert.ToInt32(cmbMembers.SelectedValue);
                }
                catch (Exception ex)
                {
                    errorp1.SetError(cmbMembers, ex.Message);
                    ok = false;
                }
                try
                {
                    myFinePaying.PayId = Convert.ToInt32(lblCode.Text);
                }
                catch (Exception ex)
                {
                    errorp1.SetError(lblCode, ex.Message);
                    ok = false;
                }
                try
                {
                    myFinePaying.SumFine = Convert.ToInt32(txtPayingSum.Text);
                }
                catch (Exception ex)
                {
                    errorp1.SetError(txtPayingSum, ex.Message);
                    ok = false;
                }
                myFinePaying.PayingDate = Convert.ToDateTime(lblDate.Text);
            }
            else if (statusFrm == statusKind.update)
            {
                try
                {
                    myFinePaying.MemberId = myMemberId;
                }
                catch (Exception ex)
                {
                    errorp1.SetError(dgvUpdateDetail, ex.Message);
                    ok = false;
                }
            
                try
                {
                    myFinePaying.PayId = myPayId;
                }
                catch (Exception ex)
                {
                    errorp1.SetError(dgvUpdateDetail, ex.Message);
                    ok = false;
                }
                try
                {
                    
                    myFinePaying.SumFine = Convert.ToInt32(txtSumFineNew.Text);
                }
                catch (Exception ex)
                {
                    errorp1.SetError(txtSumFineNew, ex.Message);
                    ok = false;
                }
            myFinePaying.PayingDate = myDateTime;
            }

               
            return ok;
        }

        public bool checkIfTheMemberHaveFine(int memberId)
        {
            DataRow dr = myMembersTable.find(cmbMembers.SelectedValue);
            if (Convert.ToInt32(dr["fine"]) > 0) { sunMemberFine = Convert.ToInt32(dr["fine"]); return true; }
            else return false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            if (cmbMembers.SelectedValue == null)
                MessageBox.Show("לא נבחר מנוי");
            else
            {
                int i = Convert.ToInt32(cmbMembers.SelectedValue);
                if (checkIfTheMemberHaveFine(i))
                { grbDetails.Enabled = true; btnFinish.Enabled = true; }
                else MessageBox.Show("למנוי לא נמצא חובות");
            }
            
        }

        private void cmbMembers_SelectionChangeCommitted(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
        }

       

        

        private void txtSumFineNew_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if ((c >= '0' && c <= '9') || c == '\b') e.Handled = false;
            else { e.Handled = true; Console.Beep(); }
        }



        private void dgvUpdateDetail_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selectedRow = e.RowIndex;
            int countRows = dgvUpdateDetail.Rows.Count;
            if (selectedRow != countRows - 1)
            {
                lblSumFineUpdate.Enabled = true;
                txtSumFineNew.Enabled = true;
                btnFinish.Enabled = true;

                myMemberId = Convert.ToInt32(dgvUpdateDetail.Rows[e.RowIndex].Cells["memberId"].Value);
                LastestSumFine = Convert.ToInt32(dgvUpdateDetail.Rows[e.RowIndex].Cells["sumFine"].Value);
                DataRow myMemberRow = myMembersTable.find(myMemberId);
                sunMemberFine = Convert.ToInt32(myMemberRow["fine"]);
                myDateTime = Convert.ToDateTime(dgvUpdateDetail.Rows[e.RowIndex].Cells["payingDate"].Value);
                myPayId = Convert.ToInt32(dgvUpdateDetail.Rows[e.RowIndex].Cells["payId"].Value);
            }
            else
            {
                MessageBox.Show("עליך לבחור שורה מלאה");
                lblSumFineUpdate.Enabled = false;
                txtSumFineNew.Enabled = false;
                btnFinish.Enabled = false;
            } 
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
