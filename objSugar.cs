//  objSugar.cs - blood sugar measurement

using System;
using System.Data;
using System.Data.OleDb;

namespace BloodSugars
{
    public class objSugar : objDatabase
    {

        //  public fields

        public int ID = 0;
        public DateTime Time = DateTime.MinValue;
        public int Sugar = 0;
        public int LongTerm = 0;
        public int ShortTerm = 0;

        public bool isOnFile = false;


        //  constructors

        public objSugar()
        {
        }

        //  get by id

        public objSugar(int num)
        {
            Load(num);
        }

        //  create from data row

        public objSugar(DataRow row)
        {
            LoadFields(row);
        }

        //  get all records

        public DataSet GetAll()
        {

            //  determine date

            int yy = DateTime.Now.Year - 1;
            String dateString = "1/1/" + yy.ToString();

            //  create the search command

            OleDbCommand cmd = new OleDbCommand("Select * from Sugars WHERE time >= #" + dateString + "# Order by Time desc;");

            //  get the data

            try
            {
                return FillDataset(cmd);
            }
            catch
            {
                throw;
            }
        }

        //  load by id

        public bool Load(int num)
        {
            OleDbCommand cmd;
            DataSet ds;

            //  create the search command

            string sql = "Select * from Sugars ";
            sql += "Where ID = @ID;";

            cmd = new OleDbCommand(sql);
            cmd.Parameters.Add(new OleDbParameter("@ID", num));

            //  fill the data set

            try
            {
                ds = FillDataset(cmd);
            }
            catch
            {
                throw;
            }

            //  see what we found

            if (ds.Tables[0].Rows.Count > 0)
            {
                LoadFields(ds.Tables[0].Rows[0]);
            }
            else
            {
                isOnFile = false;
            }

            return isOnFile;
        }

        //  load by date/'time

        public bool LoadByTime(DateTime time)
        {
            OleDbCommand cmd;
            DataSet ds;

            //  create the search command

            string sql = "Select * from Sugars ";
            sql += "Where Time = @time;";

            cmd = new OleDbCommand(sql);
            cmd.Parameters.Add(new OleDbParameter("@time", time));

            //  fill the data set

            try
            {
                ds = FillDataset(cmd);
            }
            catch
            {
                throw;
            }

            //  see what we found

            if (ds.Tables[0].Rows.Count > 0)
            {
                LoadFields(ds.Tables[0].Rows[0]);
            }
            else
            {
                isOnFile = false;
            }

            return isOnFile;
        }

        //  add a new entry

        public void Add()
        {
            OleDbConnection conn;
            OleDbCommand cmd;

            //  create the command string

            string sql = "Insert into Sugars ";
            sql += "([Time], Sugar, LongTerm, ShortTerm) ";
            sql += "values ";
            sql += "(@time, @sugar, @longTerm, @shortTerm);";

            //  open a connection

            try
            {
                conn = CreateConnection();
            }
            catch
            {
                throw;
            }

            //  create and execute the insert command

            try
            {
                cmd = CreateCommand(sql, conn);
                cmd.ExecuteNonQuery();
                isOnFile = true;
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

        //  update

        public void Update()
        {
            OleDbConnection conn;
            OleDbCommand cmd;

            //  create the update command string

            string sql = "Update Sugars ";
            sql += "Set [Time] = @time, ";
            sql += "Sugar = @sugar, ";
            sql += "LongTerm = @longTerm, ";
            sql += "ShortTerm = @shortTerm ";
            sql += "Where ID = @ID;";

            //  open a connection

            try
            {
                conn = CreateConnection();
            }
            catch
            {
                throw;
            }

            //  create and execute the command

            try
            {
                cmd = CreateCommand(sql, conn);
                cmd.Parameters.Add(new OleDbParameter("@ID", ID));
                cmd.ExecuteNonQuery();
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

        //  add or update as needed

        public void Save()
        {
            if (isOnFile == true)
            {
                Update();
            }
            else
            {
                Add();
            }
        }

        //  delete

        public void Delete()
        {
            OleDbConnection conn;
            OleDbCommand cmd;

            //  create the delete string

            string sql = "Delete from Sugars ";
            sql += "Where ID = @ID;";

            //  open the connection

            try
            {
                conn = CreateConnection();
            }
            catch
            {
                throw;
            }

            //  create and execute the delete command

            try
            {
                cmd = new OleDbCommand(sql, conn);
                cmd.Parameters.Add(new OleDbParameter("@ID", ID));
                cmd.ExecuteNonQuery();
                isOnFile = false;
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

        //  private methods

        //  load from data row

        private void LoadFields(DataRow row)
        {
            ID = GetRowInt(row, "ID");
            Time = GetRowDate(row, "Time");
            Sugar = GetRowInt(row, "Sugar");
            ShortTerm = GetRowInt(row, "ShortTerm");
            LongTerm = GetRowInt(row, "LongTerm");
            isOnFile = true;
        }

        //  create the add/update command

        private OleDbCommand CreateCommand(string sqlText, OleDbConnection conn)
        {
            OleDbCommand cmd = new OleDbCommand(sqlText, conn);
            cmd.Parameters.Add(new OleDbParameter("@time", Time));
            cmd.Parameters.Add(new OleDbParameter("@Sugar", Sugar));
            cmd.Parameters.Add(new OleDbParameter("@longTerm", LongTerm));
            cmd.Parameters.Add(new OleDbParameter("@shortTerm", ShortTerm));
            return cmd;
        }

    }
}
