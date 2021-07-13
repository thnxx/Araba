using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Araba.Arabalar
{
    class Cars
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public double BeygirGucu { get; set; }
        public string KapiSayisi { get; set; }
        public Enum ArabaTuru { get; set; }
        public double MaksimumHiz { get; set; }
        public string Cekis { get; set; }
        public double SifirdanYuze { get; set; }
        public double Agirlik { get; set; }
        public double MotorHacmi { get; set; }

    }
}
