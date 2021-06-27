using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Sifria2010.BLL
{
    public class ContentTable : GeneralTableByAutoCode
    {
        public ContentTable()
            : base("content", "contentId", true)
        { }

        public override void Update(DataRow from, DataRow to)
        {
            to.BeginEdit();
            to["contentId"] = from["contentId"];
            to["contentName"] = from["contentName"];
            to["status"] = from["status"];
            to.EndEdit();

        }


    }
}
