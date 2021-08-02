using System;
using System.Collections.Generic;
using static BootcampFunctions.FindItemsOver20;
using static BootcampFunctions.MostProfitableDepartment;

namespace BootcampFunctions {
    class Program {
        static void Main(string[] args) {
            Greet greet = new Greet();
            var write =  greet.greet("Mcebo");
            Console.WriteLine(write);

            CountRegNumber count = new CountRegNumber();
            Console.WriteLine(count.countRegNumber("Mcebo, Magagula, So, Wj"));

            CountAllPaarl paarl = new CountAllPaarl();
            var OnlyPaarl = paarl.countAllPaarl("CL 900, CJ 678 543, CA 34567, CJ 67890, CN 7864, CJ 8765");
            Console.WriteLine(OnlyPaarl);

            
            Console.WriteLine("CountAllFromTownClass");

            CountAllFromTown city = new CountAllFromTown();
            var cities = city.countAllFromTown("CL 900, CJ 678 543, CA 34567, CJ 67890, CN 7864, CJ 8765", "CL");
            Console.WriteLine(cities);

            TotalPhoneBill bill = new TotalPhoneBill();
            var bills = bill.totalPhoneBill("call, sms, call, sms, sms");
            Console.WriteLine(bills);

            var itemsList2 =  new List<Items>() { 
                new Items(){ Qty = 56, Name="Bill"},
                new Items(){ Qty = 43, Name="Steve"},
                new Items(){ Qty = 2, Name="Ram"},
                new Items(){ Qty = 14, Name="Abdul"}
            };
            
            FindItemsOver20 over = new FindItemsOver20();
            var overs = over.findItemsOver20(itemsList2);
            Console.WriteLine(overs.Count);

            Console.WriteLine("MostProfitableDepartmentClass");
            Console.WriteLine("MostProfitableDepartmentClass");
            Console.WriteLine("MostProfitableDepartmentClass");

            var dep =  new List<MostDepartments>() { 
                new MostDepartments(){Department = "hardware", Sales = 4500, Day = "Monday"},
                new MostDepartments(){Department = "Okay", Sales = 90400, Day = "Monday"},
            };
            
            MostProfitableDepartment profit = new MostProfitableDepartment();
            Console.WriteLine(profit.mostProfitableDepartment(dep));

            
        }
    }
}
