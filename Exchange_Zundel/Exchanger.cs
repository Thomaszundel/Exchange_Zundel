using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange_Zundel
{
    
    static class Exchanger
    {
        public static decimal US_GBP(decimal inputAmt)
        {
            return inputAmt * 0.72523m;
        }
        public static decimal US_CAN(decimal inputAmt)
        {
            return inputAmt * 1.25427m;
        }
        public static decimal US_EUR(decimal inputAmt)
        {
            return inputAmt * 0.83572m;
        }
        public static decimal GBP_US(decimal inputAmt)
        {
            return inputAmt * 1.37887m;
        }
        public static decimal GBP_CAN(decimal inputAmt)
        {
            return inputAmt * 1.72947m;
        }
        public static decimal GBP_EUR(decimal inputAmt)
        {
            return inputAmt * 1.15195m;
        }
        public static decimal CAN_US(decimal inputAmt)
        {
            return inputAmt * 0.79728m;
        }
        public static decimal CAN_GBP(decimal inputAmt)
        {
            return inputAmt * 0.57848m;
        }
        public static decimal CAN_EUR(decimal inputAmt)
        {
            return inputAmt * 0.66645m;
        }
        public static decimal EUR_US(decimal inputAmt)
        {
            return inputAmt * 1.19648m;
        }
        public static decimal EUR_GBP(decimal inputAmt)
        {
            return inputAmt * 0.86826m;
        }
        public static decimal EUR_CAN(decimal inputAmt)
        {
            return inputAmt * 1.50040m;
        }

        //CheckCurrency("USD", "GBP", goodAmt);
        //void CheckCurrency(string currencytype1, string currencytype2, decimal amtToExchange, EventHandler(Exchanger))
        //{

        //    if (currencyTypeHave.ToUpper() == currencytype1 && currencyTypeNeed.ToUpper() == currencytype2)
        //    {
        //        string exchangeMethod = currencytype1 + "_" + currencytype2;
        //        exchangedAmt = Exchanger.US_GBP(amtToExchange);
        //        Console.WriteLine("You had " + amtToExchange + " " + currencytype1 + " you now have " + exchangedAmt + " " + currencytype2);
        //        m.runningTotal = m.MakeUS(exchangedAmt, currencytype2);
        //    }
        //}
    }

}
