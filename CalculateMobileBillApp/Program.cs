using System;

namespace CalculateMobileBillApp
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal mobileBill = 0;

            DateTime pickHourOne = new DateTime(2019, 08, 31, 09, 00, 00);
            DateTime pickHourTwo = new DateTime(2019, 08, 31, 22, 59, 59);


            DateTime startTime = new DateTime(2019, 08, 31, 08, 59, 13);
            DateTime endTime = new DateTime(2019, 08, 31, 09, 00, 39);

            TimeSpan timeDifference = endTime - startTime;

            double callDuration = timeDifference.TotalSeconds / 20;

            for (double i = 0; i <= callDuration; i++)
            {
                startTime = startTime.AddSeconds(20);

                if (startTime >= pickHourOne && startTime <= pickHourTwo)
                {
                    mobileBill += 30;
                }
                else
                {
                    mobileBill += 20;
                }

            }
            Console.WriteLine(mobileBill / 100 + " taka");
        }
    }
}
