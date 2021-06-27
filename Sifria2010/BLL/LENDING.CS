using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Sifria2010.BLL
{
    public class Lending
    {
        private int lendingId;

        public int LendingId
        {
            get { return lendingId; }
            set { lendingId = value; }
        }
        private int memberId;

        public int MemberId
        {
            get { return memberId; }
            set { memberId = value; }
        }
        private DateTime lendingDate;

        public DateTime LendingDate
        {
            get { return lendingDate; }
            set { lendingDate = value; }
        }
        public Lending()
        { }
        public Lending(int lendingId1, int memberId1, DateTime LendingDate1)
        {
            this.lendingId = lendingId1;
            this.memberId = memberId1;
            this.LendingDate = LendingDate1;
        }
    
    public Lending(DataRow drOfLending)
        {
            this.lendingId = Convert.ToInt32(drOfLending["lendingId"]);
            this.memberId = Convert.ToInt32(drOfLending["memberId"]);
            this.LendingDate = Convert.ToDateTime(drOfLending["LendingDate"]);
        }
    public DataRow BuildRow()
    {
        DataRow dr = new LendingTable().Dt.NewRow();
        dr["lendingId"] = this.lendingId;
        dr["memberId"] = this.memberId;
        dr["LendingDate"] = this.LendingDate;
        return dr; 
    }
    
    }
}
