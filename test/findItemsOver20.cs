using System;
using Xunit;
using System.Collections.Generic;
using static Functions.FindItemsOver20Class;

namespace Functions.test {
    public class FindItemsOver20
    {
        [Fact]
        public void findItemsOver20() {
            var findItemsOver20 = new FindItemsOver20Class();

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

            // var overs = findItemsOver20.FindItemsOver20(itemsListOne);
            Assert.Equal(itemsListTwo.ToArray().Length, findItemsOver20.FindItemsOver20(itemsListOne).ToArray().Length);
            // itemsListTwo.ShouldDeepEqual(findItemsOver20.FindItemsOver20(itemsListOne));
        }
    }
}