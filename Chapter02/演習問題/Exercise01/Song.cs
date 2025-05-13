using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    //2.1.1
    public class Song {
        public string Title { get; set; }
        public string ArtistName { get; set; }
        public int Length { get; set; }

        // コンストラクター
        public Song(string title, string artistName, int length) {
            Title = title;
            ArtistName = artistName;
            Length = length;
        }

        public override string ToString() {
            return $"Title: {Title}, Artist: {ArtistName}, Length: {Length}秒";
        }

        //2.1.2.
        public static void Main(string[] args) {
            Song mySong = new Song("Example Song", "Example Artist", 240);
            System.Console.WriteLine(mySong);
        }
    }
}
