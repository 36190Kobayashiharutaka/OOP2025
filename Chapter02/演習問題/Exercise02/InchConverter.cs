using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    public static class InchConverter {
        //定数
        private const double ratio = 0.0254;

        public static double InchToMeter(int inch) {
            return inch * ratio;
        }
        public static double MeterToInch(int meter) {
            return meter / ratio;

        }
    }
}