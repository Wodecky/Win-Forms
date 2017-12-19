using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorVAT.Model
{
    class Kalkulator
    {
        private decimal vat1, vat2;

        public void ChangeVats(decimal vat1, decimal vat2)
        {
            if (CheckVats(vat1, vat2))
            {
                this.vat1 = vat1;
                this.vat2 = vat2;
                
            }
            
        }
        private bool CheckVat(decimal vat)
        {
            return 0 <= vat && vat <= 100;
        }
        private bool CheckVats(decimal vat1, decimal vat2)
        {
            return CheckVat(vat1) && CheckVat(vat2) && vat1 < vat2;
        }

        private decimal Oblicz (decimal kwota, decimal vat)
        {
            return kwota * vat / 100;
        }
        public void ObliczVat (decimal kwota, out decimal kwotaVat1, out decimal kwotaVat2)
        {
            kwotaVat1 = Oblicz(kwota, this.vat1);
            kwotaVat2 = Oblicz(kwota, this.vat2);
        }
    }
}
