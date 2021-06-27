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
    public partial class frmAllLending : Form
    {
        
        public frmAllLending()
        {
            InitializeComponent();
        }

        private void frmAllLending_Load(object sender, EventArgs e)
        {
            //  ולסדר את מאפייני הדאטהגרידוויו
            string st = "SELECT lending.lendingId, lending.memberId, members.firstNameMember, members.lastNameMember, books.bookName, writers.writerName, copies.copyId, copiesInLending.fineForDelay, copiesInLending.fineForDefect, copiesInLending.infoOfDefect, copiesInLending.lendingDate, copiesInLending.returnDate, copiesInLending.lendingNote FROM writers INNER JOIN (books INNER JOIN (members INNER JOIN (copies INNER JOIN (lending INNER JOIN copiesInLending ON lending.lendingId = copiesInLending.lendingId) ON copies.rowId = copiesInLending.copyId) ON members.memberId = lending.memberId) ON books.bookId = copies.bookId) ON writers.writerId = books.writerId; ";
            DataTable dt = DAL.DAL.GetQuery(st);
            dgvAllLending.DataSource = dt;
            dgvAllLending.Columns[0].HeaderText = "קוד השאלה";
            dgvAllLending.Columns[1].HeaderText = "קוד מנוי";
            dgvAllLending.Columns[2].HeaderText = "שם פרטי מנוי";
            dgvAllLending.Columns[3].HeaderText = "שם משפחה מנוי";
            dgvAllLending.Columns[4].HeaderText = "שם ספר";
            dgvAllLending.Columns[5].HeaderText = "שם סופר";
            dgvAllLending.Columns[6].HeaderText = "קוד עותק";
            dgvAllLending.Columns[7].HeaderText = "קנס עבור איחור";
            dgvAllLending.Columns[8].HeaderText = "קנס עבור פגם";
            dgvAllLending.Columns[9].HeaderText = "מידע על פגם";
            dgvAllLending.Columns[10].HeaderText = "תאריך השאלה";
            dgvAllLending.Columns[11].HeaderText = "תאריך החזרה";
            dgvAllLending.Columns[12].HeaderText = "הערה להשאלה";
            
        }
   
    }
}
