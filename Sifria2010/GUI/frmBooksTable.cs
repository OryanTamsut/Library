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
    public partial class frmBooksTable : Form
    {
        private BooksTable books;
        public frmBooksTable()
        {
            InitializeComponent();
            books = new BooksTable();
        }

        private void frmBooksTable_Load(object sender, EventArgs e)
        {
            DataTable dt = books.GetTable();
            dgvBooksTable.DataSource = dt;
            dgvBooksTable.Columns[10].Visible = false;
            dgvBooksTable.Columns[0].HeaderText = "קוד ספר";
            dgvBooksTable.Columns[1].HeaderText = "שם ספר";
            dgvBooksTable.Columns[2].HeaderText = "נושא הספר";
            dgvBooksTable.Columns[3].HeaderText = "מבנה ספר";
            dgvBooksTable.Columns[4].HeaderText = "שם סופר";
            dgvBooksTable.Columns[5].HeaderText = "תוכן ספר";
            dgvBooksTable.Columns[6].HeaderText = "האם קומיקס";
            dgvBooksTable.Columns[7].HeaderText = "מגיל";
            dgvBooksTable.Columns[8].HeaderText = "עד גיל";
            dgvBooksTable.Columns[9].HeaderText = "מחיר ספר";
        }
    }
}
