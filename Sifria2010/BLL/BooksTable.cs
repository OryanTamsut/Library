using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Sifria2010.BLL
{
    public class BooksTable : GeneralTableByAutoCode
    {
        public BooksTable()
            : base("books", "bookId", true)
        { }

        public override void Update(DataRow from, DataRow to)
        {
            to.BeginEdit();
            to["bookId"] = from["bookId"];
            to["bookName"] = from["bookName"];
            to["subject"] = from["subject"];
            to["bookStructure"] = from["bookStructure"];
            to["writerId"] = from["writerId"];
            to["bookContent"] = from["bookContent"];
            to["isComics"] = from["isComics"];
            to["fromAge"] = from["fromAge"];
            to["toAge"] = from["toAge"];
            to["price"] = from["price"];
            to["status"] = from["status"];

            to.EndEdit();

        }

        public override DataTable GetTableForCombobox(string fieldName1, string fieldName2)
        {
            string st;
            if (this.isHasStatus == true)
                st = "SELECT " + this.keyName + ", [" + this.keyName + "] & ' - ' & [" + fieldName1 + "]  AS FullName FROM " + this.dt.TableName + " where status=true";
            else
                st = "SELECT " + this.keyName + ", [" + this.keyName + "] & ' - ' & [" + fieldName1 + "]  AS FullName FROM " + this.dt.TableName;
            return DAL.DAL.GetQuery(st);
        }
    }
}
