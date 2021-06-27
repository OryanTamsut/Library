using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Sifria2010.BLL
{
    public class Copies
    {
        private int rowId;
        private int copyId;
        private int bookId;
        private bool status;

        public int RowId
        {
            get { return rowId; }
            set { rowId = value; }
        }
        public int CopyId 
        {
            get { return copyId;} 
            set { copyId = value;}
        }
       public int BookId
        {
            get { return bookId; }
            set { bookId = value; }
        }

       public bool Status
       {
           get { return status; }
           set { status = value; }
       }
        public Copies()
        {
            this.status = true;
        }
        public Copies(int rowId1,int copyId1, int bookId1, bool status1)
        {
            this.rowId = rowId1;
            this.copyId = copyId1;
            this.bookId = bookId1;
            this.status = status1;
        }
        public Copies(DataRow drOfCopies)
        {
            this.rowId = Convert.ToInt32(drOfCopies["rowId"]);
            this.copyId = Convert.ToInt32(drOfCopies["copyId"]);
            this.bookId = Convert.ToInt32(drOfCopies["bookId"]);
            this.status = Convert.ToBoolean(drOfCopies["status"]);
        }

        //צריך לבדוק אם עובד
        public Copies(int valueOfKey)
        {
            CopiesTable copiesTable = new CopiesTable();
            DataRow drOfCopies = copiesTable.find(valueOfKey);
            this.copyId = Convert.ToInt32(drOfCopies["copyId"]);
            this.bookId = Convert.ToInt32(drOfCopies["bookId"]);
            this.status = Convert.ToBoolean(drOfCopies["status"]);
        }
        public DataRow buildRow()
        {
            DataRow dr = new CopiesTable().Dt.NewRow();
            dr["rowId"] = this.rowId;
            dr["copyId"] = this.copyId;
            dr["bookId"] = this.bookId;
            dr["status"] = this.status;
            return dr;
        }
    }
}
