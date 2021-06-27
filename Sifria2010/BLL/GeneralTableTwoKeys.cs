using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Sifria2010.BLL
{
    public class GeneralTableTwoKeys : GeneralTable
    {
        private string anotherKeyName;
        public GeneralTableTwoKeys(string tableName, string keyName1, string keyName2, bool isHasStatus1)
            : base(tableName, keyName1, isHasStatus1)
        {
            this.anotherKeyName = keyName2;
        }

        public DataRow find(object valueOfKey1, object valueOfKey2)
        {
            foreach (DataRow row in this.dt.Rows)
            {
                if (row[keyName].Equals(valueOfKey1) && row[this.anotherKeyName].Equals(valueOfKey2))
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

        public override bool IsSameKeys(DataRow dr1, DataRow dr2)
        {
            return base.IsSameKeys(dr1, dr2) && dr1[this.anotherKeyName].Equals(dr2[this.anotherKeyName]);
        }
    }
}

