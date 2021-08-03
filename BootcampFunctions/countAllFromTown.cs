using System.Collections.Generic;

namespace BootcampFunctions {
    public class CountAllFromTown {
        public int countAllFromTown(string name, string city) {
            var list = new List<string>();
            var nameSplited = name.Split(", ");

            for(var index = 0; index<nameSplited.Length; index++ ){
                if (nameSplited[index].Contains(city)){
                    list.Add(nameSplited[index]);
                }
            }
            return list.ToArray().Length;
        }
    }
} 