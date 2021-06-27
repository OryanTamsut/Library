using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Sifria2010.BLL
{
   public class Members
    {
        private int memberId;
        public int MemberId
        {
            get { return memberId; }
            set { memberId = value; }
        }
        
        private string firstNameMember;
        public string FirstNameMember
        {
            get { return firstNameMember; }
            set
            {
                if (value == "")
                    throw new Exception("הזן שם פרטי");
                if (value[0] == ' ')
                    throw new Exception("שם פרטי לא מתחיל ברווח");
                firstNameMember = value;
            }
        }
       
       private string lastNameMember;
        public string LastNameMember
        {
            get { return lastNameMember; }
            set
            {
                if (value == "")
                    throw new Exception("הזן שם משפחה");
                if (value[0] == ' ')
                    throw new Exception("שם משפחה לא מתחיל ברווח");
                lastNameMember = value;
            }
        }
        
       private string street;
        public string Street
        {
            get { return street; }
            set
            {
                if (value == "")
                    throw new Exception("הזן שם רחוב");
                if (value[0] == ' ')
                    throw new Exception("שם רחוב לא מתחיל ברווח");
                 street= value;
            }
        }
       
       private int homeNumber;
        public int HomeNumber
        {
            get { return homeNumber; }
            set
            {
                if (value < 0)
                    throw new Exception("מספר בית צריך להיות יותר גדול מ-0");
                homeNumber = value;
            }
        }
        
       private string city;
        public string City
        {
            get { return city; }
            set
            {
                if (value == "")
                    throw new Exception("הזן שם עיר");
                if (value[0] == ' ')
                    throw new Exception("שם עיר לא מתחיל ברווח");
                city = value;
            }
        }
        
       private DateTime birthDay;
       public DateTime BirthDay
        {
            get { return birthDay; }
            set 
            {
                    birthDay = value; 
            }
        }
        
       private string phonA;
        public string PhonA
        {
            get { return phonA; }
            set
            {
                if (value == "")
                    throw new Exception(" הזן מספר טלפון");
                if (value[0] == ' ')
                    throw new Exception("מספר טלפון לא מתחיל ברווח");
                if (value.Length < 9)
                    throw new Exception("הזן מספר באורך תקין");
                if (!value[0].Equals('0'))
                    throw new Exception("מספר טלפון צריך להתחיל ב-0");
                phonA = value;
                
            }
        }
        
       private string phonB;
        public string PhonB
        {
            get { return phonB; }
            set
            {
                if (value == "")
                    throw new Exception(" הזן מספר טלפון");
                if (value[0] == ' ')
                    throw new Exception("מספר טלפון לא מתחיל ברווח");
                if (!value[0].Equals('0'))
                    throw new Exception("מספר טלפון צריך להתחיל ב-0");
                if (value.Length < 9)
                    throw new Exception("הזן מספר באורך תקין");
                phonB = value;
            }
        }
        
       private int numBooksForlending;
       public int NumBooksForlending
        {
            get { return numBooksForlending; }
            set
            {
                if (value < 0)
                    throw new Exception("מספר הספרים להשאלה צריך להיות יותר גדול מ-0");
                numBooksForlending = value;
            }
        }
      
       private double fine;
       public double Fine
        {
            get { return Fine; }
            set { Fine = value; }
        }
      
       private DateTime lastDateForFineUpdate;
      public DateTime LastDateForFineUpdate
        {
            get { return lastDateForFineUpdate; }
            set { lastDateForFineUpdate = value; }
        }
      
       private bool status;
         public bool Status
        {
            get { return status; }
            set { status = value; }
        }
        private string isralId;
        public string IsraelId
        {
            get { return isralId; }
            set
            {
                if (Isid(value) == false)
                    throw new Exception("תעודת זהות לא חוקית");
                isralId = value;
            }
        }


       public Members()
        {
            this.status = true;
            this.fine = 0.0;
        }
       
       public Members( int memberId1,string firstNameMember1,string lastNameMember1,string street1,int homeNumber1,string city1,DateTime birthDay1,string phonA1,string phonB1,int numBooksForlending1,double fine1,DateTime lastDateForFineUpdate1,bool status1,string israelId )
       {
           
           this.memberId = memberId1;
           this.firstNameMember =firstNameMember1 ;
           this.lastNameMember =lastNameMember1 ;
           this.street =street1 ;
           this.homeNumber =homeNumber1 ;
           this.city =city1 ;
           this.birthDay =birthDay1 ;
           this.phonA = phonA1;
           this.phonB =phonB1 ;
           this.numBooksForlending =numBooksForlending1 ;
           this.fine =fine1 ;
           this.lastDateForFineUpdate = lastDateForFineUpdate1;
           this.status = status1;
            this.isralId = IsraelId;
       }
       public Members(DataRow drOfMembers)
        {
            
            this.memberId = Convert.ToInt32(drOfMembers["memberId"]);
            this.firstNameMember= Convert.ToString(drOfMembers["firstNameMember"]);
           this.lastNameMember= Convert.ToString (drOfMembers["lastNameMember"]);
           this.street = Convert.ToString(drOfMembers["street"]);
           this.homeNumber= Convert.ToInt32(drOfMembers["homeNumber"]);
           this.city = Convert.ToString(drOfMembers["city"]);
           this.birthDay= Convert.ToDateTime(drOfMembers["birthDay"]);
           this.phonA = Convert.ToString(drOfMembers["phonA"]);
           this.phonB = Convert.ToString(drOfMembers["phonB"]);
           this.numBooksForlending = Convert.ToInt32(drOfMembers["numBooksForlending"]);
           this.fine= Convert.ToDouble(drOfMembers["fine"]);
           if(drOfMembers["lastDateForFineUpdate"].ToString()!="")
           this.lastDateForFineUpdate= Convert.ToDateTime(drOfMembers["lastDateForFineUpdate"]);
           this.status = Convert.ToBoolean(drOfMembers["status"]);
            this.isralId = Convert.ToString(drOfMembers["isralId"]);
        }
       public DataRow BuildRow()
       {
           DataRow dr = new MembersTable().Dt.NewRow();
           
           dr["memberId"] = this.memberId;
           dr["firstNameMember"] = this.firstNameMember;
           dr["lastNameMember"] = this.lastNameMember;
           dr["street"] = this.street;
           dr["homeNumber"] = this.homeNumber;
           dr["city"] = this.city;
           dr["birthDay"] = this.birthDay;
           dr["phonA"] = this.phonA;
           dr["phonB"] = this.phonB;
           dr["numBooksForlending"] = this.numBooksForlending;
           dr["fine"] = this.fine;
           dr["lastDateForFineUpdate"] = this.lastDateForFineUpdate;
           dr["status"] = this.status;
            dr["isralId"] = this.isralId;
            return dr;
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

    }
}
