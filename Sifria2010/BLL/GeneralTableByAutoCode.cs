using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Sifria2010.BLL
{
   public class GeneralTableByAutoCode : GeneralTable
    {
        public GeneralTableByAutoCode(string tableName2, string keyName2, bool isHasStatus2)
            : base(tableName2, keyName2, isHasStatus2)
        { }

        public int GetNextKod()
        {
            int max = 0;
            foreach (DataRow row in this.dt.Rows)
            {
                if (Convert.ToInt32(row[this.keyName]) > max) max = Convert.ToInt32(row[this.keyName]);

            }
            return max + 1;
        }

    }
}
