using System;
using System.Collections.Generic;

namespace Functions {
    public class CountAllPaarlClass {
        public string[] CountAllPaarl(string name) {
            var list = new List<string>();
            var nameSplited = name.Split(", ");

            for(var index = 0; index<nameSplited.Length; index++ ){
                if (nameSplited[index].Contains("CJ")){
                    list.Add(nameSplited[index]);
                }
            }
            return list.ToArray();
        }
    }
}