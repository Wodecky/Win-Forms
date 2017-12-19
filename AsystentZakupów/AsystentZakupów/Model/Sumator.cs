using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsystentZakupów.Model
{
    class Sumator
    {
        public decimal Sum { get; private set; }
        private decimal Limit { get; set; }

        public Sumator(decimal Limit, decimal Sum = 0)
        {
            this.Sum = Sum;
            this.Limit = Limit;
        }

        public bool Add(decimal kwota)
        {
            if (Check(kwota))
            {
                Sum += kwota;
                return true;
            }
            return false;
        }

        private bool Check(decimal kwota)
        {
            if (kwota <= 0) return false;
            if (kwota + Sum > Limit) return false;
            return true;
        }
    }
}
