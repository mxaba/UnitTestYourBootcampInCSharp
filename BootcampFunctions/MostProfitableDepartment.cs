using System.Collections.Generic;
using BootcampFunctions.Models;


namespace BootcampFunctions {
    public class MostProfitableDepartment {

        public string mostProfitableDepartment(List<Department> listOfObjects) {
            var mostDepartment = "";
            var totalSales = 0;

            for(var i = 0; i<listOfObjects.Count; i++){
                var sales = listOfObjects[i].Sales;
                var department = listOfObjects[i].DepartmentName;

                if (sales > totalSales) {
                    totalSales = sales;
                    mostDepartment = department;
                }
            }
            return mostDepartment;
        }
    }
}
