namespace Section05 {
    internal class Program {
        static void Main(string[] args) {

            var text = "The quick brown fox jumps over the lazy dog";
            var words = text.Split(' ');
            var ward = words.Where(s => s.Length == 4);
            


            var numbres = new List<int> { 9, 6, -5, -4, 2, 5, -4, 8 - 1, 0, 4 };
            var index = numbres.FindIndex(n => n < 0);
            

        }
    }
}
