using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Sifria2010.BLL
{
   public class LendingTable: GeneralTableByAutoCode

    {
       public LendingTable()
           : base("lending", "lendingId", false)
        { }

       public override void Update(DataRow from, DataRow to)
       {
           to.BeginEdit();
           to["lendingId"] = from["lendingId"];
           to["memberId"] = from["memberId"];
           to["lendingDate"] = from["lendingDate"];
           to.EndEdit();
       }

       
   
   
   }
}
