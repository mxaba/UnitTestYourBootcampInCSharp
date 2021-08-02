using System;
using Xunit;
using System.Collections.Generic;
using static BootcampFunctions.FindItemsOver20;
using Newtonsoft.Json;

namespace BootcampFunctions.test {
    public class FindItemsOver20
    {
        [Fact]
        public void FindItemsOver20ShouldReturn2Items() {
            var findItemsOver20 = new BootcampFunctions.FindItemsOver20();

            var itemsListOne =  new List<Items>() { 
                new Items(){ Qty = 56, Name="Banna"},
                new Items(){ Qty = 43, Name="Apple"},
                new Items(){ Qty = 2, Name="Rama"},
                new Items(){ Qty = 14, Name="Bread"}
            };

            var itemsListTwo =  new List<Items>() { 
                new Items(){ Qty = 56, Name="Banna"},
                new Items(){ Qty = 43, Name="Apple"},
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

            var itemsListOne =  new List<Items>() { 
                new Items(){ Qty = 56, Name="Banna"},
                new Items(){ Qty = 43, Name="Apple"},
                new Items(){ Qty = 2, Name="Rama"},
                new Items(){ Qty = 41, Name="Bread"}
            };

            var itemsListTwo =  new List<Items>() { 
                new Items(){ Qty = 56, Name="Banna"},
                new Items(){ Qty = 43, Name="Apple"},
                new Items(){ Qty = 41, Name="Bread"}
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