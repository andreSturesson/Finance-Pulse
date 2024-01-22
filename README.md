# Finance-Pulse

## What is Finance-Pulse
A personal finance project, to track monthly expenses.

## Reason
A small project, designed and implemented in a day to improve planing skills/testing and datastructures.

### User Stories

```
As a user i want to keep track of my monthly expenses
By loaing in a .csv file.

As a user I want to catgorize bank statements by Transport, Playtime, Food & 
Vacation.

As a user I want to keep track of averages monthly expenses.

As a user I want be able to sort expenses by price or category.
```

### Domain Model

| Classes        | Properties                  | Methods                             | Returns |
|----------------|-----------------------------|-------------------------------------|---------|
| Expense        | DateTime Date :: Getter     |                                     |         |
|                | float Amount :: Getter      |                                     |         |
|                | Category Category :: Getter |                                     |         |
| Category       | string Category :: Getter   |                                     |         |
| ExpenseTracker | List<Expense> Expenses      | LoadFromFile(string path)           |         |
|                |                             | CategorizeExpenses()                |         |
|                |                             | CalculateMonthlyAverage()           |         |
|                |                             | SortExpensesByPrice()               |         |
|                |                             | SortByCategory()                    |         |
| TableBuilder   | StringBuilder builder       | CreateTable(List<Expense> expenses) |         |
|                |                             |                                     |         |
