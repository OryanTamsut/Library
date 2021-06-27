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
    public partial class frmBooks : Form
    {
       
        private Copies myCopy;
        private CopiesTable myCopyTable;
        private statusKind statusFrm;
        private Content myContent;
        private Subjects mySubject;
        private Writers myWriter;
        private Books myBook;
        private BooksTable myBooksTable;
        public int indexJaner;
        public int indexWriter;
        public int indexContent;
        public frmBooks(statusKind statusF)
        {
            InitializeComponent();
            this.statusFrm = statusF;
            myBooksTable = new BooksTable();
            myCopyTable = new CopiesTable();
            
        }
        public frmBooks()
        {
            InitializeComponent();
            
            myBooksTable = new BooksTable();
            myCopyTable = new CopiesTable();

        }

        private void frmBooks_Load(object sender, EventArgs e)
        {
            if (this.statusFrm == statusKind.add)
            {
                updetaDetail();
            }
            else if (this.statusFrm == statusKind.delete)
            {
                lblHeadLine.Text = "מחק ספר";
                cmbChooseBook.Visible = true;
                cmbChooseBook.DataSource = myBooksTable.GetTableForCombobox("bookName", "");
                cmbChooseBook.DisplayMember = "fullName";
                cmbChooseBook.ValueMember = "bookId";
                grbBookDetails.Enabled = false;
                cmbChooseBook.Text = "-בחר ספר למחיקה-";
                btnEnd.Text = "מחק ספר";
            }
            else if (this.statusFrm == statusKind.update)
            {
                updetaDetail();
                lblHeadLine.Text = "עדכון פרטי ספר";
                cmbChooseBook.Visible = true;
                lblBookId.Text = "";
                cmbChooseBook.DataSource = myBooksTable.GetTableForCombobox("bookName", "");
                cmbChooseBook.DisplayMember = "fullName";
                cmbChooseBook.ValueMember = "bookId";
                grbBookDetails.Enabled = false;
                cmbChooseBook.Text = "-בחר ספר לעדכון-";
                btnEnd.Text = "עדכן ספר ";

            }
            else if (statusFrm == statusKind.show)
            {
                updetaDetail();
                lblHeadLine.Text = "הצג פרטי ספר";
                cmbChooseBook.Visible = true;
                lblBookId.Text = "";
                cmbChooseBook.DataSource = myBooksTable.GetTableForCombobox("bookName", "");
                cmbChooseBook.DisplayMember = "fullName";
                cmbChooseBook.ValueMember = "bookId";
                grbBookDetails.Enabled = false;
                cmbChooseBook.Text = "-בחר ספר להצגה-";
                btnEnd.Visible = false; ;
                janerAdd.Visible = false;
                writerAdd.Visible = false;
                contentAdd.Visible = false;
                
            }
        }

        public bool BuildObjectByFields()
        {
            errop1.Clear();
            bool ok = true;
            this.myBook = new Books();
            try
            {
                this.myBook.BookId = Convert.ToInt32(lblBookId.Text);
            }
            catch (Exception ex)
            {
                errop1.SetError(lblBookId, ex.Message);
                ok = false;
            }
            try
            {
                this.myBook.BookName = Convert.ToString(txtBookName.Text);
            }
            catch (Exception ex)
            {
                errop1.SetError(txtBookName, ex.Message);
                ok = false;
            }

            try
            {
                this.myBook.Subject = Convert.ToInt32(cmbJanerSubject.SelectedValue);
            }
            catch (Exception ex)
            {
                errop1.SetError(cmbJanerSubject, ex.Message);
                ok = false;
            }

            try
            {
                this.myBook.BookStructure = Convert.ToString(cmbBookSructure.SelectedItem);
            }
            catch (Exception ex)
            {
                errop1.SetError(cmbBookSructure, ex.Message);
                ok = false;
            }

            try
            {
                this.myBook.WriterId = Convert.ToInt32(cmbWriterName.SelectedValue);
            }
            catch (Exception ex)
            {
                errop1.SetError(cmbWriterName, ex.Message);
                ok = false;
            }
            try
            {
                this.myBook.BookContent = Convert.ToInt32(cmbBookContent.SelectedValue);
            }
            catch (Exception ex)
            {
                errop1.SetError(cmbBookContent, ex.Message);
                ok = false;
            }
            try
            {
                this.myBook.IsComics = Convert.ToBoolean(chbIsComics.Checked);
            }
            catch (Exception ex)
            {
                errop1.SetError(chbIsComics, ex.Message);
                ok = false;
            }
            try
            {
                this.myBook.FromAge = Convert.ToInt32(txtFromAge.Text);
            }
            catch (Exception ex)
            {
                errop1.SetError(txtFromAge, ex.Message);
                ok = false;
            }
            try
            {
                this.myBook.ToAge = Convert.ToInt32(txtToAge.Text);
            }
            catch (Exception ex)
            {
                errop1.SetError(txtToAge, ex.Message);
                ok = false;
            }
            try
            {
                this.myBook.Price = Convert.ToInt32(txtPrice.Text);
            }
            catch (Exception ex)
            {
                errop1.SetError(txtPrice, ex.Message);
                ok = false;
            }
            return ok;
        }

        public void buildCopy()
        {
            //להוסיף תקינות קלט
            this.myCopy = new Copies();
            myCopy.RowId = Convert.ToInt32(myCopyTable.GetNextKod());
            myCopy.BookId = Convert.ToInt32(lblBookId.Text);
            myCopy.CopyId = 1;
            DataRow dr = this.myCopy.buildRow();
            this.myCopyTable.Add(dr);
        }


        public void FillFieldsByObject()
        {
            lblBookId.Text = Convert.ToString(this.myBook.BookId);
            txtBookName.Text = Convert.ToString(this.myBook.BookName);
            txtFromAge.Text = Convert.ToString(this.myBook.FromAge);
            txtToAge.Text = Convert.ToString(this.myBook.ToAge);
            txtPrice.Text = Convert.ToString(this.myBook.Price);
            this.myContent = new Content(this.myBook.BookContent);
            this.mySubject = new Subjects(this.myBook.Subject);
            this.myWriter = new Writers(this.myBook.WriterId);
            cmbBookContent.Text = Convert.ToString(myContent.ContentName);
            cmbBookSructure.Text = Convert.ToString(this.myBook.BookStructure);
            cmbJanerSubject.Text = Convert.ToString(mySubject.SubjectName);
            chbIsComics.Checked = Convert.ToBoolean(this.myBook.IsComics);
            cmbWriterName.Text = Convert.ToString(myWriter.WriterName);
        }
        public void updetaDetail()
        {
            lblBookId.Text = Convert.ToString(myBooksTable.GetNextKod());
            cmbJanerSubject.DataSource = new SubjectsTable().GetTable();
            cmbJanerSubject.DisplayMember = "subjectName";
            cmbJanerSubject.ValueMember = "subjectId";
            cmbJanerSubject.SelectedValue = -1;
            cmbJanerSubject.Text = "-בחר ז'אנר ספר-";
            
            cmbWriterName.DataSource = new WritersTable().GetTable();
            cmbWriterName.DisplayMember = "writerName";
            cmbWriterName.ValueMember = "writerId";
            cmbWriterName.SelectedValue = -1;
            cmbWriterName.Text = "-בחר סופר-";
           
            cmbBookContent.DataSource = new ContentTable().GetTable();
            cmbBookContent.DisplayMember = "contentName";
            cmbBookContent.ValueMember = "contentId";
            cmbBookContent.SelectedValue = -1;
            cmbBookContent.Text = "-בחר תוכן ספר-";
           
            cmbBookSructure.Text = "-בחר מבנה ספר-";
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            if (BuildObjectByFields())
            {
                DataRow myRow = this.myBook.BuildRow();
                if (statusFrm == statusKind.add)
                {
                    if (this.myBooksTable.Add(myRow))
                    {
                        buildCopy();
                        
                        MessageBox.Show("הספר התווסף בהצלחה");
                    }
                    else
                        MessageBox.Show("הספר כבר קיים ");
                    lblHeadLine.Text = "הוספת ספר חדש";
                    lblBookId.Text = Convert.ToString(myBooksTable.GetNextKod());
                    cmbChooseBook.Visible = false;
                    lblChooseBook.Visible = false;
                    clearFrm();

                }
                else 
                    if (statusFrm == statusKind.update)
                {
                    if (this.myBooksTable.Update(myRow))
                        MessageBox.Show("הספר עודכן בהצלחה");
                    else
                        MessageBox.Show("הספר לא קיים במאגר");
                    lblHeadLine.Text = "עדכון ספר";
                    cmbChooseBook.Visible = true;
                    cmbChooseBook.DataSource = myBooksTable.GetTable();
                    cmbChooseBook.DisplayMember = "bookName";
                    cmbChooseBook.ValueMember = "bookId";
                    grbBookDetails.Enabled = false;
                    cmbChooseBook.Text = "-בחר ספר לעדכון-";  
                    btnEnd.Text = "עדכן ספר ";
                    clearFrm();
                }
                else
                     if (statusFrm == statusKind.delete)
                    {
                    if (!isBookHaveCopies(Convert.ToInt32(lblBookId.Text)))
                    {
                        if (this.myBooksTable.Delete(myRow))
                            MessageBox.Show("הספר נמחק בהצלחה");
                        else
                            MessageBox.Show("הספר לא קיים במאגר");
                        lblHeadLine.Text = "מחיקת ספר";
                        cmbChooseBook.Visible = true;
                        cmbChooseBook.DataSource = myBooksTable.GetTable();
                        cmbChooseBook.DisplayMember = "bookName";
                        cmbChooseBook.ValueMember = "bookId";
                        grbBookDetails.Enabled = false;
                        cmbChooseBook.Text = "-בחר ספר למחיקה-";
                        btnEnd.Text = "מחק ספר ";
                        
                    }
                    else MessageBox.Show("לספר זה קיימים עותקים ולכן לא ניתן למחוק אותו,אם ברצונך למחוק עליך למחוק קודם את העותקים");
                    clearFrm();
                }

            }
        }

        public void clearFrm()
        {
            lblBookId.Text = Convert.ToString(myBooksTable.GetNextKod());
            txtBookName.Text = "";
            txtFromAge.Text = "";
            txtPrice.Text = "";
            txtToAge.Text = "";
            cmbBookContent.Text = "";
            cmbBookSructure.Text = "";
            cmbChooseBook.Text = "";
            cmbJanerSubject.Text = "";
            cmbWriterName.Text = "";
            btnEnd.Enabled = false;
            
        }

        private void cmbChooseBook_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int bookId = Convert.ToInt32(cmbChooseBook.SelectedValue);
            DataRow dr = myBooksTable.find(bookId);
            this.myBook = new Books(dr);
            grbBookDetails.Enabled = true;
            FillFieldsByObject();
        }
        //תקינות קלט
        private void txtBookName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            string hebrowTav = "אבגדהוזחטיכלמנסעפצקרשתםןךץף";
            string englishTav = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            if ((hebrowTav.IndexOf(c) == -1 && c != ' ' && c != '\b')&&(englishTav.IndexOf(c) == -1 && c != ' ' && c != '\b'))
                
            { e.Handled = true; Console.Beep(); }
        }

        private void txtFromAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if ((c >= '0' && c <= '9') || c == '\b') e.Handled = false;
            else { e.Handled = true; Console.Beep(); }
        }

        private void txtToAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if ((c >= '0' && c <= '9') || c == '\b') e.Handled = false;
            else { e.Handled = true; Console.Beep(); }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if ((c >= '0' && c <= '9') || c == '\b') e.Handled = false;
            else { e.Handled = true; Console.Beep(); }
        }

        private void janerAdd_Click(object sender, EventArgs e)
        {
            FrmJanersSabject f = new FrmJanersSabject(statusKind.add,this);
            f.ShowDialog();
            cmbJanerSubject.DataSource = new SubjectsTable().GetTable();
            cmbJanerSubject.DisplayMember = "subjectName";
            cmbJanerSubject.ValueMember = "subjectId";
            cmbJanerSubject.SelectedValue = indexJaner;
        
        }

        private void writerAdd_Click(object sender, EventArgs e)
        {
            FrmWriter f = new FrmWriter(statusKind.add,this);
            f.ShowDialog();
            cmbWriterName.DataSource = new WritersTable().GetTable();
            cmbWriterName.DisplayMember = "writerName";
            cmbWriterName.ValueMember = "writerId";
            cmbWriterName.SelectedValue=indexWriter;
        }

        private void contentAdd_Click(object sender, EventArgs e)
        {
            FrmContents f = new FrmContents(statusKind.add,this);
            f.ShowDialog();
            cmbBookContent.DataSource = new ContentTable().GetTable();
            cmbBookContent.DisplayMember = "contentName";
            cmbBookContent.ValueMember = "contentId";
            cmbBookContent.SelectedValue=indexContent;
        }

        public bool isBookHaveCopies(int bookId)
        {
            string st = "SELECT copies.bookId, copies.copyId FROM copies WHERE(((copies.bookId) = "+bookId+"));";
            DataTable dt = DAL.DAL.GetQuery(st);
            if (dt != null)
                return true;
            else return false;
        }

        private void cmbJanerSubject_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (isCmbSelected()) btnEnd.Enabled = true;
            else btnEnd.Enabled = false;
        }

        public bool isCmbSelected()
        {
            if (Convert.ToInt32 (cmbBookContent.SelectedValue) > 0 && cmbBookSructure.SelectedItem != null && Convert.ToInt32(cmbJanerSubject.SelectedValue) > 0&& Convert.ToInt32(cmbWriterName.SelectedValue) > 0)
                return true;
            else return false;
        }

        private void cmbBookSructure_SelectionChangeCommitted(object sender, EventArgs e)
        {

            if (isCmbSelected()) btnEnd.Enabled = true;
            else btnEnd.Enabled = false;
        }

        private void cmbWriterName_SelectionChangeCommitted(object sender, EventArgs e)
        {

            if (isCmbSelected()) btnEnd.Enabled = true;
            else btnEnd.Enabled = false;
        }

        private void cmbBookContent_SelectionChangeCommitted(object sender, EventArgs e)
        {

            if (isCmbSelected()) btnEnd.Enabled = true;
            else btnEnd.Enabled = false;
        }

        private void TxtPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
