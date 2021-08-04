using System.Collections.Generic;
using System;
using BootcampFunctions.Models;


namespace BootcampFunctions {
    public class FindItemsOver20 {
        public List<Item> findItemsOver20(List<Item> listOfObjects) {
            var newListOfObjects = new List<Item>();
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