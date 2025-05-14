using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    //2.1.1
    public class Song {
        // 曲のタイトルを保持するプロパティ
        public string Title { get; set; }
        // アーティスト名を保持するプロパティ
        public string ArtistName { get; set; }
        // 曲の長さを秒単位で保持するプロパティ
        public int Length { get; set; }

        // Song クラスのコンストラクター
        // 引数としてタイトル、アーティスト名、長さを取る
       // public Song(string title, string artistName, int length) {
         //   Title = title;
           // ArtistName = artistName;
            //Length = length;
        //}

     //2.1.2
        // 曲の長さを「分:秒」形式の文字列で返すメソッド
        public string GetFormattedLength() {
            // 分を計算
            int minutes = Length / 60;
            // 秒を計算（60で割った余り）
            int seconds = Length % 60;
            // フォーマットされた文字列を返す（秒が一桁の場合も0で埋める）
            return $"{minutes}:{seconds:D2}";
        }

        // オブジェクトの文字列表現をカスタマイズするメソッドをオーバーライド
        public override string ToString() {
            // 曲のタイトル、アーティスト名、フォーマットされた長さを返す
            return $"Title: {Title}, Artist: {ArtistName}, Length: {GetFormattedLength()}";
        }
    }
}