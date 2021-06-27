using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Sifria2010.BLL
{
    public class CopiesTable : GeneralTableByAutoCode
    {
        public CopiesTable()
            : base("copies", "rowId", true)
        { }

        public override void Update(DataRow from, DataRow to)
        {
            to.BeginEdit();
            to["rowId"] = from["rowId"];
            to["copyId"] = from["copyId"];
            to["bookId"] = from["bookId"];
            to["status"] = from["status"];
            to.EndEdit();

        }

        public int findByCopyIdBookId(int copyId,int bookId )
        {
            foreach (DataRow row in this.dt.Rows)
            {
                if ((row["bookId"].Equals(bookId))&&((row["copyId"].Equals(copyId))))
                    if (this.isHasStatus == true)
                        if (row["status"].ToString() == "True")
                            return Convert.ToInt32 (row["rowId"]);
                        else
                            return 0;
                    else
                        return Convert.ToInt32(row["rowId"]);
            }
            return 0;
        }



    }

}