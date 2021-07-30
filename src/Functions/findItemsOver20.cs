using System.Collections.Generic;
using System;

namespace Functions {
    public class FindItemsOver20Class {
        public string[][] FindItemsOver20(string[][] listOfObjects) {
            int numb = listOfObjects.Length;
            var newListOfObjects = new string[numb][];
            foreach (var item in listOfObjects) {
                Console.WriteLine("Inside Loop");
                Console.WriteLine(item);
            }
            return newListOfObjects;
        }
    }
}