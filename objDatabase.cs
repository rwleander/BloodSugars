//  objDatabase.cs - base class for MS/Access database tables

using System;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.IO;

namespace BloodSugars
{
    public class objDatabase
    {

        //  create a database connection

        public OleDbConnection CreateConnection()
        {
            string dataPath, dbName;

            //  get the configuration values

            dataPath = ConfigurationManager.AppSettings["DataPath"];
            dbName = ConfigurationManager.AppSettings["Database"];

            //  create the connection string

            string connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=";
            connString += Path.Combine(dataPath, dbName) + ";";

            //  open the connection 

            OleDbConnection conn = new OleDbConnection();
            try
            {
                conn.ConnectionString = connString;
                conn.Open();
                return conn;
            }
            catch
            {
                throw;
            }
        }

        //  fill a data set

        public DataSet FillDataset(OleDbCommand cmd)
        {
            OleDbConnection conn;
            OleDbDataAdapter dap = new OleDbDataAdapter();
            DataSet ds = new DataSet();

            //  get a connection

            try
            {
                conn = CreateConnection();
            }
            catch
            {
                throw;
            }

            //  fill the data set

            try
            {
                dap.SelectCommand = cmd;
                dap.SelectCommand.Connection = conn;
                dap.Fill(ds);
                return ds;
            }
            catch
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        //  safely retrieve data

        public int GetRowInt(DataRow row, string fld)
        {
            try
            {
                if (row.IsNull(fld))
                {
                    return 0;
                }
                else
                {
                    return (int)row[fld];
                }
            }
            catch
            {
                return -1;
            }
        }

        protected DateTime GetRowDate(DataRow row, string fld)
        {
            try
            {
                if (row.IsNull(fld))
                {
                    return DateTime.MinValue;
                }
                else
                {
                    return (DateTime)row[fld];
                }
            }
            catch
            {
                return DateTime.MinValue;
            }
        }



    }
}
