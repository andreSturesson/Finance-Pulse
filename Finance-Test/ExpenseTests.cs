using Finance.Main;
using NUnit.Framework;
using System;

[TestFixture]
public class ExpenseTests
{
    [Test]
    public void ExpenseInitializesPropertiesCorrectly()
    {
        DateTime date = new DateTime(2022, 1, 1);
        float amount = 100.00f;
        Category category = new Category(Categories.FOOD);

        Expense expense = new Expense(date, amount, category);

        Assert.That(date, Is.EqualTo(expense.Date));
        Assert.That(amount, Is.EqualTo(expense.Amount));
        Assert.That(category, Is.EqualTo(expense.Category));
    }

    [Test]
    public void ExpenseReturnCorrectValues()
    {
        DateTime date = new DateTime(2022, 2, 15);
        float amount = 75.50f;
        Category category = new Category(Categories.TRANSPORT);

        Expense expense = new Expense(date, amount, category);

        DateTime returnedDate = expense.Date;
        float returnedAmount = expense.Amount;
        Category returnedCategory = expense.Category;

        Assert.That(date, Is.EqualTo(returnedDate));
        Assert.That(amount, Is.EqualTo(returnedAmount));
        Assert.That(category, Is.EqualTo(returnedCategory));
    }
}
