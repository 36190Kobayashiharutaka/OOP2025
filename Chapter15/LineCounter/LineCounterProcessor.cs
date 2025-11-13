using System;
using TextFileProcessor;

namespace LineCounter {
    internal class LineCounterProcessor : TextProcessor {
        private int _count;

        protected override void Initialize(string fileName) {
            _count = 0;
        }

        protected override void Execute(string line) {
            _count++;
        }

        protected override void Terminate() {
            Console.WriteLine($"{_count} 行");
        }
    }
}
