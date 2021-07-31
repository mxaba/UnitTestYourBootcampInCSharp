using System;
using Xunit;
using System.Collections.Generic;
using static Functions.FindItemsOverClass;

namespace Functions.test {
    public class FindItemsOver
    {

        [Fact]
        public void findItemsOver() {
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
            Assert.Equal(itemsListTwo, overs);
            // Assert.IsTrue(itemsListTwo.SequenceEqual(overs));
            // itemsListTwo.ShouldDeepEqual(findItemsOver20.FindItemsOver20(itemsListOne));
        }
    }
}