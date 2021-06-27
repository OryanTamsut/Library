using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace Sifria2010.BLL
{
    public class CopiesInLendingTable : GeneralTableByAutoCode
    {
        public CopiesInLendingTable()
            : base("copiesInLending", "lendingId",  false)
        { }

        public override void Update(DataRow from, DataRow to)
        {
            to.BeginEdit();
            to["lendingId"] = from["lendingId"];
            to["copyId"] = from["copyId"];
            to["fineForDelay"] = from["fineForDelay"];
            to["fineForDefect"] = from["fineForDefect"];
            to["infoOfDefect"] = from["infoOfDefect"];
            to["lendingDate"] = from["lendingDate"];
            to["returnDate"] = from["returnDate"];
            to["lendingNote"] = from["lendingNote"];
            to.EndEdit();
        }
        
        public DataRow getRowIdByCopyIdDateReturing(int rowCopyId)
        {
            foreach (DataRow myRow in this.dt.Rows)
            {

                if (myRow["copyId"].Equals(rowCopyId) && myRow["returnDate"].Equals(new DateTime(2000, 01, 01)))
                    if (this.isHasStatus == true)
                        if (myRow["status"].ToString() == "True")
                            return myRow;
                        else
                            return null;
                    else
                        return myRow;
            }
            return null;
        }
        public DataRow findIfCopyLendingByCopyId(int copyId)
        {
            foreach (DataRow row in this.dt.Rows)
            {
                if (row["copyId"].Equals(copyId) && row["returnDate"].Equals(new DateTime(2000, 1, 1)))
                    if (this.isHasStatus == true)
                        if (row["status"].ToString() == "True")
                            return row;
                        else
                            return null;
                    else
                        return row;
            }
            return null;

        }    
    
    
    }

 }

