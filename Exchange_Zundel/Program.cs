using System;

namespace Exchange_Zundel
{
    class Program
    {
       
        static void Main(string[] args)
        {
            string keepGoing;
            ExchangeMonitor m = new ExchangeMonitor();
            Console.WriteLine("Welcome to the currency exchanger");
            doexchange();
           do 
            {
                Console.WriteLine("Would you like to exchange more? \nY/N?");
                keepGoing = Console.ReadLine();
                Console.Clear();

                while (keepGoing.ToUpper() == "Y")
                {
                    doexchange();
                    Console.WriteLine("Would you like to exchange more? \nY/N?");
                    keepGoing = Console.ReadLine();
                    Console.Clear();

                };
                if(keepGoing.ToUpper() == "N")
                {
                    Console.WriteLine("Thank You for using Exchanger");
                    decimal exchangedAmt = Math.Round(m.runningTotal , 2) ;
                    int numOfExchanges = m.ExchangeTotal;
                    Console.WriteLine("You have made "+numOfExchanges+" exchanges and you exchanged "+exchangedAmt+" total USD");
                }
                else
                {
                    Console.WriteLine("TRY AGAIN\nYOU CAN ONLY ENTER Y or N");
                }
           } while (keepGoing.ToUpper() != "Y" && keepGoing.ToUpper() != "N") ;

            void doexchange()
            {
                Console.WriteLine("Supported currency:\nUSD GBP CAN EUR");
                Console.WriteLine("What type of currency do you have?");
                string currencyTypeHave = Console.ReadLine();
                Console.WriteLine("\nWhat type of currency do you want?");
                string currencyTypeNeed = Console.ReadLine();
                Console.WriteLine("\nHow much money do you have?");
                string amtInput = Console.ReadLine();
                decimal goodAmt = m.CheckNumber(amtInput);
                decimal exchangedAmt;
                if (currencyTypeHave.ToUpper() == "USD" && currencyTypeNeed.ToUpper() == "GBP")
                {
                    exchangedAmt = Exchanger.US_GBP(goodAmt);
                    exchangedAmt = Math.Round(exchangedAmt, 2);

                    Console.WriteLine("You had " + goodAmt + " USD you now have " + exchangedAmt + " GBP");
                    m.runningTotal = m.MakeUS(exchangedAmt, "GBP");
                }
                if (currencyTypeHave.ToUpper() == "USD" && currencyTypeNeed.ToUpper() == "CAN")
                {
                    exchangedAmt = Exchanger.US_CAN(goodAmt);
                    exchangedAmt = Math.Round(exchangedAmt, 2);

                    Console.WriteLine("You had " + goodAmt + " USD you now have " + exchangedAmt + " CAN");
                    m.runningTotal = m.MakeUS(exchangedAmt, "CAN");
                }
                if (currencyTypeHave.ToUpper() == "USD" && currencyTypeNeed.ToUpper() == "EUR")
                {

                    exchangedAmt = Exchanger.US_EUR(goodAmt);
                    exchangedAmt = Math.Round(exchangedAmt, 2);

                    Console.WriteLine("You had " + goodAmt + " USD you now have " + exchangedAmt + " EUR");
                    m.runningTotal = m.MakeUS(exchangedAmt, "EUR");
                }
                if (currencyTypeHave.ToUpper() == "GBP" && currencyTypeNeed.ToUpper() == "USD")
                {
                    exchangedAmt = Exchanger.GBP_US(goodAmt);
                    exchangedAmt = Math.Round(exchangedAmt, 2);

                    Console.WriteLine("You had " + goodAmt + " GBP you now have " + exchangedAmt + " USD");
                    m.runningTotal = exchangedAmt;
                }
                if (currencyTypeHave.ToUpper() == "GBP" && currencyTypeNeed.ToUpper() == "CAN")
                {
                    exchangedAmt = Exchanger.GBP_CAN(goodAmt);
                    exchangedAmt = Math.Round(exchangedAmt, 2);
                    Console.WriteLine("You had " + goodAmt + " GBP you now have " + exchangedAmt + " CAN");
                    m.runningTotal = m.MakeUS(exchangedAmt, "CAN");
                }
                if (currencyTypeHave.ToUpper() == "GBP" && currencyTypeNeed.ToUpper() == "EUR")
                {
                    exchangedAmt = Exchanger.GBP_EUR(goodAmt);
                    exchangedAmt = Math.Round(exchangedAmt, 2);
                    Console.WriteLine("You had " + goodAmt + " GBP you now have " + exchangedAmt + " EUR");
                    m.runningTotal = m.MakeUS(exchangedAmt, "EUR");
                }
                if (currencyTypeHave.ToUpper() == "CAN" && currencyTypeNeed.ToUpper() == "USD")
                {
                    exchangedAmt = Exchanger.CAN_US(goodAmt);
                    exchangedAmt = Math.Round(exchangedAmt, 2);
                    Console.WriteLine("You had " + goodAmt + " CAN you now have " + exchangedAmt + " USD");
                    m.runningTotal = exchangedAmt;
                }
                if (currencyTypeHave.ToUpper() == "CAN" && currencyTypeNeed.ToUpper() == "GBP")
                {
                    exchangedAmt = Exchanger.CAN_GBP(goodAmt);
                    exchangedAmt = Math.Round(exchangedAmt, 2);
                    Console.WriteLine("You had " + goodAmt + " CAN you now have " + exchangedAmt + " GBP");
                    m.runningTotal = m.MakeUS(exchangedAmt, "GBP");
                }
                if (currencyTypeHave.ToUpper() == "CAN" && currencyTypeNeed.ToUpper() == "EUR")
                {
                    exchangedAmt = Exchanger.CAN_EUR(goodAmt);
                    exchangedAmt = Math.Round(exchangedAmt, 2);
                    Console.WriteLine("You had " + goodAmt + " CAN you now have " + exchangedAmt + " EUR");
                    m.runningTotal = m.MakeUS(exchangedAmt, "EUR");
                }
                if (currencyTypeHave.ToUpper() == "EUR" && currencyTypeNeed.ToUpper() == "USD")
                {
                    exchangedAmt = Exchanger.EUR_US(goodAmt);
                    exchangedAmt = Math.Round(exchangedAmt, 2);
                    Console.WriteLine("You had " + goodAmt + " EUR you now have " + exchangedAmt + " USD");
                    m.runningTotal = exchangedAmt;
                }
                if (currencyTypeHave.ToUpper() == "EUR" && currencyTypeNeed.ToUpper() == "GBP")
                {
                    exchangedAmt = Exchanger.EUR_GBP(goodAmt);
                    exchangedAmt = Math.Round(exchangedAmt, 2);
                    Console.WriteLine("You had " + goodAmt + " EUR you now have " + exchangedAmt + " GBP");
                    m.runningTotal = m.MakeUS(exchangedAmt, "GBP");
                }
                if (currencyTypeHave.ToUpper() == "EUR" && currencyTypeNeed.ToUpper() == "CAN")
                {
                    exchangedAmt = Exchanger.EUR_CAN(goodAmt);
                    exchangedAmt = Math.Round(exchangedAmt, 2);
                    Console.WriteLine("You had " + goodAmt + " EUR you now have " + exchangedAmt + " CAN");
                    m.runningTotal = m.MakeUS(exchangedAmt, "CAN");
                }

                Console.WriteLine("Press Enter");
                Console.ReadKey();
                Console.Clear();
            }

        }
        
    }
}
