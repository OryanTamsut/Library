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
    public partial class FrmFinishLending : Form
    {
        private MembersTable myMemberTable;
        private Members myMember;
        private BooksTable myBooksTable;
        private CopiesTable myCopyTable;
        private Lending myLending;
        private LendingTable myLendingTable;
        private CopiesInLending myCopiesInLending;
        private CopiesInLendingTable myCopiesInLendingTable;
        private Information myInformation;
        private InformationTable myInformationTable;
        int lendingId = 0;
        int selectedRow = 0;
        int memberSelectedId = 0;
        public int newMemberId = 0;
        public FrmMember myFrmMembers;
        bool isBtnPayNilchats = false;
        //קוד מנוי שמתקבל ע"י הטופס הוספת מנוי
        int memberId = 0;
        public FrmFinishLending()
        {
            InitializeComponent();
            myLendingTable = new LendingTable();
            myCopiesInLendingTable = new CopiesInLendingTable();
            myInformationTable = new InformationTable();
            myInformation = new Information( myInformationTable.find(1));
            myMemberTable = new MembersTable();
            myCopyTable = new CopiesTable();
            myBooksTable = new BooksTable();
        }

        public FrmFinishLending(int memberId1)
        {
            InitializeComponent();
            myLendingTable = new LendingTable();
            myCopiesInLendingTable = new CopiesInLendingTable();
            myInformationTable = new InformationTable();
            myInformation = new Information(myInformationTable.find(1));
            myMemberTable = new MembersTable();
            myCopyTable = new CopiesTable();
            myBooksTable = new BooksTable();

            memberId = memberId1;
            rdbCmb.Checked = true;
            btnNext.Enabled = true;
        }


        private void Lending_Load(object sender, EventArgs e)
        {
            grbAll.Enabled = false;
            grbLending.Enabled = false;
            grbReturning.Enabled = false;
            cmbChooseMember.DataSource = myMemberTable.GetTableForCombobox("firstNameMember", "lastNameMember");
            cmbChooseMember.DisplayMember = "fullName";
            cmbChooseMember.ValueMember = "memberId";
            cmbChooseMember.Text = "בחר מנוי";
            if (memberId > 0) cmbChooseMember.SelectedValue = memberId-1;
            btnFinishReturing.Enabled = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            grbAll.Enabled = true;
            if (rdbCmb.Checked == true)
            {
                label2.Text = "הספרים שברשות המנוי";
                dgvMembersBooks.DataSource = getDataSourceForDgv(Convert.ToInt32(cmbChooseMember.SelectedValue));
                dgvMembersBooks.Columns[0].HeaderText = "שם ספר";
                dgvMembersBooks.Columns[1].HeaderText = "שם סופר";
                dgvMembersBooks.Columns[2].HeaderText = "קוד ספר";
                dgvMembersBooks.Columns[3].HeaderText = "קוד עותק";
                dgvMembersBooks.Columns[4].Visible = false;
                dgvMembersBooks.Columns[5].Visible = false;
                if (dgvMembersBooks.Rows.Count == 1) { grbLending.Enabled = true; }
                else if (dgvMembersBooks.Rows.Count - 1 <= Convert.ToInt32(myMember.NumBooksForlending)) { grbLending.Enabled = true; grbReturning.Enabled = true; }
                else if (dgvMembersBooks.Rows.Count - 1 == Convert.ToInt32(myMember.NumBooksForlending)) { grbReturning.Enabled = true; }
                else if (dgvMembersBooks.Rows.Count - 1 > Convert.ToInt32(myMember.NumBooksForlending)) { grbReturning.Enabled = true; }
                label2.Text += " " + Convert.ToString(myMemberTable.find(cmbChooseMember.SelectedValue)["firstNameMember"]);
                memberSelectedId = Convert.ToInt32 (cmbChooseMember.SelectedValue);
                isMemberHavePreviousFine(memberSelectedId);
            }
            else if (rdbTxt.Checked == true)
                if (myMemberTable.find(Convert.ToInt32(txtCode.Text)) != null)
                {
                 label2.Text = "הספרים שברשות המנוי";
                dgvMembersBooks.DataSource = getDataSourceForDgv(Convert.ToInt32(txtCode.Text));
                dgvMembersBooks.Columns[0].HeaderText = "שם ספר";
                dgvMembersBooks.Columns[1].HeaderText = "שם סופר";
                dgvMembersBooks.Columns[2].HeaderText = "קוד ספר";
                dgvMembersBooks.Columns[3].HeaderText = "קוד עותק";
                dgvMembersBooks.Columns[4].Visible = false;
                dgvMembersBooks.Columns[5].Visible = false;
                if (dgvMembersBooks.Rows.Count == 1) { grbLending.Enabled = true; }
                else if (dgvMembersBooks.Rows.Count - 1 <= Convert.ToInt32(myMember.NumBooksForlending)) { grbLending.Enabled = true; grbReturning.Enabled = true; }
                else if (dgvMembersBooks.Rows.Count - 1 == Convert.ToInt32(myMember.NumBooksForlending)) { grbReturning.Enabled = true; }
                else if (dgvMembersBooks.Rows.Count - 1 > Convert.ToInt32(myMember.NumBooksForlending)) { grbReturning.Enabled = true; }
                    label2.Text +=" "+ Convert.ToString(myMemberTable.find(Convert.ToInt32(txtCode.Text))["firstNameMember"]);
                    memberSelectedId = Convert.ToInt32 (txtCode.Text);
                    isMemberHavePreviousFine(memberSelectedId);
                }
                else
                    MessageBox.Show("קוד מנוי לא תקין, לא נמצא מנוי");
            
        }
        public DataTable getDataSourceForDgv(int memberId)
        {
            string st = "SELECT books.bookName, writers.writerName, books.bookId, copies.copyId, copies.rowId, copiesInLending.lendingId FROM writers INNER JOIN (lending INNER JOIN ((books INNER JOIN copies ON books.bookId = copies.bookId) INNER JOIN copiesInLending ON copies.rowId = copiesInLending.copyId) ON lending.lendingId = copiesInLending.lendingId) ON writers.writerId = books.writerId WHERE (((copies.rowId)=[copiesInLending].[copyId]) AND ((copiesInLending.returnDate)=#1/1/2000#) AND ((lending.memberId)="+memberId+")); ";
            DataTable dt = DAL.DAL.GetQuery(st);
            return dt;

        }

        private void cmbChooseMember_SelectionChangeCommitted(object sender, EventArgs e)
        {
            myMember =new Members( myMemberTable.find(cmbChooseMember.SelectedValue));
            btnShowMemberDetails.Visible = true;
            btnNext.Enabled = true;
           
        }

       

        private void btnFinishReturing_Click(object sender, EventArgs e)
        {
          lendingId = Convert.ToInt32( dgvMembersBooks.Rows[this.selectedRow].Cells["lendingId"].Value);
          DataRow dr = myCopiesInLendingTable.find(lendingId);
            CreateDrToReturn(dr);
            if (this.myCopiesInLendingTable.Update(dr))
               
                MessageBox.Show("הספר הוחזר לספרייה");
            else
                MessageBox.Show("הספר לא קיים במאגר");

            refreshFrm();
            
        }

        private void dgvMembersBooks_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvMembersBooks.Rows.Count == 1) { grbLending.Enabled = true; }
            else if (dgvMembersBooks.Rows.Count - 1 <= Convert.ToInt32(myMember.NumBooksForlending)) { grbLending.Enabled = true; grbReturning.Enabled = true; }
            else if (dgvMembersBooks.Rows.Count - 1 == Convert.ToInt32(myMember.NumBooksForlending)) { grbReturning.Enabled = true; }
            else if (dgvMembersBooks.Rows.Count - 1 > Convert.ToInt32(myMember.NumBooksForlending)) { grbReturning.Enabled = true; grbLending.Enabled = false; }
            this.selectedRow = e.RowIndex;
           
            int countRows = dgvMembersBooks.Rows.Count;
            if (selectedRow != countRows - 1)
            {
                lendingId = Convert.ToInt32(dgvMembersBooks.Rows[this.selectedRow].Cells["lendingId"].Value);
                


                DataRow dr = myCopiesInLendingTable.find(lendingId);
                panel2.Visible = true;
                btnFinishReturing.Enabled = true;
                btnLosingBook.Enabled = true;
                int dayPassedSinceLending = (DateTime.Today.Year - Convert.ToDateTime(dr["lendingDate"]).Year) * 365 + (DateTime.Today.Month - Convert.ToDateTime(dr["lendingDate"]).Month) * 29 + (DateTime.Today.Day - Convert.ToDateTime(dr["lendingDate"]).Day);

                if (dayPassedSinceLending > myInformation.MaxDaysLending)
                {
                    txtFineForDelay.Text = Convert.ToString((dayPassedSinceLending * myInformation.FinePriceForOneDay) / 100);
                    panel1.Visible = true;

                }
            }
            else { MessageBox.Show("עליך לבחור שורה מלאה"); grbReturning.Enabled = false;  }
            
        
        }
        private void txtFineForDefect_TextChanged(object sender, EventArgs e)
        {
            label3.Visible = true;
            txtInfoOfDefect.Visible = true;
            lblShach2.Visible = true;
            if (txtFineForDefect.Text != "") btnFineForDelayPaying.Enabled = true;
            else btnFineForDelayPaying.Enabled = false;
        }

        public void CreateDrToReturn(DataRow dr1)
        {
            DataRow myMember11 = myMemberTable.find(cmbChooseMember.SelectedValue);
            DataRow myMember12 = myMemberTable.find(cmbChooseMember.SelectedValue);
            DataRow drCopy = myCopyTable.find(dr1["copyId"]);
            DataRow drBook = myBooksTable.find(drCopy["bookId"]);
            int bookPrice = Convert.ToInt32(drBook["price"]);
            dr1["returnDate"] = DateTime.Today;
            if (txtFineForDefect.Text != "" && Convert.ToInt32(txtFineForDefect.Text) > 0)
                dr1["fineForDefect"] = Convert.ToInt32(txtFineForDefect.Text);
            if (txtInfoOfDefect.Text != "")
                dr1["infoOfDefect"] = txtInfoOfDefect.Text;
            if (chb1.Checked == true || isBtnPayNilchats == true)

                if (txtFineForDelay.Text != "" && Convert.ToInt32(txtFineForDelay.Text) > 0)
                    if (Convert.ToInt32(txtFineForDelay.Text) <= (double)myInformation.PrecentOfTheBookPriceForFine / 100 * bookPrice)
                        dr1["fineForDelay"] = Convert.ToInt32(txtFineForDelay.Text);
                    else dr1["fineForDelay"] = (double)myInformation.PrecentOfTheBookPriceForFine / 100 * bookPrice;
            if (Convert.ToInt32(dr1["fineForDeLay"]) > 0 || Convert.ToInt32(dr1["fineForDefect"]) > 0)
            {
                if (Convert.ToInt32(dr1["fineForDeLay"]) > 0)
                {

                    myMember11["fine"] = Convert.ToInt32(myMember11["fine"]) + Convert.ToInt32(dr1["fineForDeLay"]);
                }
                if (Convert.ToInt32(dr1["fineForDefect"]) > 0)
                {

                    myMember12["fine"] = Convert.ToInt32(myMember12["fine"]) + Convert.ToInt32(dr1["fineForDefect"]);
                }
                if (myMemberTable.Update(myMember11) && myMemberTable.Update(myMember12))
                {
                    int sumFine = Convert.ToInt32(dr1["fineForDefect"]) + Convert.ToInt32(dr1["fineForDeLay"]);
                    MessageBox.Show(sumFine + " עודכן למנוי חוב על סך ");
                }
            }
        }
        //למקרה של החזרה עקיפה
        public void CreateDrToReturnAroundReturing(DataRow dr1)
        {
            //מוסיפים את החובות למנוי הקודם ולא לעכשווי
            DataRow myPreviousMember = myMemberTable.find (myLendingTable.find(dr1["lendingId"])["memberId"]);
            DataRow myMember11 = myPreviousMember;
            DataRow myMember12 = myPreviousMember;
            DataRow drCopy = myCopyTable.find(dr1["copyId"]);
            DataRow drBook = myBooksTable.find(drCopy["bookId"]);
            int bookPrice = Convert.ToInt32(drBook["price"]);
            dr1["returnDate"] = DateTime.Today;
            //בהחזרה עקיפה השורה הנ"ל אף פעם לא תתבצע כי זה לא הוגן שמנוי שלא החזיר דרך הספרייה יהיה לו קנס של איחור אעפ שהחזיר בזמן רק לא דרך המערכת 
            if (chb1.Checked == true || isBtnPayNilchats == true)
                if (txtFineForDelay.Text != "" && Convert.ToInt32(txtFineForDelay.Text) > 0)
                    if (Convert.ToInt32(txtFineForDelay.Text) <= (double)myInformation.PrecentOfTheBookPriceForFine / 100 * bookPrice)
                        dr1["fineForDelay"] = Convert.ToInt32(txtFineForDelay.Text);
                    else dr1["fineForDelay"] = (double)myInformation.PrecentOfTheBookPriceForFine / 100 * bookPrice;
            if (Convert.ToInt32(dr1["fineForDeLay"]) > 0)
            {

                myMember11["fine"] = Convert.ToInt32(myMember11["fine"]) + Convert.ToInt32(dr1["fineForDeLay"]);
            }
            if (Convert.ToInt32(dr1["fineForDefect"]) > 0)
            {

                myMember12["fine"] = Convert.ToInt32(myMember12["fine"]) + Convert.ToInt32(dr1["fineForDefect"]);
            }
            if (myMemberTable.Update(myMember11) && myMemberTable.Update(myMember12))
            {
                int sumFine = Convert.ToInt32(dr1["fineForDefect"]) + Convert.ToInt32(dr1["fineForDeLay"]);
                MessageBox.Show(sumFine + " עודכן למנוי חוב על סך ");
            }

        }

        private void btnFinishLending_Click(object sender, EventArgs e)
        {
            int memberId = Convert.ToInt32(cmbChooseMember.SelectedValue);
            int copyId= Convert.ToInt32(cmbChhoseCopy.SelectedValue); 
            if (isLoanExtention(memberId, copyId) == false)
            {
                if (doingWhenBookIsLending())
                {
                    buildObjectByFields();
                    DataRow myCopiesInLendingRow = this.myCopiesInLending.BuildRow();
                    DataRow myLendingRow = this.myLending.BuildRow();
                    if (this.myLendingTable.Add(myLendingRow))
                    {
                        if (this.myCopiesInLendingTable.Add(myCopiesInLendingRow))

                            MessageBox.Show("הספר הושאל בהצלחה");
                    }
                    else MessageBox.Show("הספר לא הושאל שגיאה");
                    refreshFrm();
                }
            }
        }

        public void buildObjectByFields()
        {
            myLending = new Lending();
            myCopiesInLending = new CopiesInLending();
            myCopiesInLending.LendingId = myLendingTable.GetNextKod();
            myCopiesInLending.CopyId = Convert.ToInt32 (cmbChhoseCopy.SelectedValue);
            myCopiesInLending.LendingDate = DateTime.Today;
            myLending.LendingId = myCopiesInLending.LendingId;
            myLending.MemberId = Convert.ToInt32 (cmbChooseMember.SelectedValue);
            myLending.LendingDate = DateTime.Today;
            myCopiesInLending.ReturnDate = new DateTime(2000,01,01);
        
        }

        private void btnNextLending_Click(object sender, EventArgs e)
        {
            if (myBooksTable.find(Convert.ToInt32(txtBookIdLending.Text)) == null)
            {
                MessageBox.Show("לא קיים ספר כזה, עליך להזין קוד ספר שקיים במערכת");
                txtBookIdLending.Text = "";
            }
            else
            {
                DataRow myMember = myMemberTable.find(cmbChooseMember.SelectedValue);
                int myMemberAge = Convert.ToInt32(DateTime.Today.Year) - Convert.ToInt32(Convert.ToDateTime(myMember["birthDay"]).Year);
                DataRow myBookRow = myBooksTable.find(Convert.ToInt32(txtBookIdLending.Text));
                if (Convert.ToInt32(myBookRow["fromAge"]) > myMemberAge)
                {
                    DialogResult answer3 = MessageBox.Show("?ספר זה אינו תואם לגיל המנוי, האם תרצה להמשיך בכל אופן", "", MessageBoxButtons.YesNo);
                    if (answer3 == DialogResult.Yes)
                    {
                        string st = "SELECT copies.copyId, copies.rowId FROM copies WHERE (((copies.bookId)=" + txtBookIdLending.Text + ")); ";
                        DataTable dt = DAL.DAL.GetQuery(st);
                        cmbChhoseCopy.DataSource = dt;
                        cmbChhoseCopy.DisplayMember = "copyId";
                        cmbChhoseCopy.ValueMember = "rowId";
                        cmbChhoseCopy.Visible = true;
                        lblChooseCopy.Visible = true;
                        btnNextLending.Visible = false;

                    }
                    else
                        if (answer3 == DialogResult.No)
                        {
                            MessageBox.Show("אין אפשרות להשאיל ספר זה, בחר ספר אחר");
                            txtBookIdLending.Text = "";
                        }
                }


                 else
                {
                    string st = "SELECT copies.rowId, copies.copyId FROM copies WHERE(((copies.bookId) ="+txtBookIdLending.Text+") AND((copies.status) = True));";
                    DataTable dt = DAL.DAL.GetQuery(st);
                    cmbChhoseCopy.DataSource = dt;
                    cmbChhoseCopy.DisplayMember = "copyId";
                    cmbChhoseCopy.ValueMember = "rowId";
                    cmbChhoseCopy.Visible = true;
                    lblChooseCopy.Visible = true;
                    btnNextLending.Visible = false;
                }
            }
        }
        private void cmbChhoseCopy_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            btnFinishLending.Enabled = true;
            
            
        }
   
        public bool checkIsBookLending(int rowId)
        {
            string st = "SELECT copies.rowId FROM copies INNER JOIN copiesInLending ON copies.rowId = copiesInLending.copyId WHERE (((copiesInLending.returnDate)=#1/1/2000#) AND ((copies.rowId)="+rowId+")); ";
            DataTable dt = DAL.DAL.GetQuery(st);
            if(dt.Rows.Count>0)
            return true;
            return false;
        }
        public bool doingWhenBookIsLending()
        {
            int i = Convert.ToInt32(cmbChhoseCopy.SelectedValue);
            if (checkIsBookLending(i))
            {
                DialogResult answer = MessageBox.Show("?ספר זה כבר מושאל אצל מנוי אחר, האם ברצונך לבצע לו החזרה", "שגיאה", MessageBoxButtons.YesNo);
                if (answer == DialogResult.Yes)
                {
                    
                    DataRow dr = myCopiesInLendingTable.getRowIdByCopyIdDateReturing(Convert.ToInt32(cmbChhoseCopy.SelectedValue));
                    int dayPassedSinceLending = (DateTime.Today.Year - Convert.ToDateTime(dr["lendingDate"]).Year) * 365 + (DateTime.Today.Month - Convert.ToDateTime(dr["lendingDate"]).Month) * 29 + (DateTime.Today.Day - Convert.ToDateTime(dr["lendingDate"]).Day);

                    if (dayPassedSinceLending > myInformation.MaxDaysLending)
                    {
                        txtFineForDelay.Text = Convert.ToString((dayPassedSinceLending * myInformation.FinePriceForOneDay) / 100);
                        panel1.Visible = true;
                        panel1.Enabled = true;
                    }
                    DialogResult answer2=  MessageBox.Show("?האם ברצונך להוסיף מידע על פגם שנעשה בספר", "", MessageBoxButtons.YesNo,MessageBoxIcon.None,MessageBoxDefaultButton.Button1);
                    if (answer2 == DialogResult.No)
                    {
                        CreateDrToReturn(dr);
                        dr["lendingNote"] = "התבצעה החזרה עקיפה";
                        //מכניס קנס אם קיים למנוי שהספר שייך לו והתבצעה לו החזרה עקיפה
                        int lendingId = Convert.ToInt32(dr["lendingId"]);
                        DataRow myLendingRow = myLendingTable.find(lendingId);
                        DataRow myMemberLending = myMemberTable.find(Convert.ToInt32(myLendingRow["memberId"]));
                        if (txtFineForDelay.Text != "")
                        {
                            myMemberLending["fine"] = Convert.ToInt32(txtFineForDelay.Text);
                            dr["fineForDelay"] = Convert.ToInt32(txtFineForDelay.Text);
                        }
                        
                        if (this.myMemberTable.Update(myMemberLending))
                        {
                            if (this.myCopiesInLendingTable.Update(dr))
                                MessageBox.Show("הספר הוחזר לספרייה");
                            else
                                MessageBox.Show("הספר לא קיים במאגר");
                        }
                        return true;
                    }

                    else if (answer2 == DialogResult.Yes)
                    {
                        panel2.Visible = false;
                        
                        frmEzerLendingReturing f = new frmEzerLendingReturing(dr);
                        f.ShowDialog();
                        CreateDrToReturnAroundReturing(dr);
                        dr["lendingNote"] = "התבצעה החזרה עקיפה";
                        //מכניס קנס אם קיים למנוי שהספר שייך לו והתבצעה לו החזרה עקיפה
                        int lendingId = Convert.ToInt32(dr["lendingId"]);
                        DataRow myLendingRow = myLendingTable.find(lendingId);
                        DataRow myMemberLending = myMemberTable.find(Convert.ToInt32(myLendingRow["memberId"]));
                        if (txtFineForDelay.Text != "")
                        { 
                            dr["fineForDelay"] = Convert.ToInt32(txtFineForDelay.Text);
                            myMemberLending["fine"] = Convert.ToInt32(txtFineForDelay.Text) + Convert.ToInt32(dr["fineForDefect"]);
                        }
                         
                        if (this.myCopiesInLendingTable.Update(dr))
                        {
                            
                            if (this.myMemberTable.Update(myMemberLending))
                                MessageBox.Show("הספר הוחזר לספרייה");
                            else
                                MessageBox.Show("הספר לא קיים במאגר");
                        }
                        return true;
                    
                    }

                    
                }
                    
                else if (answer == DialogResult.No)
                {
                    MessageBox.Show("אין אפשרות לבצע השאלה, בחר ספר אחר");
                    txtBookIdLending.Text = "";
                    lblChooseCopy.Visible = false;
                    cmbChhoseCopy.Visible = false;
                    btnNextLending.Visible = true;
                    return false;
                }
            
            }

            return true;
        }
        
        private void btnAddMember_Click(object sender, EventArgs e)
        {
            myFrmMembers = new FrmMember(statusKind.add,this);
            myFrmMembers.ShowDialog();
           
            cmbChooseMember.DataSource = myMemberTable.GetTableForCombobox("firstNameMember", "lastNameMember");
            cmbChooseMember.DisplayMember = "fullName";
            cmbChooseMember.ValueMember = "memberId";
            if (newMemberId!=0) cmbChooseMember.SelectedValue = newMemberId;
        }

        private void txtBookIdLending_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if ((c >= '0' && c <= '9') || c == '\b') e.Handled = false;
            else { e.Handled = true; Console.Beep(); }
        }

        private void btnFineForDelayPaying_Click(object sender, EventArgs e)
        {
            isBtnPayNilchats = true;
            lendingId = Convert.ToInt32(dgvMembersBooks.Rows[this.selectedRow].Cells["lendingId"].Value);
            DataRow dr = myCopiesInLendingTable.find(lendingId);
            CreateDrToReturn(dr);
            myCopiesInLendingTable.Update(dr);
           // int memberId = Convert.ToInt32(cmbChooseMember.SelectedValue);
            frmFinePaying f = new frmFinePaying(statusKind.add,memberSelectedId);
            f.Show();
            refreshFrm();
        }

        private void btnLosingBook_Click(object sender, EventArgs e)
        {
            //מחזיר ספר לספרייה
            DataRow myCopyInlendingRow = myCopiesInLendingTable.find(Convert.ToInt32(dgvMembersBooks.Rows[this.selectedRow].Cells["lendingId"].Value));
            myCopyInlendingRow["returnDate"] = DateTime.Today;
            //מוסיף למנוי כחוב את מחיר הספר
            int myBookId=Convert.ToInt32 (dgvMembersBooks.Rows[selectedRow].Cells["bookId"].Value);
            int myCopyId = Convert.ToInt32(dgvMembersBooks.Rows[selectedRow].Cells["copyId"].Value);
            //מוצא את מחיר הספר
            int bookPrice = Convert.ToInt32(myBooksTable.find(myBookId)["price"]);
            DataRow myMemberChoosenRow = myMemberTable.find(memberSelectedId);
            myMemberChoosenRow["fine"] = Convert.ToInt32(myMemberChoosenRow["fine"]) + bookPrice;
            //עדכון תאריך החזרה וחוב על איבוד הספר
            if (myMemberTable.Update(myMemberChoosenRow)) MessageBox.Show(" עודכן למנוי חוב על סך " + bookPrice + " לפי מחיר הספר שאיבד");
            else MessageBox.Show("שגיאה בעדכון המנוי על חובו");
            if (!myCopiesInLendingTable.Update(myCopyInlendingRow))
                MessageBox.Show("שגיאה בהחזרת הספר לספרייה");
            //מרענן את הטופס כך שהספר שנמחק לא יופיע
            refreshFrm();
            frmCopies f = new frmCopies(statusKind.delete,myBookId,myCopyId);
            f.ShowDialog();
        }

        public void refreshFrm()
        {
            txtBookIdLending.Text = "";
            cmbChhoseCopy.Visible = false;
            btnNextLending.Visible = true;
            lblChooseCopy.Visible = false;
            btnFinishLending.Enabled = false;
            btnFinishReturing.Enabled = false;
            dgvMembersBooks.DataSource = getDataSourceForDgv(Convert.ToInt32(cmbChooseMember.SelectedValue));
            dgvMembersBooks.Columns[0].HeaderText = "שם ספר";
            dgvMembersBooks.Columns[1].HeaderText = "שם סופר";
            dgvMembersBooks.Columns[2].HeaderText = "קוד ספר";
            dgvMembersBooks.Columns[3].HeaderText = "קוד עותק";
            dgvMembersBooks.Columns[4].Visible = false;
            dgvMembersBooks.Columns[5].Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;
            
            if (dgvMembersBooks.Rows.Count == 1) { grbLending.Enabled = true; }
            else if (dgvMembersBooks.Rows.Count - 1 < Convert.ToInt32(myMember.NumBooksForlending)) { grbLending.Enabled = true; grbReturning.Enabled = true; }
            else if (dgvMembersBooks.Rows.Count - 1 == myMember.NumBooksForlending) { grbReturning.Enabled = true; }
            else if (dgvMembersBooks.Rows.Count - 1 > myMember.NumBooksForlending) { grbReturning.Enabled = true; grbLending.Enabled = false; }
            txtFineForDefect.Text = "";
            txtInfoOfDefect.Text = "";
            panel2.Visible = false;
            txtFineForDelay.Text = "";
            chb1.Checked = false;
            btnLosingBook.Enabled = false;
            
            btnFineForDelayPaying.Enabled = false;
        }

        private void txtInfoOfDefect_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            string hebrowTav = "אבגדהוזחטיכלמנסעפצקרשתםןךץף1234567890";
            if (hebrowTav.IndexOf(c) == -1 && c != ' ' && c != '\b')
            { e.Handled = true; Console.Beep(); }
        }

        private void txtFineForDelay_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if ((c >= '0' && c <= '9') || c == '\b') e.Handled = false;
            else { e.Handled = true; Console.Beep(); }
        }

        public bool isLoanExtention(int memberId,int copyRowId)
        {
            string st = "SELECT members.memberId, copiesInLending.copyId, copiesInLending.lendingDate, copiesInLending.returnDate FROM members INNER JOIN(lending INNER JOIN copiesInLending ON lending.lendingId = copiesInLending.lendingId) ON members.memberId = lending.memberId WHERE(((members.memberId) = "+memberId+") AND((copiesInLending.copyId) = "+copyRowId+"));";
            DataTable dt = DAL.DAL.GetQuery(st);
            dgvHelpingLoanExtention.DataSource = dt;
            int rowIndex = 0;
            if (dt.Rows.Count > 1)
            {
               DateTime lastLendingDate = Convert.ToDateTime (dgvHelpingLoanExtention.Rows[rowIndex].Cells["returnDate"].Value);
                int mone = 0;
                rowIndex++;


                foreach (DataRow myDr in dt.Rows)
                {
                    if (dgvHelpingLoanExtention.Rows[rowIndex].Cells["lendingDate"].Value!=null)
                    {
                        if (Convert.ToDateTime(dgvHelpingLoanExtention.Rows[rowIndex].Cells["lendingDate"].Value).Equals(lastLendingDate))
                        {
                            mone++;
                            lastLendingDate = Convert.ToDateTime(dgvHelpingLoanExtention.Rows[rowIndex].Cells["returnDate"].Value);
                        }
                        else
                        {
                            mone = 0;
                            lastLendingDate = Convert.ToDateTime(dgvHelpingLoanExtention.Rows[rowIndex].Cells["returnDate"].Value);
                        }
                        rowIndex++;
                    }
                }
                if (mone >= myInformation.MaxNumLoanExtension)
                {
                    DialogResult answer4 = MessageBox.Show("המנוי חורג ממספר ההארכות ההשאלה המקסימלי הקבוע במערכת, האם ברצונך לאפשר לו להשאיל בכל אופן?", "", MessageBoxButtons.YesNo,MessageBoxIcon.None,MessageBoxDefaultButton.Button2 ,MessageBoxOptions.RtlReading);
                    if (answer4 == DialogResult.No)
                    {
                        MessageBox.Show(" מספר האפשרויות להאריך השאלה הם " + myInformation.MaxNumLoanExtension + "המנוי עבר את המספר הזה ולכן אינו רשאי להשאיל ספר זה שוב כעת ", "",MessageBoxButtons.OK,MessageBoxIcon.None,MessageBoxDefaultButton.Button1,MessageBoxOptions.RtlReading);

                        refreshFrm();
                        return true;
                    }
                    else if (answer4 == DialogResult.Yes) return false;
                }
                else return false;
            }
            return false;
        }

        private void btnShowMemberDetails_Click(object sender, EventArgs e)
        {
            if(rdbCmb.Checked==true)
            {
            int index = Convert.ToInt32(cmbChooseMember.SelectedValue);
            FrmMember f = new FrmMember(statusKind.show,index);
            f.ShowDialog();
            }
            else if (rdbTxt.Checked == true)
                    if (myMemberTable.find(Convert.ToInt32(txtCode.Text)) != null)
                    {
                    int index = Convert.ToInt32(txtCode.Text);
                    FrmMember f = new FrmMember(statusKind.show, index);
                    f.ShowDialog();
                    }
                else MessageBox.Show("קוד מנוי לא תקין, לא נמצא מנוי");
        }

        private void rdbCmb_CheckedChanged(object sender, EventArgs e)
        {
            cmbChooseMember.Enabled = true;
            txtCode.Enabled = false;
        }

        private void rdbTxt_CheckedChanged(object sender, EventArgs e)
        {
            txtCode.Enabled = true;
            cmbChooseMember.Enabled = false;
            cmbChooseMember.Text = "בחר מנוי";
            if (txtCode.Text == "")
            { btnNext.Enabled = false; btnShowMemberDetails.Visible = false; }
            else
            { btnNext.Enabled = true; btnShowMemberDetails.Visible = true; }

        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            if (txtCode.Text == "") { btnNext.Enabled = false; btnShowMemberDetails.Visible = false; }
            else { btnNext.Enabled = true; btnShowMemberDetails.Visible = true; }
            
        }

        private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if ((c >= '0' && c <= '9') || c == '\b') e.Handled = false;
            else { e.Handled = true; Console.Beep(); }
        }

        private void txtFineForDelay_TextChanged(object sender, EventArgs e)
        {
            lblshach.Visible = true;
            btnFineForDelayPaying.Enabled = true;
        }

        public void isMemberHavePreviousFine(int memberId)
        {
            DataRow myMemberRow = myMemberTable.find(memberId);
            if(Convert.ToInt32 (myMemberRow["fine"])>0)
            {
                panel3.Visible = true;
                txtSumPreviousFine.Text = Convert.ToString(myMemberRow["fine"]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmFinePaying f = new frmFinePaying(statusKind.add, memberSelectedId);
            f.Show();
        }
    }
    
        
   
    
}


