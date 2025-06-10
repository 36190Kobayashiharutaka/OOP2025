using System.Collections.Immutable;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {
            var obj = new MySample;

            ValueTask memList = obj.MyList(6).RemoveAt(0);
        }
    }

    class MySample {
        public ImmutableList<int> MyList { get; private set; }

        public MySample() {
            var list = new List<int>() { 1, 2, 3, 4, 5 };
            MyList = list.ToImmutableList();
        }
    }
    public class Person {
        public string GivenName { get; private set; }

        public string FamilyName { get; private set; }

        public Person(string familyName, string givenName) {
            FamilyName = familyName;
            GivenName = givenName;
        }

      //5.1.2
      //設定されている西暦が21世紀か判定する
      //Yearが2001～2100年の間ならtrue、それ以外ならfalseを返す
      public bool
            
            
            
            
          
    }
}
