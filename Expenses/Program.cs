using System.IO;


Console.WriteLine("Welcome in Expenses");
Console.WriteLine("Create by Patryk Pieczka");
Earnings earnings = new Earnings();
earnings.Show();
Expenses expenses = new Expenses();
expenses.Show();
Savings savings = new Savings();
savings.Show();
Console.WriteLine("Select action");
Console.WriteLine("1: Add a purchase");
Console.WriteLine("2: Show a Purchase");
Console.WriteLine("3: Determine your earnings");
Console.WriteLine("4: Determine your expenses");
Console.WriteLine("5: Determine your savings");






Life life = new Life("meat" , 40);

//life.WriteText();
//life.ReadText();




GC.Collect();
//Console.ReadKey();

