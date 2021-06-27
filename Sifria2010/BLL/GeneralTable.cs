using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Sifria2010.BLL
{
  public  class GeneralTable
    {
        protected DataTable dt;
        protected string keyName;
        protected Boolean isHasStatus;
        //שיטה בונה
        public GeneralTable(string tableName, string keyName1, Boolean isHasStatus1)
        {
            this.dt = DAL.DAL.GetTable(tableName);
            this.keyName = keyName1;
            this.isHasStatus = isHasStatus1;
        }
        //מחזיר העתק טבלה
        public DataTable GetTable()
        {
            if (isHasStatus)
                return DAL.DAL.GetQuery("select * from " + this.dt.TableName + " where Status=true");
            else
                return DAL.DAL.GetQuery("select * from " + this.dt.TableName);
        }
        //מחזיר את הטבלה בעצמה
        public DataTable Dt
        {
            get { return dt; }
            set { dt = value; }
        }
        //מחזיר שורה מבוקשת ע"פ ערך שדה מזהה
        public  DataRow find(object volueOfKey)
        {
            foreach (DataRow row in this.dt.Rows)
            {
                if (row[keyName].Equals(volueOfKey))
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
        //מוסיף שורה לטבלה
        public  bool Add(DataRow drToAdd)
        {
            foreach (DataRow row in this.dt.Rows)
            {
                if (IsSameKeys(drToAdd, row))
                    if (this.isHasStatus)
                        if (row["status"].ToString() == "True")
                            return false;
                        else
                        {
                            Update(drToAdd, row);
                            DAL.DAL.Update(this.dt.TableName);
                            return true;
                        }
                    else return false;
            }
            this.dt.Rows.Add(drToAdd);
            DAL.DAL.Update(this.dt.TableName);
            return true;
        }
        //שיטת עזר רק בשביל ההפניה אבל באמת דורסים אותה
        public virtual void Update(DataRow from, DataRow to)
        {
        }
        //מעדכן את השורה המבוקשת  
        public  bool Update(DataRow drToUpdate)
        {
            foreach (DataRow row in this.dt.Rows)
            {
                if (IsSameKeys(drToUpdate, row))
                {
                    if (this.isHasStatus)
                        if (row["status"].Equals("False")) return false;
                        else
                        {
                            Update(drToUpdate, row);
                            DAL.DAL.Update(this.dt.TableName);
                            return true;
                        }
                    else
                    {
                        Update(drToUpdate, row);
                        DAL.DAL.Update(this.dt.TableName);
                        return true;
                    }
                }
            }
            return false;
        }
        //מוחק את השורה המבוקשת
        public bool Delete(DataRow drToDelete)
        {
            foreach (DataRow row in this.dt.Rows)
            {
                if (IsSameKeys(drToDelete, row))
                {
                    if (this.isHasStatus)
                    {
                        if (row["status"].Equals("False")) return false;
                        else
                        {
                            row["status"] = false;
                            DAL.DAL.Update(this.dt.TableName);
                            return true;
                        }
                    }
                    row.Delete();
                    DAL.DAL.Update(this.dt.TableName);
                    return true;
                }
            }
            return false;
        }

        public  virtual bool IsSameKeys(DataRow dr1, DataRow dr2)
        {
            return dr1[this.keyName].Equals(dr2[this.keyName]);
        }


        public virtual DataTable GetTableForCombobox(string fieldName1, string fieldName2)
        {//" fullName".  פעולה זו מקבלת שמות של שתי שדות (לדוג: שם פרטי ושם משפחה) ומחזירה טבלה המכילה שתי עמודות הראשונה תכיל את השדה מפתח והשניה תכיל שרשור של השדה מפתח, העמודה הראשונה והעמודה השניה. שם העמודה השניה הוא  
            string st;
            if (this.isHasStatus == true)
                st = "SELECT " + this.keyName + ", [" + this.keyName + "] & ' - ' & [" + fieldName1 + "] & ' '& [" + fieldName2 + "] AS FullName FROM " + this.dt.TableName + " where status=true";
            else
                st = "SELECT " + this.keyName + ", [" + this.keyName + "] & ' - ' & [" + fieldName1 + "] & ' '& [" + fieldName2 + "] AS FullName FROM " + this.dt.TableName;
            return DAL.DAL.GetQuery(st);
        }
    }
}
