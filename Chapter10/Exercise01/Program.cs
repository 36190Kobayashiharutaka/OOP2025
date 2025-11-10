using System.Text.RegularExpressions;

namespace Exercise01 {

    internal class Program {

        static void Main(string[] args) {

            var filePath = "source.txt";

            if (File.Exists(filePath)) {

                var lines = File.ReadLines(filePath);

                int cnt = 0;

                //if (Regex.IsMatch(line, @"\sclass\s")) {

                //    cnt++;

                //}

                foreach (var line in lines) {

                    string[] words = line.Split(' ');

                    var word = words.Where(s => s.Contains("class"));

                    if (word.Count() > 0) {

                        cnt++;

                    }

                }

                Console.WriteLine(cnt);

            }

        }

    }

}


namespace Exercise02 {

    internal class Program {

        static void Main(string[] args) {

            var filePath = "source.txt";

            var newFilePath = "newSource.txt";

            var line = File.ReadLines(filePath)

                .Select((s, ix) => $"{ix + 1,4}: {s}");

            foreach (var item in line) {

                Console.WriteLine(item);

            }

            File.WriteAllLines(newFilePath, line);

        }

    }

}

