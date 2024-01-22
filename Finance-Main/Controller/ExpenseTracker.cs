namespace Finance.Main {
    public class ExpenseTracker {
        public List<Expense> expenses;

        public ExpenseTracker(string path) {
            expenses = LoadFromFIle(path);
        }

        public List<Expense> LoadFromFIle(string path) {
            List<Expense> expenses = new List<Expense>();
            return expenses;
        }

        public List<Expense> CategorizeExpenses(string path) {
            List<Expense> expenses = new List<Expense>();
            return expenses;
        }

        public List<Expense> CalculateMontlyAverage(string path) {
            List<Expense> expenses = new List<Expense>();
            return expenses;
        }

        public List<Expense> SortByPrice(string path) {
            List<Expense> expenses = new List<Expense>();
            return expenses;
        }

        public List<Expense> SortByCategory(string path) {
            List<Expense> expenses = new List<Expense>();
            return expenses;
        }
    }
}