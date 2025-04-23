using Exercise02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program {
    static void Main(string[] args) {

        for (int inch = 1; inch <= 10; inch++) {
            double meter = inch * 0.0254;
            Console.WriteLine($"{inch}ih = {meter:0.0000}m");

        }
    }
}
