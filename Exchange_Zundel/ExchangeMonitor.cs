using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange_Zundel
{
    class ExchangeMonitor
    {
        public decimal CheckNumber(string numInput)
        {
            decimal.TryParse(numInput, out decimal goodNum);
            return goodNum; 
        }
        public decimal MakeUS(decimal amtExchnaged,string currencyType)
        {
            if (currencyType == "GBP")
            {
                return Exchanger.GBP_US(amtExchnaged);
            }
            else if (currencyType == "CAN")
            {
                return Exchanger.CAN_US(amtExchnaged);
            }
            else
            {
                return Exchanger.EUR_US(amtExchnaged);
            }
            
        }

        private decimal _numExchangedUS;
        private int numOfExchanges = 0;
        public decimal runningTotal
        {
            get 
            { 
                return _numExchangedUS;
            }
            set
            {
                _numExchangedUS = value + _numExchangedUS;
                numOfExchanges++;
            }
        }
       

        public int ExchangeTotal
            
        {
            get { return numOfExchanges; }
            
        }



    }
}
