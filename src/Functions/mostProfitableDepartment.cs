using System.Collections.Generic;
using System;

namespace Functions {
    public class MostProfitableDepartmentClass {

        public class MostDepartments {
            public int Sales {get; set;}
            public string Department {get; set;}
            public string Day {get; set;}
        }

        public class Departments {
            public int hardware {get; set;}
            public int outdoor {get; set;}
            public int carpentry {get; set;}
            public int electronics {get; set;}
        }

        public List<MostDepartments> MostProfitableDepartment(List<MostDepartments> listOfObjects) {
            var newListOfObjects = new List<MostDepartments>();
            foreach (var item in listOfObjects) {
                if(item.Department == "outdoor") {
                }
            }
            return newListOfObjects;
        }
    }
}