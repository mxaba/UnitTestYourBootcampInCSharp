using Xunit;
using System.Collections.Generic;
using BootcampFunctions.Models;
using Newtonsoft.Json;

namespace BootcampFunctions.test {
    public class FindItemsOver20
    {
        [Fact]
        public void FindItemsOver20ShouldReturn2Items() {
            var findItemsOver20 = new BootcampFunctions.FindItemsOver20();

            var itemsListOne =  new List<Item>() { 
                new Item(){ Qty = 56, Name="Banna"},
                new Item(){ Qty = 43, Name="Apple"},
                new Item(){ Qty = 2, Name="Rama"},
                new Item(){ Qty = 14, Name="Bread"}
            };

            var itemsListTwo =  new List<Item>() { 
                new Item(){ Qty = 56, Name="Banna"},
                new Item(){ Qty = 43, Name="Apple"},
            };

            var overs = findItemsOver20.findItemsOver20(itemsListOne);

            var obj1Str = JsonConvert.SerializeObject(overs);
            var obj2Str = JsonConvert.SerializeObject(itemsListTwo);
            Assert.Equal(obj1Str, obj2Str );

            Assert.Equal(itemsListTwo.ToArray().Length, overs.ToArray().Length);
            // itemsListTwo.ShouldDeepEqual(findItemsOver20.FindItemsOver20(itemsListOne));
        }

        [Fact]
        public void FindItemsOver20ShouldReturn3Items() {
            var findItemsOver20 = new BootcampFunctions.FindItemsOver20();

            var itemsListOne =  new List<Item>() { 
                new Item(){ Qty = 56, Name="Banna"},
                new Item(){ Qty = 43, Name="Apple"},
                new Item(){ Qty = 2, Name="Rama"},
                new Item(){ Qty = 41, Name="Bread"}
            };

            var itemsListTwo =  new List<Item>() { 
                new Item(){ Qty = 56, Name="Banna"},
                new Item(){ Qty = 43, Name="Apple"},
                new Item(){ Qty = 41, Name="Bread"}
            };

            var overs = findItemsOver20.findItemsOver20(itemsListOne);

            var obj1Str = JsonConvert.SerializeObject(overs);
            var obj2Str = JsonConvert.SerializeObject(itemsListTwo);
            Assert.Equal(obj1Str, obj2Str );

            Assert.Equal(itemsListTwo.ToArray().Length, overs.ToArray().Length);
            // itemsListTwo.ShouldDeepEqual(findItemsOver20.FindItemsOver20(itemsListOne));
        }

    }
} 