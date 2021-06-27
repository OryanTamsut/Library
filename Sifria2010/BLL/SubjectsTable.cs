using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Sifria2010.BLL
{
    public class SubjectsTable : GeneralTableByAutoCode
    {
        public SubjectsTable()
            : base("subjects", "subjectId", true)
        { }

        public override void Update(DataRow from, DataRow to)
        {
            to.BeginEdit();
            to["subjectId"] = from["subjectId"];
            to["subjectName"] = from["subjectName"];
            to["status"] = from["status"];
            to.EndEdit();
        }
    }
}
