using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Sifria2010.DAL
{  
    public static class DAL
    {
        private static DataSet ds;
        private static OleDbConnection con;

        public static void ConnectToDB()
        {
            
            string st = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+Application.StartupPath+"/sifriya.mdb";
            con = new OleDbConnection(st);

            ds = new DataSet();
            string[] Name = new string[] { "books", "content", "copies", "copiesInLending", "finePaying", "information", "lending", "members", "subjects", "writers", "libirian" };
            for (int i = 0; i < Name.Length; i++) AddTable(Name[i]);
        }

        public static void AddTable(string TableName)
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter("select * from " + TableName, con);
            adapter.Fill(ds, TableName);

        }
        public static void Update(string tableName)
        {
            OleDbDataAdapter adpt = new OleDbDataAdapter("select * from " + tableName, con);

            OleDbCommandBuilder builder = new OleDbCommandBuilder(adpt);
            adpt.InsertCommand = builder.GetInsertCommand();
            adpt.DeleteCommand = builder.GetDeleteCommand();
            adpt.UpdateCommand = builder.GetUpdateCommand();
            adpt.Update(ds, tableName);
        }

        public static DataTable GetQuery(string sqlstr)
        {
            
            OleDbDataAdapter adpt = new OleDbDataAdapter(sqlstr, con);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
        }

        public static DataTable GetTable(string tableName)
        {
            
            return ds.Tables[tableName];
        }


    }

}
