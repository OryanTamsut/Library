using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Sifria2010.BLL
{
    public class Subjects
    {
        private int subjectId;
        private string subjectName;
        private bool status;

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

        public int SubjectId 
        { 
            get { return subjectId;} 
            set { subjectId = value;} 
        }
        public string SubjectName 
        {
            get { return subjectName; }
            set { subjectName = value; } 
        }


        public Subjects()
        { this.status = true; }
        public Subjects(int subjectId1, string subjectName1, bool status1)
        {
            this.subjectId = subjectId1;
            this.subjectName = subjectName1;
            this.status = status1;
        }

        public Subjects(DataRow drOfContent)
        {
            this.subjectId = Convert.ToInt32(drOfContent["subjectId"]);
            this.subjectName = Convert.ToString(drOfContent["subjectName"]);
            this.status = Convert.ToBoolean(drOfContent["status"]);
        }
        //צריך לבדוק אם עובד
        public Subjects(int valueOfKey)
        {
            SubjectsTable subjectTable = new SubjectsTable();
            DataRow drOfsubject = subjectTable.find(valueOfKey);
            this.subjectId = Convert.ToInt32(drOfsubject["subjectId"]);
            this.subjectName = Convert.ToString(drOfsubject["subjectName"]);
            this.status = Convert.ToBoolean(drOfsubject["status"]);
        }
        public DataRow BuildRow()
        {
            DataRow dr = new SubjectsTable().Dt.NewRow();
            dr["subjectId"] = this.subjectId;
            dr["subjectName"] = this.subjectName;
            dr["status"] = this.status;
            return dr;
        }
    }
}
