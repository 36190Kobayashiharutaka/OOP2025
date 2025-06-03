﻿namespace Exercise04 {
    internal class Program {
        static void Main(string[] args) {
            var line = "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886";

            var array = line.Split(';');

            var word = array[0].Split('=');
            Console.WriteLine($"{ToJapanese(word[0])}:{word[1]}");



            static string ToJapanese(string key) {
                return key switch {
                    "Novelist" => "作家",
                    "BestWork" => "代表作",
                    "Born" => "誕生年",
                    _ => "引数keyは、正しい値ではありません"
                };


                // You can add a Console.WriteLine here to see the output
                // Console.WriteLine(jpName); 
            }

            /// <summary>
            /// 引数の単語を日本語へ変換します
            /// </summary>
            /// <param name="key">"Novelist","BestWork","Born"</param>
            /// <returns>"「作家」,「代表作」,「誕生年」</returns>

        }
    }
}