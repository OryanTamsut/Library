using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Sifria2010.BLL
{
    public class Books
    {
        private int bookId;
        private string bookName;
        private int subject;
        private string bookStructure;
        private int writerId;
        private int bookContent;
        private bool isComics;
        private int fromAge;
        private int toAge;
        private int price;
        private bool status;

        public int BookId
        {
            get { return bookId; }
            set { bookId = value; }
        }
        public string BookName
        {
            get { return bookName; }
            set
            {
                if (value == "")
                    throw new Exception("הזן שם ספר");
                if (value[0] == ' ')
                    throw new Exception("שם ספר לא מתחיל ברווח");
                bookName = value;
            }

        }
        public int Subject
        {
            get { return subject; }
            set
            {
                if (value < 1) throw new Exception("לא נבחר ערך");
                subject = value;
            }
        }
        public string BookStructure
        {
            get { return bookStructure; }
            set { bookStructure = value; }
        }
        public int WriterId
        {
            get { return writerId; }
            set
            {
                
                if (value < 1) throw new Exception("לא נבחר ערך");
                writerId = value;
            }
        }
        public int BookContent
        {
            get { return bookContent; }
            set
            {
                if (value < 1) throw new Exception("לא נבחר ערך");
                bookContent = value;
            }
        }
        public bool IsComics
        {
            get { return isComics; }
            set { isComics = value; }
        }
        public int FromAge
        {
            get { return fromAge; }
            set
            {
                if (value < 0)
                    throw new Exception("גיל צריך להיות יותר גדול מ-0");
                
                fromAge = value;
            }
        }
        public int ToAge
        {
            get { return toAge; }
            set
            {
                if (value < 0)
                    throw new Exception("גיל צריך להיות יותר גדול מ-0");
                
                toAge = value;
            }
        }
        public int Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                    throw new Exception("מחיר צריך להיות יותר גדול מ-0");
                price = value;
            }
        }
        public bool Status
        {
            get { return status; }
            set { status = value; }
        }
        public Books()
        { this.status = true; }

        public Books(int bookId1, string bookName1, int subject1, string bookStructure1, int writerId1, int bookContent1, bool isComics1, int fromAge1, int toAge1, int price1, bool status1)
        {
            this.bookId = bookId1;
            this.bookName = bookName1;
            this.subject = subject1;
            this.bookStructure = bookStructure1;
            this.writerId = writerId1;
            this.bookContent = bookContent1;
            this.isComics = isComics1;
            this.fromAge = fromAge1;
            this.toAge = toAge1;
            this.price = price1;
            this.status = status1;
        }

        public Books(DataRow drOfBook)
        {
            this.bookId = Convert.ToInt32(drOfBook["bookId"]);
            this.bookName = Convert.ToString(drOfBook["bookName"]);
            this.subject = Convert.ToInt32(drOfBook["subject"]);
            this.bookStructure = Convert.ToString(drOfBook["bookStructure"]);
            this.writerId = Convert.ToInt32(drOfBook["writerId"]);
            this.bookContent = Convert.ToInt32(drOfBook["bookContent"]);
            this.isComics = Convert.ToBoolean(drOfBook["isComics"]);
            this.fromAge = Convert.ToInt32(drOfBook["fromAge"]);
            this.toAge = Convert.ToInt32(drOfBook["toAge"]);
            this.price = Convert.ToInt32(drOfBook["price"]);
            this.status = Convert.ToBoolean(drOfBook["status"]);
        }

        public DataRow BuildRow()
        {
            DataRow dr = new BooksTable().Dt.NewRow();
            dr["bookId"] = this.bookId;
            dr["bookName"] = this.bookName;
            dr["subject"] = this.subject;
            dr["bookStructure"] = this.bookStructure;
            dr["writerId"] = this.writerId;
            dr["bookContent"] = this.bookContent;
            dr["isComics"] = this.isComics;
            dr["fromAge"] = this.fromAge;
            dr["toAge"] = this.toAge;
            dr["price"] = this.price;
            dr["status"] = this.status;
            return dr;
        }
        //צריך לבדוק אם נכון
        public Books(int valueOfKey)
        {
            BooksTable booksTable = new BooksTable();
            DataRow drOfBook = booksTable.find(valueOfKey);
            this.bookId = Convert.ToInt32(drOfBook["bookId"]);
            this.bookName = Convert.ToString(drOfBook["bookName"]);
            this.subject = Convert.ToInt32(drOfBook["subject"]);
            this.bookStructure = Convert.ToString(drOfBook["bookStructure"]);
            this.writerId = Convert.ToInt32(drOfBook["writerId"]);
            this.bookContent = Convert.ToInt32(drOfBook["bookContent"]);
            this.isComics = Convert.ToBoolean(drOfBook["isComics"]);
            this.fromAge = Convert.ToInt32(drOfBook["fromAge"]);
            this.toAge = Convert.ToInt32(drOfBook["toAge"]);
            this.price = Convert.ToInt32(drOfBook["price"]);
            this.status = Convert.ToBoolean(drOfBook["status"]);
        }
        
    }
}
