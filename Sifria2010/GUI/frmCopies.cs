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
    public partial class frmCopies : Form
    {
        private statusKind statusFrm;
        private Copies myCopy;
        private CopiesTable myTable;
        private BooksTable myBookTable;
        bool isLastOtek = false;
        private int bookId = 0;
        private int copyId = 0;
        public frmCopies(statusKind f)
        {
            InitializeComponent();
            this.statusFrm = f;
            this.myTable = new CopiesTable();
            this.myBookTable = new BooksTable();
        }
        public frmCopies(statusKind f,int bookId1, int copyId1)
        {
            InitializeComponent();
            this.statusFrm = f;
            this.myTable = new CopiesTable();
            this.myBookTable = new BooksTable();
            this.bookId = bookId1;
            this.copyId = copyId1;
        }
        private void frmCopies_Load(object sender, EventArgs e)
        {
            if (this.statusFrm == statusKind.add)
            {
                lblHeadLine.Text = "הוסף עותק";
                grb.Visible = false;
                btnFinish.Text = "הוסף עותק";
                cmbChooseBook.DataSource = myBookTable.GetTable();
                cmbChooseBook.DisplayMember = "bookName";
                cmbChooseBook.ValueMember = "bookId";
                cmbChooseBook.SelectedValue = -1;
                cmbChooseBook.Text = "בחר ספר";
            }
            else if (this.statusFrm == statusKind.delete)
            {
                lblHeadLine.Text = "מחק עותק";
                grb.Visible = true;
                grb.Enabled = false;
                txtNumCopies.Visible = false;
                lblNumCopies.Visible = false;
                btnFinish.Text = "מחק עותק";
                cmbChooseBook.DataSource = myBookTable.GetTable();
                cmbChooseBook.DisplayMember = "bookName";
                cmbChooseBook.ValueMember = "bookId";
                cmbChooseBook.SelectedValue = -1;
                cmbChooseBook.Text = "בחר ספר";

                if (bookId != 0 && copyId != 0)
                {
                    cmbChooseCopy.Enabled = true;
                    grb.Enabled = true;
                    //לבדוק למה לא מאשר מחיקה מייד כאשר הטופס נפתח דרך ההשאלות וההחזרות
                    cmbChooseBook.SelectedValue = bookId;
                    
                    DataTable dt= getTableByBookId(Convert.ToInt32(cmbChooseBook.SelectedValue));
                    cmbChooseCopy.DataSource = dt;
                    cmbChooseCopy.DisplayMember = "copyId";
                    cmbChooseCopy.ValueMember = "rowId";
                    cmbChooseCopy.SelectedValue = myTable.findByCopyIdBookId(copyId,bookId);
                    int rowId = Convert.ToInt32(cmbChooseCopy.SelectedValue);
                    DataRow dr = myTable.find(rowId);
                    this.myCopy = new Copies(dr);
                    if (dt.Rows.Count == 1) isLastOtek = true;
                }
            }
        }

        public DataTable getTableByBookId(int bookId1)
        {
            string sq = "SELECT copies.rowId, copies.copyId FROM copies WHERE(((copies.bookId) ="+bookId1+") AND((copies.status) = True));";
            DataTable dt = DAL.DAL.GetQuery(sq);
            if (dt.Rows.Count == 1) isLastOtek = true;
            return dt;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (statusFrm == statusKind.add)
            {
                BuildObjectForAdding();
                MessageBox.Show("העותק התווסף בהצלחה");
            }
            else if (statusFrm==statusKind.delete)
            {
                DataRow myOtekRow = myTable.find(Convert.ToInt32(cmbChooseCopy.SelectedValue));
                if (isCopyLending(Convert.ToInt32(cmbChooseCopy.SelectedValue)) == false)
                {
                    DataRow myRow = this.myCopy.buildRow();
                    if (myTable.Delete(myRow))
                        MessageBox.Show("העותק נמחק בהצלחה");
                    else
                        MessageBox.Show("העותק לא נמצא");
                    if (isLastOtek)
                    {
                       
                        DataRow myBookRow = myBookTable.find(myOtekRow["bookId"]);
                        myBookRow["status"] = false;
                        if(myBookTable.Delete(myBookRow))
                        MessageBox.Show("מכיוון שזהו העותק האחרון, הספר נמחק ממאגר הספרים");
                    }
                }
                else MessageBox.Show("העותק מושאל כעת אצל מנוי אחר, אין אפשרות למחוק");
            }
            clearFrm();
        }

        public void BuildObjectForAdding()
        {
            int nextCopyId = MaxCopyId(Convert.ToInt32(cmbChooseBook.SelectedValue)) + 1;
            for (int i = nextCopyId; i < Convert.ToInt32(txtNumCopies.Text) + nextCopyId ; i++)
            {
                this.myCopy = new Copies();
                this.myCopy.RowId = Convert.ToInt32(myTable.GetNextKod());
                this.myCopy.BookId = Convert.ToInt32(cmbChooseBook.SelectedValue);
                this.myCopy.CopyId = i;
                DataRow myRow = this.myCopy.buildRow();
                myTable.Add(myRow);
            }  
        }
        

        public int MaxCopyId(int bookId1)
        {
            int max = 0;
            DataTable dt = getTableByBookId(bookId1);
            foreach (DataRow row in dt.Rows)
            {
                if (Convert.ToInt32( row["copyId"]) > max) max = Convert.ToInt32(row["copyId"]);
            }
            return max;
        }

        private void cmbChooseBook_SelectionChangeCommitted(object sender, EventArgs e)
        {
            grb.Enabled = true;
            cmbChooseCopy.DataSource = getTableByBookId(Convert.ToInt32(cmbChooseBook.SelectedValue));
            cmbChooseCopy.DisplayMember = "copyId";
           cmbChooseCopy.ValueMember="rowId";
            cmbChooseCopy.Text = "בחר עותק";
            btnFinish.Enabled = false;
            if (statusFrm == statusKind.add)
            {
                if (isFieldFull())
                    btnFinish.Enabled = true;
                else btnFinish.Enabled = false;
            }
        }

        private void cmbChooseCopy_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int rowId = Convert.ToInt32(cmbChooseCopy.SelectedValue);
            DataRow dr = myTable.find(rowId);
            this.myCopy= new Copies(dr);
            btnFinish.Enabled = true;
        }

        public bool isCopyLending(int copyId)
        {
            CopiesInLendingTable myLendingTable = new CopiesInLendingTable();
            if (myLendingTable.findIfCopyLendingByCopyId(Convert.ToInt32(cmbChooseCopy.SelectedValue)) != null)
                return true;
            else
                return false;
        }

        private void txtNumCopies_TextChanged(object sender, EventArgs e)
        {
            if (isFieldFull()) btnFinish.Enabled = true;
            else btnFinish.Enabled = false;
        }
        public void clearFrm()
        {
            cmbChooseBook.SelectedValue = -1;
            cmbChooseCopy.SelectedValue = -1;
            txtNumCopies.Text = "";
            btnFinish.Enabled = false;
            cmbChooseBook.DataSource = myBookTable.GetTable();
            cmbChooseBook.DisplayMember = "bookName";
            cmbChooseBook.ValueMember = "bookId";
            cmbChooseBook.Text = "בחר ספר";
        }

        public bool isFieldFull()
        {
            if (Convert.ToInt32(cmbChooseBook.SelectedValue) > 0 && txtNumCopies.Text != "") return true;
            else return false;
        }
    }

}

