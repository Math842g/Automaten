using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automaten
{
    class Money
    {
        #region Fields
        //Creating fields.
        private static int currentBalance;
        private static int totalMoney;
        private int one = 1;
        private int two = 2;
        private int five = 5;
        private int ten = 10;
        private int twenty = 20;
        #endregion
        #region getters and setters
        //Creating getters and setters.
        public int CurrentBalance
        {
            get { return currentBalance; }
            set { currentBalance = value; }
        }
        public int TotalMoney
        {
            get { return totalMoney; }
            set { totalMoney = value; }
        }
        public int One
        {
            get { return one; }
        }
        public int Two
        {
            get { return two; }
        }
        public int Five
        {
            get { return five; }
        }
        public int Ten
        {
            get { return ten; }
        }
        public int Twenty
        {
            get { return twenty; }
        }
        #endregion
    }
}
