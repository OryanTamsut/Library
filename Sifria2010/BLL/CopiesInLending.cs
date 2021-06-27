using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Sifria2010.BLL
{
    public class CopiesInLending
    {
        private int lendingId;

        public int LendingId
        {
            get { return lendingId; }
            set { lendingId = value; }
        }
        private int copyId;

        public int CopyId
        {
            get { return copyId; }
            set { copyId = value; }
        }
        private double fineForDelay;

        public double FineForDelay
        {
            get { return fineForDelay; }
            set { fineForDelay = value; }
        }
        private int fineForDefect;

        public int FineForDefect
        {
            get { return fineForDefect; }
            set { fineForDefect = value; }
        }
        private string infoOfDefect;

        public string InfoOfDefect
        {
            get { return infoOfDefect; }
            set { infoOfDefect = value; }
        }
        private DateTime lendingDate;

        public DateTime LendingDate
        {
            get { return lendingDate; }
            set { lendingDate = value; }
        }
        private DateTime returnDate;

        public DateTime ReturnDate
        {
            get { return returnDate; }
            set { returnDate = value; }
        }
        private string lendingNote;

        public string LendingNote
        {
            get { return lendingNote; }
            set { lendingNote = value; }
        }
        public CopiesInLending()
        {
            this.fineForDefect = 0;
            this.fineForDelay = 0.0;
            this.LendingNote = "";
            this.infoOfDefect = "";
        }
        public CopiesInLending(int lendingId1, int copyId1, double fineForDelay1, int fineForDefect1, string inforOfDefect1, DateTime lendingDate1, DateTime returnDate1, string lendingNote1)
        {
            this.lendingId = lendingId1;
            this.copyId = copyId1;
            this.fineForDelay = fineForDelay1;
            this.fineForDefect = fineForDefect1;
            this.infoOfDefect = inforOfDefect1;
            this.lendingDate = lendingDate1;
            this.returnDate = returnDate1;
            this.lendingNote = lendingNote1;
        }
        public CopiesInLending(DataRow drOfCopiesInLending)
        {
            this.lendingId = Convert.ToInt32(drOfCopiesInLending["lendingId"]);
            this.copyId = Convert.ToInt32(drOfCopiesInLending["copyId "]);
            this.fineForDelay = Convert.ToDouble(drOfCopiesInLending["fineForDelay"]);
            this.fineForDefect = Convert.ToInt32(drOfCopiesInLending["fineForDefect"]);
            this.infoOfDefect = Convert.ToString(drOfCopiesInLending["infoOfDefect"]);
            this.lendingDate = Convert.ToDateTime(drOfCopiesInLending["lendingDate"]);
            this.returnDate = Convert.ToDateTime(drOfCopiesInLending["returnDate"]);
            this.lendingNote = Convert.ToString(drOfCopiesInLending["lendingNote"]);

        }
        public DataRow BuildRow()
        {
            DataRow dr = new CopiesInLendingTable().Dt.NewRow();
            dr["lendingId"] = this.lendingId;
            dr["copyId"] = this.copyId;
            dr["fineForDelay"] = this.fineForDelay;
            dr["fineForDefect"] = this.fineForDefect;
            dr["infoOfDefect"] = this.infoOfDefect;
            dr["lendingDate"] = this.lendingDate;
            dr["returnDate"] = this.returnDate;
            dr["lendingNote"] = this.lendingNote;
            return dr;
        }

    }
}
