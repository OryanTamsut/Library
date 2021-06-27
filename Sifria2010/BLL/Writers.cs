using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Sifria2010.BLL
{
  public  class Writers
    {
        private int writerId;
        private string writerName;
        private bool status;

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

        public int WriterId
        {
            get { return this.writerId; }
            set { this.writerId = value; }
        }
        public string WriterName
        {
            get { return this.writerName; }
            set {
                if (value == "")
                    throw new Exception("  הזן שם סופר ");
                if (value[0] == ' ')
                    throw new Exception("שם סופר לא מתחיל ברווח");
                writerName = value;
            }

        }
        public Writers()
        { this.status = true; }

        public Writers(int writerId1, string writerName1,bool status1)
        {
            this.writerId = writerId1;
            this.writerName = writerName1;
            this.status = status1;
        }

        public Writers(DataRow drOfWriter)
        {
            this.writerId = Convert.ToInt32(drOfWriter["writerId"]);
            this.writerName = Convert.ToString(drOfWriter["writerName"]);
            this.status = Convert.ToBoolean(drOfWriter["status"]);
        }
        public Writers(int valueOfKey)
        {
            WritersTable writerTable = new WritersTable();
            DataRow drOfwriter = writerTable.find(valueOfKey);
            this.writerId = Convert.ToInt32(drOfwriter["writerId"]);
            this.writerName = Convert.ToString(drOfwriter["writerName"]);
            this.status = Convert.ToBoolean(drOfwriter["status"]);
        }
        public DataRow BuildRow()
        {
            DataRow dr = new WritersTable().Dt.NewRow();
            dr["writerId"] = this.writerId;
            dr["writerName"] = this.writerName;
            dr["status"] = this.status;
            return dr;
        }


    }
}
