using System;
using Xunit;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace BootcampFunctions.test {
    public class FindItemsOver
    {

        [Fact]
        public void ShouldFindItemsOver45AndReturnIt() {
            var findItemsOver = new BootcampFunctions.FindItemsOver();

            var itemsListOne =  new List<Item>() { 
                new Item(){ Qty = 56, Name="Banna"},
                new Item(){ Qty = 43, Name="Apple"},
                new Item(){ Qty = 2, Name="Rama"},
                new Item(){ Qty = 14, Name="Bread"}
            };

            var itemsListTwo =  new List<Item>() { 
                new Item(){Name="Banna", Qty = 56},
            };

            var overs = findItemsOver.findItemsOver(itemsListOne, 45);

            var obj1Str = JsonConvert.SerializeObject(overs);
            var obj2Str = JsonConvert.SerializeObject(itemsListTwo);
            Assert.Equal(obj1Str, obj2Str );
            Assert.Equal(itemsListTwo.ToArray().Length, findItemsOver.findItemsOver(itemsListOne, 45).ToArray().Length);
        }

        [Fact]
        public void ShouldFindItemsOver10AndReturnIt() {
            var findItemsOver = new BootcampFunctions.FindItemsOver();

            var itemsListOne =  new List<Item>() { 
                new Item(){ Qty = 56, Name="Banna"},
                new Item(){ Qty = 43, Name="Apple"},
                new Item(){ Qty = 2, Name="Rama"},
                new Item(){ Qty = 14, Name="Bread"}
            };

            var itemsListTwo =  new List<Item>() { 
                new Item(){ Qty = 56, Name="Banna"},
                new Item(){ Qty = 43, Name="Apple"},
                new Item(){ Qty = 14, Name="Bread"}
            };

            var overs = findItemsOver.findItemsOver(itemsListOne, 10);

            var obj1Str = JsonConvert.SerializeObject(overs);
            var obj2Str = JsonConvert.SerializeObject(itemsListTwo);
            Assert.Equal(obj1Str, obj2Str );
            Assert.Equal(itemsListTwo.ToArray().Length, overs.ToArray().Length);
        }

        [Fact]
        public void ShouldFindItemsOver2AndReturnIt() {
            var findItemsOver = new BootcampFunctions.FindItemsOver();

            var itemsListOne =  new List<Item>() { 
                new Item(){ Qty = 56, Name="Banna"},
                new Item(){ Qty = 43, Name="Apple"},
                new Item(){ Qty = 4, Name="Rama"},
                new Item(){ Qty = 14, Name="Bread"}
            };

            var itemsListTwo =  new List<Item>() {
                new Item(){ Qty = 56, Name="Banna"},
                new Item(){ Qty = 43, Name="Apple"},
                new Item(){ Qty = 4, Name="Rama"},
                new Item(){ Qty = 14, Name="Bread"}
            };

            var overs = findItemsOver.findItemsOver(itemsListOne, 2);

            var obj1Str = JsonConvert.SerializeObject(overs);
            var obj2Str = JsonConvert.SerializeObject(itemsListTwo);
            Assert.Equal(obj1Str, obj2Str );
            Assert.Equal(itemsListTwo.ToArray().Length, overs.ToArray().Length);
        }
    }
}