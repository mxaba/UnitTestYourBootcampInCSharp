using System;
using Xunit;
using System.Collections.Generic;
using static BootcampFunctions.FindItemsOverClass;
using Newtonsoft.Json;

namespace BootcampFunctions.test {
    public class FindItemsOver
    {

        [Fact]
        public void findItemsOver45() {
            var findItemsOver = new FindItemsOverClass();

            var itemsListOne =  new List<Items>() { 
                new Items(){ Qty = 56, Name="Banna"},
                new Items(){ Qty = 43, Name="Apple"},
                new Items(){ Qty = 2, Name="Rama"},
                new Items(){ Qty = 14, Name="Bread"}
            };

            var itemsListTwo =  new List<Items>() { 
                new Items(){Name="Banna", Qty = 56},
            };

            var overs = findItemsOver.FindItemsOver(itemsListOne, 45);

            var obj1Str = JsonConvert.SerializeObject(overs);
            var obj2Str = JsonConvert.SerializeObject(itemsListTwo);
            Assert.Equal(obj1Str, obj2Str );
            Assert.Equal(itemsListTwo.ToArray().Length, findItemsOver.FindItemsOver(itemsListOne, 45).ToArray().Length);
        }

        [Fact]
        public void findItemsOver10() {
            var findItemsOver = new FindItemsOverClass();

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

            var overs = findItemsOver.FindItemsOver(itemsListOne, 10);

            var obj1Str = JsonConvert.SerializeObject(overs);
            var obj2Str = JsonConvert.SerializeObject(itemsListTwo);
            Assert.Equal(obj1Str, obj2Str );
            Assert.Equal(itemsListTwo.ToArray().Length, overs.ToArray().Length);
        }

        [Fact]
        public void findItemsOver2() {
            var findItemsOver = new FindItemsOverClass();

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

            var overs = findItemsOver.FindItemsOver(itemsListOne, 2);

            var obj1Str = JsonConvert.SerializeObject(overs);
            var obj2Str = JsonConvert.SerializeObject(itemsListTwo);
            Assert.Equal(obj1Str, obj2Str );
            Assert.Equal(itemsListTwo.ToArray().Length, overs.ToArray().Length);
        }
    }
}