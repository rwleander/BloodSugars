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
        public int nAll = 0;

        public int avgBreakfast = 0;
        public int avgLunch = 0;
        public int avgSupper = 0;
        public int avgBedtime = 0;
        public int avgNight = 0;
        public int avgAll = 0;

        public const int LO = 80;
        public int loBreakfast = 0;
        public int loLunch = 0;
        public int loSupper = 0;
        public int loBedtime = 0;
        public int loNight = 0;
        public int loAll = 0;

        public const int HI = 200;
        public int hiBreakfast = 0;
        public int hiLunch = 0;
        public int hiSupper = 0;
        public int hiBedtime = 0;
        public int hiNight = 0;
        public int hiAll = 0;

        //  calculate stats

        public void calc(objSugarList lst, DateTime start, DateTime end)
        {
            int sumBreakfast = 0;
            int sumLunch = 0;
            int sumSupper = 0;
            int sumBedtime = 0;
            int sumNight = 0;
            int sumAll = 0;

            nBreakfast = 0;
            nLunch = 0;
            nSupper = 0;
            nBedtime = 0;
            nNight = 0;
            nAll = 0;

            avgBreakfast = 0;
            avgLunch = 0;
            avgSupper = 0;
            avgBedtime = 0;
            avgNight = 0;
            avgAll = 0;

            loBreakfast = 0;
            loLunch = 0;
            loSupper = 0;
            loBedtime = 0;
            loNight = 0;
            loAll = 0;

            hiBreakfast = 0;
            hiLunch = 0;
            hiSupper = 0;
            hiBedtime = 0;
            hiNight = 0;
            hiAll = 0;

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
                            if (itm.Sugar <= LO) loBreakfast++;
                            if (itm.Sugar >= HI) hiBreakfast++;
                            break;
                        case 10:
                        case 11:
                        case 12:
                        case 13:
                        case 14:
                            nLunch++;
                            sumLunch += itm.Sugar;
                            if (itm.Sugar <= LO) loLunch++;
                            if (itm.Sugar >= HI) hiLunch++;
                            break;
                        case 15:
                        case 16:
                        case 17:
                        case 18:
                            nSupper++;
                            sumSupper += itm.Sugar;
                            if (itm.Sugar <= LO) loSupper++;
                            if (itm.Sugar >= HI) hiSupper++;
                            break;
                        case 19:
                        case 20:
                        case 21:
                        case 22:
                            nBedtime++;
                            sumBedtime += itm.Sugar;
                            if (itm.Sugar <= LO) loBedtime++;
                            if (itm.Sugar >= HI) hiBedtime++;
                            break;
                        default:
                            nNight++;
                            sumNight += itm.Sugar;
                            if (itm.Sugar <= LO) loNight++;
                            if (itm.Sugar >= HI) hiNight++;
                            break;
                    }

                    nAll++;
                    sumAll += itm.Sugar;
                    if (itm.Sugar <= LO) loAll++;
                    if (itm.Sugar >= HI) hiAll++;
                }
            }

            if (nBreakfast > 0) avgBreakfast = sumBreakfast / nBreakfast;
            if (nLunch > 0) avgLunch = sumLunch / nLunch;
            if (nSupper > 0) avgSupper = sumSupper / nSupper;
            if (nBedtime > 0) avgBedtime = sumBedtime / nBedtime;
            if (nNight > 0) avgNight = sumNight / nNight;
            if (nAll > 0) avgAll = sumAll / nAll;
        }



    }
}
