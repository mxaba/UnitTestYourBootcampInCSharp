using System;
using System.Collections.Generic;
using BootcampFunctions.Models;


namespace BootcampFunctions {
    public class MostProfitableDepartment {

        public string mostProfitableDepartment(List<Department> listOfObjects) {
            var mostDepartment = "";
            var totalSales = 0;
            var myDict = new Dictionary<string, int>();

            for(var i = 0; i<listOfObjects.Count; i++){
                var sales = listOfObjects[i].Sales;
                var department = listOfObjects[i].DepartmentName;
                
                if(!myDict.ContainsKey(department)){
                    myDict.Add(department, 0);
                }
                myDict[department] += sales;
            }

            foreach(KeyValuePair<string, int> item in myDict)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
                if(item.Value > totalSales){
                    totalSales = item.Value;
                    mostDepartment = item.Key;
                }
            }
            
            return mostDepartment;
        }
    }
}
