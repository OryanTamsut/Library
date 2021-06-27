using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace Sifria2010.BLL
{
   public class WritersTable:GeneralTableByAutoCode
    {
        public WritersTable()
            : base("writers", "writerId", true)
        { }

        public override void Update(DataRow from, DataRow to)
        {
            to.BeginEdit();
            to["writerId"] = from["writerId"];
            to["writerName"] = from["writerName"];
            to["status"] = from["status"];
            to.EndEdit();

        }


    }
}
