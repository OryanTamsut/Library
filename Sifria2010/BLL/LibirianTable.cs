using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Sifria2010.BLL
{
   public class LibirianTable:GeneralTable
    {
        public LibirianTable()
            : base("libirian", "libirianId", true)
        { }


        public override void Update(DataRow from, DataRow to)
        {
            to.BeginEdit();
            to["libirianId"] = from["libirianId"];
            to["libirianFirstName"] = from["libirianFirstName"];
            to["libirianLastName"] = from["libirianLastName"];
            to["passward"] = from["passward"];
            to["status"] = from["status"];
            to.EndEdit();
        }
    }
}
