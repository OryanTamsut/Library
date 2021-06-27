using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Sifria2010.BLL
{
    public class Content
    {
        private int contentId;
        private string contentName;
        private bool status;

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

        public int ContentId
        {
            get { return contentId; }
            set { contentId = value; }
        }

        public string ContentName
        {
            get { return contentName; }
            set
            {
                if (value == "")
                    throw new Exception("  הזן תוכן ");
                if (value[0] == ' ')
                    throw new Exception("שם תוכן לא מתחיל ברווח");
                contentName = value;
            }

        }

        public Content()
        { this.status = true; }

        public Content(int contentId1, string contentName1, bool status1)
        {
            this.contentId = contentId1;
            this.contentName = contentName1;
            this.status = status1;
        }
        public Content(DataRow drOfContent)
        {
            this.contentId = Convert.ToInt32(drOfContent["contentId"]);
            this.contentName = Convert.ToString(drOfContent["contentName"]);
            this.status = Convert.ToBoolean(drOfContent["status"]);
        }
        
        public Content(int valueOfKey)
        {
            ContentTable contentTable = new ContentTable();
            DataRow drOfContent = contentTable.find(valueOfKey);
            this.contentId = Convert.ToInt32(drOfContent["contentId"]);
            this.contentName = Convert.ToString(drOfContent["contentName"]);
            this.status = Convert.ToBoolean(drOfContent["status"]);
        }

        public DataRow BuildRow()
        {
            DataRow dr = new ContentTable().Dt.NewRow();
            dr["contentId"] = this.contentId;
            dr["contentName"] = this.contentName;
            dr["status"] = this.status;
            return dr;
        }

    }
}
