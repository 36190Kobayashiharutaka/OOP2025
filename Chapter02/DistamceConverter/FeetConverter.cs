using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistamceConverter {
    public static class FeetConverter {
        // 定数
        private const double ratio = 0.3048;

        // フィートをメートルに変換します
        public static double FromMeter(int feet) {
            return feet * ratio;
        }
        // メートルをフィートに変換します
        public static double ToMeter(int meter) {
            return meter / ratio;

        }
    }
}