using System;
using Xunit;
using System.Collections.Generic;
using static BootcampFunctions.MostProfitableDepartment;
using Newtonsoft.Json;

namespace BootcampFunctions.test {
    public class MostProfitableDepartment
    {
        [Fact]
        public void ShouldReturnCarpentry() {
            var mostProfitableDepartment = new BootcampFunctions.MostProfitableDepartment();

            var itemsListOne =  new List<MostDepartments>() {
                new MostDepartments(){ Sales = 4500, Day="Monday", Department="hardware"},
                new MostDepartments(){ Sales = 1500, Day="Monday", Department="outdoor"},
                new MostDepartments(){ Sales = 5500, Day="Monday", Department="carpentry"},
                new MostDepartments(){ Sales = 7500, Day="Tuesday", Department="hardware"},
                new MostDepartments(){ Sales = 2505, Day="Tuesday", Department="outdoor"},
                new MostDepartments(){ Sales = 1540, Day="Tuesday", Department="carpentry"},
                new MostDepartments(){ Sales = 1500, Day="Wednesday", Department="outdoor"},
                new MostDepartments(){ Sales = 8507, Day="Wednesday", Department="carpentry"},
                new MostDepartments(){ Sales = 8009, Day="Wednesday", Department="hardware"},
                new MostDepartments(){ Sales = 12000, Day="Thursday", Department="outdoor"},
                new MostDepartments(){ Sales = 18007, Day="Thursday", Department="carpentry"},
                new MostDepartments(){ Sales = 6109, Day="Thursday", Department="hardware"},
                new MostDepartments(){ Sales = 7005, Day="Friday", Department="outdoor"},
                new MostDepartments(){ Sales = 12006, Day="Friday", Department="hardware"},
                new MostDepartments(){ Sales = 16109, Day="Friday", Department="carpentry"},
            };

            Assert.Equal("carpentry", mostProfitableDepartment.mostProfitableDepartment(itemsListOne));
        }

        [Fact]
        public void ShouldReturnOutDoor() {
            var mostProfitableDepartment = new BootcampFunctions.MostProfitableDepartment();

            var itemsListOne =  new List<MostDepartments>() {
                new MostDepartments(){ Sales = 4500, Day="Monday", Department="hardware"},
                new MostDepartments(){ Sales = 1500, Day="Monday", Department="outdoor"},
                new MostDepartments(){ Sales = 5500, Day="Monday", Department="carpentry"},
                new MostDepartments(){ Sales = 7500, Day="Tuesday", Department="hardware"},
                new MostDepartments(){ Sales = 2505, Day="Tuesday", Department="outdoor"},
                new MostDepartments(){ Sales = 1540, Day="Tuesday", Department="carpentry"},
                new MostDepartments(){ Sales = 1500, Day="Wednesday", Department="hardware"},
                new MostDepartments(){ Sales = 8507, Day="Wednesday", Department="outdoor"},
                new MostDepartments(){ Sales = 8009, Day="Wednesday", Department="carpentry"},
                new MostDepartments(){ Sales = 12000, Day="Thursday", Department="hardware"},
                new MostDepartments(){ Sales = 18007, Day="Thursday", Department="outdoor"},
                new MostDepartments(){ Sales = 6109, Day="Thursday", Department="carpentry"},
                new MostDepartments(){ Sales = 7005, Day="Friday", Department="hardware"},
                new MostDepartments(){ Sales = 12006, Day="Friday", Department="outdoor"},
                new MostDepartments(){ Sales = 16109, Day="Friday", Department="carpentry"},
            };

            Assert.Equal("outdoor", mostProfitableDepartment.mostProfitableDepartment(itemsListOne));
        }

    }
}