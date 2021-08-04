using System;
using Xunit;
using System.Collections.Generic;
using BootcampFunctions.Models;

namespace BootcampFunctions.test {
    public class MostProfitableDepartment
    {
        [Fact]
        public void ShouldReturnCarpentry() {
            var mostProfitableDepartment = new BootcampFunctions.MostProfitableDepartment();

            var itemsListOne =  new List<Department>() {
                new Department(){ Sales = 4500, Day="Monday", DepartmentName="hardware"},
                new Department(){ Sales = 1500, Day="Monday", DepartmentName="outdoor"},
                new Department(){ Sales = 5500, Day="Monday", DepartmentName="carpentry"},
                new Department(){ Sales = 7500, Day="Tuesday", DepartmentName="hardware"},
                new Department(){ Sales = 2505, Day="Tuesday", DepartmentName="outdoor"},
                new Department(){ Sales = 1540, Day="Tuesday", DepartmentName="carpentry"},
                new Department(){ Sales = 1500, Day="Wednesday", DepartmentName="outdoor"},
                new Department(){ Sales = 8507, Day="Wednesday", DepartmentName="carpentry"},
                new Department(){ Sales = 8009, Day="Wednesday", DepartmentName="hardware"},
                new Department(){ Sales = 12000, Day="Thursday", DepartmentName="outdoor"},
                new Department(){ Sales = 18007, Day="Thursday", DepartmentName="carpentry"},
                new Department(){ Sales = 6109, Day="Thursday", DepartmentName="hardware"},
                new Department(){ Sales = 7005, Day="Friday", DepartmentName="outdoor"},
                new Department(){ Sales = 12006, Day="Friday", DepartmentName="hardware"},
                new Department(){ Sales = 16109, Day="Friday", DepartmentName="carpentry"},
            };

            Assert.Equal("carpentry", mostProfitableDepartment.mostProfitableDepartment(itemsListOne));
        }

        [Fact]
        public void ShouldReturnOutDoor() {
            var mostProfitableDepartment = new BootcampFunctions.MostProfitableDepartment();

            var itemsListOne =  new List<Department>() {
                new Department(){ Sales = 4500, Day="Monday", DepartmentName="hardware"},
                new Department(){ Sales = 1500, Day="Monday", DepartmentName="outdoor"},
                new Department(){ Sales = 5500, Day="Monday", DepartmentName="carpentry"},
                new Department(){ Sales = 7500, Day="Tuesday", DepartmentName="hardware"},
                new Department(){ Sales = 2505, Day="Tuesday", DepartmentName="outdoor"},
                new Department(){ Sales = 1540, Day="Tuesday", DepartmentName="carpentry"},
                new Department(){ Sales = 1500, Day="Wednesday", DepartmentName="hardware"},
                new Department(){ Sales = 8507, Day="Wednesday", DepartmentName="outdoor"},
                new Department(){ Sales = 8009, Day="Wednesday", DepartmentName="carpentry"},
                new Department(){ Sales = 12000, Day="Thursday", DepartmentName="hardware"},
                new Department(){ Sales = 18007, Day="Thursday", DepartmentName="outdoor"},
                new Department(){ Sales = 6109, Day="Thursday", DepartmentName="carpentry"},
                new Department(){ Sales = 7005, Day="Friday", DepartmentName="hardware"},
                new Department(){ Sales = 12006, Day="Friday", DepartmentName="outdoor"},
                new Department(){ Sales = 16109, Day="Friday", DepartmentName="carpentry"},
            };

            Assert.Equal("outdoor", mostProfitableDepartment.mostProfitableDepartment(itemsListOne));
        }

    }
} 