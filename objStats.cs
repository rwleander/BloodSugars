//  calculate statistics


using System;
using System.Collections.Generic;

namespace BloodSugars
{
    class objStats
    {
        public int nBreakfast = 0;
        public int nLunch = 0;
        public int nSupper = 0;
        public int nBedtime = 0;
        public int nNight = 0;

        public int avgBreakfast = 0;
        public int avgLunch = 0;
        public int avgSupper = 0;
        public int avgBedtime = 0;
        public int avgNight = 0;

        //  calculate stats

        public void calc(objSugarList lst, DateTime start, DateTime end)
        {
            int sumBreakfast = 0;
            int sumLunch = 0;
            int sumSupper = 0;
            int sumBedtime = 0;
            int sumNight = 0;

            nBreakfast = 0;
            nLunch = 0;
            nSupper = 0;
            nBedtime = 0;
            nNight = 0;

            avgBreakfast = 0;
            avgLunch = 0;
            avgSupper = 0;
            avgBedtime = 0;
            avgNight = 0;

            foreach (objSugar itm in lst.sugarList)
            {

                if ((itm.Time.Date >= start) && (itm.Time.Date <= end))
                {
                    switch (itm.Time.Hour)
                    {
                        case 6:
                        case 7:
                        case 8:
                        case 9:
                            nBreakfast++;
                            sumBreakfast += itm.Sugar;
                            break;
                        case 10:
                        case 11:
                        case 12:
                        case 13:
                        case 14:
                            nLunch++;
                            sumLunch += itm.Sugar;
                            break;
                        case 15:
                        case 16:
                        case 17:
                        case 18:
                            nSupper++;
                            sumSupper += itm.Sugar;
                            break;
                        case 19:
                        case 20:
                        case 21:
                        case 22:
                            nBedtime++;
                            sumBedtime += itm.Sugar;
                            break;
                        default:
                            nNight++;
                            sumNight += itm.Sugar;
                            break;
                    }
                }
            }

            if (nBreakfast > 0) avgBreakfast = sumBreakfast / nBreakfast;
            if (nLunch > 0) avgLunch = sumLunch / nLunch;
            if (nSupper > 0) avgSupper = sumSupper / nSupper;
            if (nBedtime > 0) avgBedtime = sumBedtime / nBedtime;
            if (nNight > 0) avgNight = sumNight / nNight;
        }



    }
}
