//  objMeter.cs - methods to read glucometer

using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO.Ports;

namespace BloodSugars
{
    class objMeter
    {

        //  public fields and collections

        public List<objSugar> sugarList = new List<objSugar>();

        //  private fields

        private string commPort = "";


        //  public constructors

        public objMeter()
        {
            commPort = ConfigurationManager.AppSettings["CommPort"];
        }

        //  read the meter and fill the list

        public int Load()
        {
            SerialPort port = null;
            string buff = "";
            bool eof = false;
            int n = 0;

            //  clear the list

            sugarList.Clear();

            //  open the serial port

            try
            {
                port = new SerialPort(commPort);
                port.ReadTimeout = 5000;
                port.Open();
            }
            catch
            {
                throw;
            }


            //  load the blood sugars from the meter

            try
            {
                while (eof == false)
                {
                    buff = port.ReadLine();
                    if (buff == null)
                    {
                        eof = true;
                    }
                    else
                    {
                        addSugar(buff);
                        n++;
                    }
                }
            }
            catch
            {
                if (n == 0)
                {
                    throw;
                }
            }
            finally
            {
                port.Close();
            }

            return sugarList.Count;
        }

        //------------------
        //   private methods

        //  parse the data from the line read from the comm port and add to the sugar list

        private void addSugar(string buff)
        {
            objSugar sugar = new objSugar();
            string y, m, d, hh, mm, s;

            //  split fields byy commas

            string[] itms = buff.Split(',');
            if (itms.Length < 7)
            {
                return;
            }

            //  convert text to sugar structure

            y = itms[1];
            m = itms[2];
            d = itms[3];
            hh = itms[4];
            mm = itms[5];
            s = itms[6];

            //  convert time

            try
            {
                sugar.Time = DateTime.Parse(m + "/" + d + "/" + y + " " + hh + ":" + mm);
                sugar.Sugar = int.Parse(s);
            }
            catch
            {
                return;
            }

            sugarList.Add(sugar);
        }

    }
}
