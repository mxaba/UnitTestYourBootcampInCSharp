using System;
using Xunit;
using System.Collections.Generic;
using static BootcampFunctions.FindItemsOver;
using Newtonsoft.Json;

namespace BootcampFunctions.test {
    public class FindItemsOver
    {

        [Fact]
        public void ShouldFindItemsOver45AndReturnIt() {
            var findItemsOver = new BootcampFunctions.FindItemsOver();

            var itemsListOne =  new List<Items>() { 
                new Items(){ Qty = 56, Name="Banna"},
                new Items(){ Qty = 43, Name="Apple"},
                new Items(){ Qty = 2, Name="Rama"},
                new Items(){ Qty = 14, Name="Bread"}
            };

            var itemsListTwo =  new List<Items>() { 
                new Items(){Name="Banna", Qty = 56},
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

            var itemsListOne =  new List<Items>() { 
                new Items(){ Qty = 56, Name="Banna"},
                new Items(){ Qty = 43, Name="Apple"},
                new Items(){ Qty = 2, Name="Rama"},
                new Items(){ Qty = 14, Name="Bread"}
            };

            var itemsListTwo =  new List<Items>() { 
                new Items(){ Qty = 56, Name="Banna"},
                new Items(){ Qty = 43, Name="Apple"},
                new Items(){ Qty = 14, Name="Bread"}
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

            var itemsListOne =  new List<Items>() { 
                new Items(){ Qty = 56, Name="Banna"},
                new Items(){ Qty = 43, Name="Apple"},
                new Items(){ Qty = 4, Name="Rama"},
                new Items(){ Qty = 14, Name="Bread"}
            };

            var itemsListTwo =  new List<Items>() {
                new Items(){ Qty = 56, Name="Banna"},
                new Items(){ Qty = 43, Name="Apple"},
                new Items(){ Qty = 4, Name="Rama"},
                new Items(){ Qty = 14, Name="Bread"}
            };

            var overs = findItemsOver.findItemsOver(itemsListOne, 2);

            var obj1Str = JsonConvert.SerializeObject(overs);
            var obj2Str = JsonConvert.SerializeObject(itemsListTwo);
            Assert.Equal(obj1Str, obj2Str );
            Assert.Equal(itemsListTwo.ToArray().Length, overs.ToArray().Length);
        }
    }
}