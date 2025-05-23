
namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            List<string> langs = [
    "C#", "Java", "Ruby", "PHP", "Python", "TypeScript",
    "JavaScript", "Swift", "Go",
];

            Exercise1(langs);
            Console.WriteLine("---");
            Exercise2(langs);
            Console.WriteLine("---");
            Exercise3(langs);
        }

        private static void Exercise1(List<string> langs) {
            //foreach
            foreach (string lang in langs) {
                if (lang.Contains("S")) {
                    Console.WriteLine(lang);
                }
            }
            //for
            for (int i = 0; i < langs.Count; i++) {
                if (langs[i].Contains("S")) {
                    Console.WriteLine(langs[i]);
                }
            }
            //While
            int j = 0;
            while (j < langs.Count) {
                if (langs[j].Contains("S")) {
                    Console.WriteLine(langs[j]);
                }
                j++;
            }
        }


        private static void Exercise2(List<string> langs) {
            IEnumerable<string> Langs = langs.Where(lang => lang.Contains("S"));

            foreach (string lang in Langs) {
                Console.WriteLine(lang);
            }

            var LangsQuery = from lang in langs
                                     where lang.Contains("S")
                                     select lang;

            foreach (string lang in LangsQuery) {
                Console.WriteLine(lang);
            }
        }

        private static void Exercise3(List<string> langs) {
            string lang = langs.Find(l => l.Length >= 10);
            lang = lang ?? "unknown";
        }
    }
}
