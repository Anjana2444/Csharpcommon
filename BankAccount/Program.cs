using BankAccounts;

Console.WriteLine("OOPS Sample!");
SavingsAccount sa1 = new SavingsAccount();
sa1.SetName("Antony");
sa1.SetName("Antony", "Jacob");
double Balance_sa1 = sa1.CheckBalance();
Console.WriteLine($"Balance: {Balance_sa1}");
sa1.Withdraw(500);
Console.WriteLine($"Withdrawal: 500");
Balance_sa1 = sa1.CheckBalance();
Console.WriteLine($"Balance: {Balance_sa1}");
Console.WriteLine();

CurrentAccount ca1 = new CurrentAccount();
double Balance_ca1 = ca1.CheckBalance();
Console.WriteLine($"Balance: {Balance_ca1}");
ca1.Withdraw(800);
Console.WriteLine($"Withdrawal: 800");
Balance_ca1 = ca1.CheckBalance();
Console.WriteLine($"Balance: {Balance_ca1}");

Console.ReadLine();