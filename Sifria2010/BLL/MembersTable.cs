using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Sifria2010.BLL
{
    public class MembersTable: GeneralTableByAutoCode 
    {
        public MembersTable()
            : base("members", "memberId", true)
        { }

        public override void Update(DataRow from, DataRow to)
        {
            to.BeginEdit();

            to["memberId"] = from["memberId"];
            to["firstNameMember"] = from["firstNameMember"];
            to["lastNameMember"] = from["lastNameMember"];
            to["street"] = from["street"];
            to["homeNumber"] = from["homeNumber"];
            to["city"] = from["city"];
            to["birthDay"] = from["birthDay"];
            to["phonA"] = from["phonA"];
            to["phonB"] = from["phonB"];
            to["numBooksForlending"] = from["numBooksForlending"];
            to["fine"] = from["fine"];
            to["lastDateForFineUpdate"] = from["lastDateForFineUpdate"];
            to["status"] = from["status"];
            to["isralId"] = from["isralId"];
            to.EndEdit();
        }
        public int findMemberByFnLnPhon(string fn, string ln, string phon)
        {
            
            foreach (DataRow row in this.dt.Rows)
            {
                if (((Convert.ToString (row["firstNameMember"])==Convert.ToString (fn))&&(Convert.ToString (row["lastNameMember"])==Convert.ToString (ln)))&&((Convert.ToString ((row["phonA"]))==Convert.ToString(phon))||(Convert.ToString (row["phonB"])==Convert.ToString(phon))))
                    if (this.isHasStatus == true)
                        if (row["status"].ToString() == "True")
                            return Convert.ToInt32 (row["memberId"]);
                        else
                            return 0;
                    else
                        return Convert.ToInt32(row["memberId"]);
            }
            return 0;
        }

        public override bool IsSameKeys(DataRow dr1, DataRow dr2)
        {
            if (dr1["isralId"].Equals(dr2["isralId"])) return true;
            else return false;
        }
        
        public  DataRow findById(string isralId)
        {
            foreach (DataRow row in this.dt.Rows)
            {
                if (row["isralId"].Equals(isralId))
                    if (this.isHasStatus == true)
                        if (row["status"].ToString() == "True")
                            return row;
                        else
                            return null;
                    else
                        return row;
            }
            return null;
        }
    }
}
