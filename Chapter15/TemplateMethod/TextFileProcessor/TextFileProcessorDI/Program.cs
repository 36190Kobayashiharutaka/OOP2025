namespace TextFileProcessorDI {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("表示したいテキストファイルのパス：");
            string filePath = Console.ReadLine();

            if (!File.Exists(filePath)) {
                Console.WriteLine("ファイルが見つかりません。");
                return;
            }

            int maxLines = 20;
            int count = 0;

            foreach (var line in File.ReadLines(filePath)) {
                Console.WriteLine(line);
                count++;

                if (count >= maxLines) {
                    break;
                }
            }
        }
    }
}
