using System.Security.Cryptography.X509Certificates;

namespace Finance.Main {
    public class Expense {
        private readonly DateTime _date;
        private readonly float _amount;
        readonly Category _category;

        public Expense(DateTime date, float amount, Category categories) {
            _date = date;
            _amount = amount;
            _category = categories;
        }

        public DateTime Date {get {return _date;}}
        public float Amount {get {return _amount;}}
        public Category Category {get {return _category;}}
        
    }
}