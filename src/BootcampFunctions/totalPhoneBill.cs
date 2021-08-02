namespace BootcampFunctions {
    public class TotalPhoneBillClass {
        public string TotalPhoneBill(string name){
            var nameSplited = name.Split(", ");
            double call = 0;
            double sms = 0;
            for (var index = 0; index<nameSplited.Length; index++){
                var trim = nameSplited[index].Trim();
                trim = trim.ToLower();
                if (trim == "call"){
                    call++;
                } if (trim == "sms"){
                    sms++;
                }
            }
            double totalCost = (double)(2.75 * call + 0.65 * sms);
            return $"R{totalCost:N2}";
        }
    }
}