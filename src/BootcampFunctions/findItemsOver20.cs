using System.Collections.Generic;
using System;

namespace BootcampFunctions {
    public class FindItemsOver20Class {

        public class Items {
            public int Qty {get; set;}
            public string Name {get; set;}
        }

        public List<Items> FindItemsOver20(List<Items> listOfObjects) {
            var newListOfObjects = new List<Items>();
            foreach (var item in listOfObjects) {
                if (item.Qty > 20) {
                    newListOfObjects.Add(item);
                    Console.WriteLine($"Inside if: {item.Name}");
                }
            }
            return newListOfObjects;
        }
    }
}