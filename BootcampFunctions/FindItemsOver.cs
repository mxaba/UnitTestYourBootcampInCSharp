using System.Collections.Generic;
using System;
using BootcampFunctions.Models;

namespace BootcampFunctions {
    public class FindItemsOver {
        public List<Item> findItemsOver(List<Item> listOfObjects, int qty) {
            var newListOfObjects = new List<Item>();
            foreach (var item in listOfObjects) {
                if (item.Qty > qty) {
                    newListOfObjects.Add(item);
                    // Console.WriteLine($"Inside if: {item.Name}");
                }
            }
            return newListOfObjects;
        }
    }
} 