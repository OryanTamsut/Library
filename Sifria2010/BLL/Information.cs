using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Sifria2010.BLL
{
   public class Information
    {
        private int id;
        
        
        private int memberPriceForOneBook;

        public int MemberPriceForOneBook
        {
            get { return memberPriceForOneBook; }
            set
            {
                if (value < 0)
                    throw new Exception("מחיר מנוי לספר צריך להיות יותר גדול מ-0");
                memberPriceForOneBook = value;
            }
        }
        private int precentOfTheBookPriceForFine;

        public int PrecentOfTheBookPriceForFine
        {
            get { return precentOfTheBookPriceForFine; }
            set
            {
                if (value < 0)
                    throw new Exception("מספר אחוזים מספר עבור קנס צריך להיות יותר גדול מ-0");
                precentOfTheBookPriceForFine = value;
            }
        }
        private int maxDaysLending;

        public int MaxDaysLending
        {
            get { return maxDaysLending; }
            set
            {
                if (value < 0)
                    throw new Exception("מספר ימי השאלה מקסימאלים צריך להיות יותר גדול מ-0");
                maxDaysLending = value;
            }
        }
        private int maxNumLoanExtension;

        public int MaxNumLoanExtension
        {
            get { return maxNumLoanExtension; }
            set
            {
                if (value < 0)
                    throw new Exception("מספר פעמים הארכות השאלה צריך להיות יותר גדול מ-0");
                maxNumLoanExtension = value;
            }
        }
        private int finePriceForOneDay;

        public int FinePriceForOneDay
        {
            get{ return finePriceForOneDay; }
            set {
                if (value < 0)
                    throw new Exception("מחיר הקנס ליום אחד צריך להיות יותר גדול מ-0");
                finePriceForOneDay = value;
            }
        }
        public Information()
        { this.id = 1;  }

        public Information(int id1, int memberPriceForOneBook1, int precentOfTheBookPriceForFine1, int maxDaysLending1 ,int maxNumLoanExtension1, int finePriceForOneDay1)
        {
            this.id = id1;
            this.memberPriceForOneBook = memberPriceForOneBook1;
            this.precentOfTheBookPriceForFine = precentOfTheBookPriceForFine1;
            this.maxDaysLending = maxDaysLending1;
            this.maxNumLoanExtension = maxNumLoanExtension1;
            this.finePriceForOneDay = finePriceForOneDay1;
        }
        public Information(DataRow drOfInformation)
        {
            this.id = Convert.ToInt32(drOfInformation["id"]);
            this.memberPriceForOneBook = Convert.ToInt32(drOfInformation["memberPriceForOneBook"]);
            this.precentOfTheBookPriceForFine = Convert.ToInt32(drOfInformation["precentOfTheBookPriceForFine"]);
            this.maxDaysLending = Convert.ToInt32(drOfInformation["maxDaysLending"]);
            this.maxNumLoanExtension = Convert.ToInt32(drOfInformation["maxNumLoanExtension"]);
            this.finePriceForOneDay = Convert.ToInt32(drOfInformation["finePriceForOneDay"]);
        }
        public DataRow BuildRow()
        {
            DataRow dr = new InformationTable().Dt.NewRow();
            dr["id"] = this.id;
            dr["memberPriceForOneBook"] = this.memberPriceForOneBook;
            dr["precentOfTheBookPriceForFine"] = this.precentOfTheBookPriceForFine;
            dr["maxDaysLending"] = this.maxDaysLending;
            dr["maxNumLoanExtension"] = this.maxNumLoanExtension;
            dr["finePriceForOneDay"] = this.finePriceForOneDay;
            return dr;
        }
   
   }
}
