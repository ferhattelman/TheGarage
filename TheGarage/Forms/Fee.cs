using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGarageV3.Forms
{
    internal class Fee
    {
        public decimal ParkingFee(string loc, int totalHours)
        {
            decimal fee = 0;
            decimal startingPrice = 0;
            decimal extraPrice = 0;

            string[] marmara = { "Istanbul", "Bursa" };
            string[] ege = { "Mugla", "Izmir" };
            string[] akdeniz = { "Antalya", "Adana" };
            string[] dogu = { "Van", "Erzurum" };


            for (int i = 0; i < marmara.Length; i++)
            {
                if (loc == marmara[i])
                {
                    startingPrice = 50m;
                    extraPrice = 20m;
                    fee = startingPrice;

                    if (totalHours > 1)
                    {
                        fee += extraPrice * (decimal)(totalHours - 1);
                    }

                }
            }

            for (int i = 0; i < ege.Length; i++)
            {
                if (loc == ege[i])
                {
                    startingPrice = 45m;
                    extraPrice = 20m;
                    fee = startingPrice;

                    if (totalHours > 1)
                    {
                        fee += extraPrice * (decimal)(totalHours - 1);
                    }

                }
            }

            for (int i = 0; i < akdeniz.Length; i++)
            {
                if (loc == akdeniz[i])
                {
                    startingPrice = 45m;
                    extraPrice = 15m;
                    fee = startingPrice;

                    if (totalHours > 1)
                    {
                        fee += extraPrice * (decimal)(totalHours - 1);
                    }

                }
            }

            for (int i = 0; i < dogu.Length; i++)
            {
                if (loc == dogu[i])
                {
                    startingPrice = 30m;
                    extraPrice = 10m;
                    fee = startingPrice;

                    if (totalHours > 1)
                    {
                        fee += extraPrice * (decimal)(totalHours - 1);
                    }

                }
            }

            return fee;
        }
    }
}
