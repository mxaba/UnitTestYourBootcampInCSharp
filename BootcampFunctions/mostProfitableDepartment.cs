using System.Collections.Generic;
using System;

namespace BootcampFunctions {
    public class MostProfitableDepartment {

        public class MostDepartments {
            public int Sales {get; set;}
            public string Department {get; set;}
            public string Day {get; set;}
        }

        public string mostProfitableDepartment(List<MostDepartments> listOfObjects) {
            var mostDepartment = "";
            var totalSales = 0;

            for(var i = 0; i<listOfObjects.Count; i++){
                var sales = listOfObjects[i].Sales;
                var department = listOfObjects[i].Department;

                if (sales > totalSales) {
                    totalSales = sales;
                    mostDepartment = department;
                }
            }
            return mostDepartment;
        }
    }
}