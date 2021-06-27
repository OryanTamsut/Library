using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace Sifria2010.BLL
{
   public class FinePayingTable: GeneralTableByAutoCode
    {
       public FinePayingTable()
           : base("finePaying", "payId", false)
        { }


       public override void Update(DataRow from, DataRow to)
       {
           to.BeginEdit();
           to["payId"] = from["payId"];
           to["memberId"] = from["memberId"];
           to["sumFine"] = from["sumFine"];
           to["payingDate"] = from["payingDate"];
           to.EndEdit();


       }
   }
}
