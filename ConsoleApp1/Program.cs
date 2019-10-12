using System;

namespace ConsoleApp1
{
    using System;

    namespace CostCall
    {
        class Program
        {
            // Peak hour, min, sec
            public static DateTime peakStart = new DateTime(1, 1, 1, 9, 0, 0);
            public static DateTime peakEnd = new DateTime(1, 1, 1, 10, 59, 59);
            static void Main(string[] args)
            {
                //Call Start date and end date. Please edit for other test case.
                DateTime startDate = new DateTime(2019, 08, 31, 8, 59, 13);
                DateTime endDate = new DateTime(2019, 08, 31, 9, 0, 39);

                double cost = 0;

                //call rate and pulse
                Double peakCallRate = 0.30;
                Double offpeakCallRate = 0.20;
                Double pulse = 20;
                
                while (endDate > startDate)
                {
                    DateTime callEndTime = startDate.AddSeconds(pulse);
                    if (callEndTime > endDate)
                    {
                        callEndTime = endDate;
                    }
                    startDate = callEndTime;
                    if (IsPeak(startDate) || IsPeak(callEndTime))
                    {
                        cost = cost + peakCallRate;
                    }
                    else
                    {
                        cost = cost + offpeakCallRate;
                    }
                }
                
                Console.WriteLine(cost);
                Console.ReadKey();
            }
            public static bool IsPeak(DateTime date)
            {
                
                if (date.Hour >= peakStart.Hour && date.Hour <= peakEnd.Hour)
                {
                    if (date.Minute >= peakStart.Minute && date.Minute <= peakEnd.Minute)
                    {
                        if (date.Second >= peakStart.Second && date.Minute <= peakEnd.Minute)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
                
            }

        }
    }

}
