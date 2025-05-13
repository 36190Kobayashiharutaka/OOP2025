using System;

namespace Exercise01 {
    public class Program {
        static void Main(string[] args) {
            //2.1.3
            // メインのエントリーポイント
            static void Main(string[] args) {
                // Song オブジェクトの配列を作成し、初期化
                var songs = new Song[] {
            new Song("Let it be", "The Beatles", 243),
            new Song("Bridge Over Troubled Water", "Simon & Garfunkel", 293),
            new Song("Close To You", "Carpenters", 276),
            new Song("Honesty", "Billy Joel", 231),
            new Song("I Will Always Love You", "Whitney Houston", 273),
        };

                // 配列に格納されたすべての Song オブジェクトの内容をコンソールに出力するメソッドを呼び出す
                printSongs(songs);
            }
        }
        //2.1.4
        // Song オブジェクトの配列を受け取り、各 Song オブジェクトの内容をコンソールに出力するメソッド
        private static void printSongs(Song[] songs) {
#if false        // 配列内の各 Song オブジェクトに対して処理を行うループ
            foreach (var song in songs) {
                // 現在の Song オブジェクトの ToString() メソッドを呼び出し、その結果をコンソールに出力
                System.Console.WriteLine(song);
                }
#else   
            foreach (var song in songs) {
                Console.WriteLine(@"{0},{1},{2:m\:ss}",

                     song.Title, song.ArtistName, TimeSpan.FromSeconds(song.Length));
            }
#endif
            Console.WriteLine();
        }
    }
}
