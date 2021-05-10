using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaneOfDependenci.Passwords
{
    class StringLenghtCheck:StringChecker
    {
        public int MinLenght { get; private set; }
        public StringLenghtCheck (int minLenght)
        {
            MinLenght = minLenght;
        }
        protected  override bool PerformCheck(string stringToCheck)
        {
            if (stringToCheck.Length >= this.MinLenght)
            {
                return true;
            }
                return false;
           
        }
    }
}
