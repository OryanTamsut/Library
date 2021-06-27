using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Sifria2010.BLL
{
  public  class Libirian
    {
        private LibirianTable myLibrianTable;

        public LibirianTable MyLibrianTable
        {
            get { return myLibrianTable; }
            set { myLibrianTable = new LibirianTable(); }
        }
        private String libirianId;
        private bool status; 
        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

        public string LibirianId
        {
            get { return libirianId; }
            set
            {
                if (Isid(Convert.ToString(value)) == false)
                    throw new Exception("תעודת זהות לא חוקית");
                libirianId = value;
            }
        }
        private string libirianFirstName;

        public string LibirianFirstName
        {
            get { return libirianFirstName; }
            set
            {
                if (value == "")
                    throw new Exception("הזן שם ספרנית");
                if (value[0] == ' ')
                    throw new Exception("שם הספרנית לא מתחיל ברווח");
                libirianFirstName = value;
            }
        }
        private string libirianLastName;

        public string LibirianLastName
        {
            get { return libirianLastName; }
            set
            {
                if (value == "")
                    throw new Exception("הזן שם ספרנית");
                if (value[0] == ' ')
                    throw new Exception("שם הספרנית לא מתחיל ברווח");
                libirianLastName = value;
            }
        }
        private string passward;

        public string Passward
        {
            get { return passward; }
            set
            {
                if (value == "")
                    throw new Exception("הזן סיסמא");
                if (value[0] == ' ')
                    throw new Exception("סיסמא לא מתחיל ברווח");
                if (value.Length<4)
                    throw new Exception("סיסמא מכילה לפחות 4 תווים");
               passward = value;
            }
        }

        public bool IsEqual(DataRow drToCheck)
        {
            DataRow realDr = null;
            myLibrianTable = new LibirianTable();
            if (myLibrianTable.find(drToCheck["libirianId"]) != null) { realDr = myLibrianTable.find(drToCheck["libirianId"]); }
            if (realDr != null)
            {
                if (Convert.ToString(drToCheck["passward"]) == Convert.ToString(realDr["passward"])) return true;
            }
                return false;
        }

        public bool Isid(string id)
        {
            int mikum = 0;
            int[] a = new int[9];
            int sum = 0; int temp = 0;
            for (int i = 0; i < 9; i++) a[i] = 0;
            for (int i = (a.Length - id.Length); i < 9; i++) { a[i] = Convert.ToInt32(id[mikum] - '0'); mikum++; }

            for (int i = 0; i < 9; i++)
            {

                if (i % 2 == 0) sum += a[i];

                else
                {

                    temp = a[i] * 2;
                    if (temp > 9) { temp = temp % 10 + temp / 10; }
                    sum += temp;
                }
            }
            if (sum % 10 == 0) return true;
            else return false;


        }

        public Libirian()
        { this.status = true; }
        public Libirian(string libirianId1, string libirianFirstName1, string libirianLastName1, string Passward1,bool status1)
        {
            this.libirianId = libirianId1;
            this.libirianFirstName = libirianFirstName1;
            this.libirianLastName = libirianLastName1;
            this.passward = Passward1;
            this.status = status1;
        }
        public Libirian(string libirianId1, string Passward1)
        {
            this.libirianId = libirianId1;
            this.passward = Passward1;
            this.libirianFirstName = "";
            this.libirianLastName = "";
        }
        public Libirian(DataRow drOfLibirian)
        {
            this.libirianId = Convert.ToString(drOfLibirian["libirianId"]);
            this.libirianFirstName = Convert.ToString(drOfLibirian["libirianFirstName"]);
            this.libirianLastName = Convert.ToString(drOfLibirian["libirianLastName"]);
            this.Passward = Convert.ToString(drOfLibirian["Passward"]);
            this.status = Convert.ToBoolean(drOfLibirian["status"]);
        }
        public DataRow BuildRow()
        {
            DataTable dt = new LibirianTable().Dt;
            DataRow dr = dt.NewRow();
            dr["libirianId"] = this.libirianId;
            dr["libirianFirstName"] = this.libirianFirstName;
            dr["libirianLastName"] = this.libirianLastName;
            dr["Passward"] = this.Passward;
            dr["status"] = this.status;
            return dr;
        }
  
  }
}
