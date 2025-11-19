using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFileProcessorDI {
    public class LineToHalfNumberService : ITextFileService {
        public void Execute(string line) {

        }
        public void Initialize(string fname) {
            string result = new string(
                line.Select(c => ('０' <= c && c <= '９') ? (char)(c - '０' + '0') : c).ToArray());
            Console.WriteLine(result);
        }
        public void Terminate() {

        }
    }
}
