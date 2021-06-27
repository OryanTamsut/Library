using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Sifria2010.BLL
{
    public class FinePaying
    {
        private int payId;
        private MembersTable myMembersTable ;
        public int PayId
        {
            get { return payId; }
            set { payId = value; }
        }
        private int memberId;

        public int MemberId
        {
            get { return memberId; }
            set { memberId = value; }
        }
        private int sumFine;

        public int SumFine
        {
            get { return sumFine; }
            set
            {
                if (value <= 0) throw new Exception("יש להזין את סכום התשלום");
                else
                {
                    DataRow myDr = myMembersTable.find(this.memberId);
                    if (value > Convert.ToInt32(myDr["fine"])) throw new Exception(" החוב של המנוי הוא על סך " + myDr["fine"] + " .סכום התשלום שהזנת גדול מחובו של המנוי");
                    else sumFine = value;
                }
            }

        }

        private DateTime payingDate;

        public DateTime PayingDate
        {
            get { return payingDate; }
            set { payingDate = value; }
        }

        public FinePaying()
        {
            myMembersTable = new MembersTable();
        }

        public FinePaying(int payId1, int memberId1, int sumFine1, DateTime payingDate1)
        { 
            this.payId=payId1;
            this.memberId=memberId1;
            this.sumFine=sumFine1;
            this.payingDate=payingDate1;
        }

        public FinePaying(DataRow drOfFinePaying)
        {

            this.payId = Convert.ToInt32(drOfFinePaying["payId"]);
            this.memberId = Convert.ToInt32(drOfFinePaying["memberId"]);
            this.sumFine = Convert.ToInt32(drOfFinePaying["sumFine"]);
            this.payingDate = Convert.ToDateTime(drOfFinePaying["payingDate"]);
        }

        public DataRow BuildRow()
        {
            DataRow dr = new FinePayingTable().Dt.NewRow();
            dr["payId"] = this.payId;
            dr["memberId"] = this.memberId;
            dr["sumFine"] = this.sumFine;
            dr["payingDate"] = this.payingDate;
            return dr;
        }
    }
}
