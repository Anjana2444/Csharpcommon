using Learning;

Console.WriteLine("Hello, World!");

BankAccount B1 = new BankAccount();
B1.AccountHolder = "Alice";
B1.balance = 1500.505f;
Console.WriteLine("Account holder name: " + B1.AccountHolder);
Console.WriteLine("Balance: " + B1.balance);

Console.ReadLine();