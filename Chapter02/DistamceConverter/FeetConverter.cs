using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistamceConverter {
    public static class FeetConverter {

        public static double FromMeter(int feet) {
            return feet * 0.3048;
        }
        public static double ToMeter(int meter) {
            return meter / 0.3048;

        }
    }
}