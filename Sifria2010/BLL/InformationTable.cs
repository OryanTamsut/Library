using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Sifria2010.BLL
{
   public class InformationTable: GeneralTable
    {
       public InformationTable()
           : base("information", "Id", false)
        { }
    
         public override void Update(DataRow from, DataRow to)
       {
           to.BeginEdit();
           to["id"] = from["id"];
           to["memberPriceForOneBook"] = from["memberPriceForOneBook"];
           to["PrecentOfTheBookPriceForFine"] = from["PrecentOfTheBookPriceForFine"];
           to["MaxDaysLending"] = from["MaxDaysLending"];
           to["MaxNumLoanExtension"] = from["MaxNumLoanExtension"];
           to["finePriceForOneDay"] = from["finePriceForOneDay"];
            to.EndEdit();


       }
   }
}
