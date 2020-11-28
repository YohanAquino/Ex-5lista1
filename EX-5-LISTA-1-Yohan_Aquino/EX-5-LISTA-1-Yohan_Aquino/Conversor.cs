using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_5_LISTA_1_Yohan_Aquino
{
    class Conversor
    {
        private double m;
        private double k;

        public void setMilha(double x) 
        {
            m = x;
        }
        public void calcularKm()
        {
            k= (m * 1852) / 1000;
        }
        public Double getKm() 
        {
            return k;
        }
    }
}
