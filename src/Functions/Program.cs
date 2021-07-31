using System;
using System.Collections.Generic;
using static Functions.FindItemsOver20Class;
using static Functions.MostProfitableDepartmentClass;

namespace Functions {
    class Program {
        static void Main(string[] args) {
            GreetPerson greet = new GreetPerson();
            var write =  greet.Greet("Mcebo");
            Console.WriteLine(write);

            CountRegNumberClass count = new CountRegNumberClass();
            Console.WriteLine(count.CountRegNumber("Mcebo, Magagula, So, Wj"));

            CountAllPaarlClass paarl = new CountAllPaarlClass();
            var OnlyPaarl = paarl.CountAllPaarl("CL 900, CJ 678 543, CA 34567, CJ 67890, CN 7864, CJ 8765");
            Console.WriteLine(OnlyPaarl);

            
            Console.WriteLine("CountAllFromTownClass");

            CountAllFromTownClass city = new CountAllFromTownClass();
            var cities = city.CountAllFromTown("CL 900, CJ 678 543, CA 34567, CJ 67890, CN 7864, CJ 8765", "CL");
            Console.WriteLine(cities);

            TotalPhoneBillClass bill = new TotalPhoneBillClass();
            var bills = bill.TotalPhoneBill("call, sms, call, sms, sms");
            Console.WriteLine(bills);

            var itemsList2 =  new List<Items>() { 
                new Items(){ Qty = 56, Name="Bill"},
                new Items(){ Qty = 43, Name="Steve"},
                new Items(){ Qty = 2, Name="Ram"},
                new Items(){ Qty = 14, Name="Abdul"}
            };
            
            FindItemsOver20Class over = new FindItemsOver20Class();
            var overs = over.FindItemsOver20(itemsList2);
            Console.WriteLine(overs.Count);

            Console.WriteLine("MostProfitableDepartmentClass");
            Console.WriteLine("MostProfitableDepartmentClass");
            Console.WriteLine("MostProfitableDepartmentClass");

            var dep =  new List<MostDepartments>() { 
                new MostDepartments(){Department = "hardware", Sales = 4500, Day = "Monday"},
                new MostDepartments(){Department = "Okay", Sales = 90400, Day = "Monday"},
            };
            
            MostProfitableDepartmentClass profit = new MostProfitableDepartmentClass();
            Console.WriteLine(profit.MostProfitableDepartment(dep));

            
        }
    }
}
