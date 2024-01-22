using Finance.Main;

public class ExpenseTrackerTests
{

    private ExpenseTracker tracker;
    [SetUp]
    public void Setup()
    {
        tracker = new ExpenseTracker(".file.csv");
    }

    [Test]
    public void CanInstansiateAndLoadFromFile()
    {
        Assert.That(tracker.expenses.Count, Is.AtLeast(1));
        Assert.That(tracker.expenses[0].Amount, Is.EqualTo(25));
        Assert.That(tracker.expenses[0].Category.Type, Is.EqualTo(Categories.PLAYTIME));
        DateTime date = new DateTime();
        date.AddDays(10);
        Assert.That(tracker.expenses[0].Date.Day, Is.EqualTo(date.Day));
    }

    [TestCase ("")]
    [TestCase ("sdfgds")]
    [TestCase ("\\dsdsaf\\#@!")]
    [TestCase ("test.excel")]
    public void CanNotInstansiateAndLoadFromFile(string path)
    {
        Assert.That(tracker.expenses, Is.Null);
    }

    public void CanCategorizeExpenses() {
        List<Expense> categorized = tracker.CategorizeExpenses();
        List<Expense> sortedExpenses = categorized.OrderBy(e => e.Category).ToList();
        Assert.That(categorized, Is.EqualTo(sortedExpenses));
    }

    public void CanCalculateMonthlyAverage() {
        Dictionary<float, List<Expense>> average = tracker.CalculateMontlyAverage();
        float[] array = [10,10,10,10,10,10,10,10,10,10,10,10];
        for (int i = 0; i < array.Length; i++)
        {
            Assert.That(average.ElementAt(i).Key, Is.EqualTo(array[i]));
        }
    }

    public void CanSortByPrice() {
        List<Expense> categorized = tracker.CategorizeExpenses();
        List<Expense> sortedExpenses = categorized.OrderBy(e => e.Category).ToList();
        Assert.That(categorized, Is.EqualTo(sortedExpenses));
    }
}