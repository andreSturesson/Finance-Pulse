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

        public List<Expense> CategorizeExpenses() {
            List<Expense> expenses = new List<Expense>();
            return expenses;
        }

        public Dictionary<float, List<Expense>> CalculateMontlyAverage() {
            Dictionary<float, List<Expense>> expenses = new Dictionary<float, List<Expense>>();
            return expenses;
        }

        public List<Expense> SortByPrice() {
            List<Expense> expenses = new List<Expense>();
            return expenses;
        }

        public List<Expense> SortByCategory() {
            List<Expense> expenses = new List<Expense>();
            return expenses;
        }
    }
}