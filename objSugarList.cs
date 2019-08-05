//  objSugarList.cs - list of all blood sugar readings

using System;
using System.Collections.Generic;
using System.Data;

namespace BloodSugars
{
    public class objSugarList : objDatabase
    {

        //  public collections and fields

        public List<objSugar> sugarList = new List<objSugar>();

        public int Count
        {
            get
            {
                return sugarList.Count;
            }
        }

        public DateTime Start
        {
            get
            {
                if (Count > 0)
                {
                    return sugarList[Count - 1].Time;
                }
                else
                {
                    return DateTime.Today;
                }
            }
        }

        public DateTime End
        {
            get
            {
                if (Count > 0)
                {
                    return sugarList[0].Time;
                }
                else
                {
                    return DateTime.Today;
                }
            }
        }


        //  constructors - fills the list

        public objSugarList()
        {
            LoadData();
        }

        //  fill the list

        public int LoadData()
        {
            objSugar sugar = new objSugar(); ;
            DataSet ds;

            //  clear the list

            sugarList.Clear();

            //  get the data

            try
            {
                ds = sugar.GetAll();
            }
            catch
            {
                throw;
            }

            //  fill the list

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                sugar = new objSugar(row);
                sugarList.Add(sugar);
            }

            return Count;
        }

    }
}
