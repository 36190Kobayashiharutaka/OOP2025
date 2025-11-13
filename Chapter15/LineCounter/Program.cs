using System;
using TextFileProcessor;

namespace LineCounter {
    internal class Program {
        static void Main(string[] args) {
            string path = @"C:\Users\infosys\repos\OOP2025\Chapter15\LineCounter\Section03Progrsm.cs";
            TextProcessor.Run<LineCounterProcessor>(path);
        }
    }
}
