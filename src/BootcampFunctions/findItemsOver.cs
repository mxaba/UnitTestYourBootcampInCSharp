using System.Collections.Generic;
using System;

namespace BootcampFunctions {
    public class FindItemsOverClass {

        public class Items {
            public int Qty {get; set;}
            public string Name {get; set;}
        }

        public List<Items> FindItemsOver(List<Items> listOfObjects, int qty) {
            var newListOfObjects = new List<Items>();
            foreach (var item in listOfObjects) {
                if (item.Qty > qty) {
                    newListOfObjects.Add(item);
                    Console.WriteLine($"Inside if: {item.Name}");
                }
            }
            return newListOfObjects;
        }
    }
}