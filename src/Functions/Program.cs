using System;

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
            foreach( string printPaarl in OnlyPaarl ) {
                Console.WriteLine(printPaarl);
            }
            
            Console.WriteLine("CountAllFromTownClass");

            CountAllFromTownClass city = new CountAllFromTownClass();
            var cities = city.CountAllFromTown("CL 900, CJ 678 543, CA 34567, CJ 67890, CN 7864, CJ 8765", "CL");
            foreach( string printPaarl in cities ) {
                Console.WriteLine(printPaarl);
            }

            TotalPhoneBillClass bill = new TotalPhoneBillClass();
            var bills = bill.TotalPhoneBill("call, sms, call, sms, sms");
            Console.WriteLine(bills);
        }
    }
}
