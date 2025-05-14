using System;

namespace Exercise01 {
    public class Program {
        static void Main(string[] args) {
            //2.1.3
            // メインのエントリーポイント
            static void Main(string[] args) {
                var songs = new List<Song>();
                // Song オブジェクトの配列を作成し、初期化
                while (true) {
                    //*******曲の登録*******を出力
                    Console.WriteLine("*******曲の登録*******");
                    //曲名を出力
                    Console.Write("曲名：");
                    //入力された曲名を取得
                    string? title = Console.ReadLine();

                    //endが入力されたら登録終了
                    if (title.Equals("end", StringComparison.OrdinalIgnoreCase)) break;

                    //アーティスト名を出力
                    Console.WriteLine("アーティスト名:");
                    //入力されたアーティスト名を取得
                    string? artistName = Console.ReadLine();

                    //演奏時間（秒）：  を出力
                    Console.WriteLine("演奏時間（秒）：");
                    //入力された演奏時間を取得
                    int length = int.Parse(Console.ReadLine());

                    //Songインスタンスを生成
                    //Song song = new Song(title, artistName, length);
                    Song song = new Song() {
                        Title = title,
                        ArtistName = artistName,
                        Length = length
                    };
                    //歌データを入れるリストオブジェクトへ登録

                    songs.Add(song);

                    Console.WriteLine();//改行

                    // 配列に格納されたすべての Song オブジェクトの内容をコンソールに出力するメソッドを呼び出す
                    printSongs(songs);


                }
            }
        }
        //2.1.4
        // Song オブジェクトの配列を受け取り、各 Song オブジェクトの内容をコンソールに出力するメソッド
        private static void printSongs(IEnumerable<Song>songs) {
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
