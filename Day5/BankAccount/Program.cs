using BankAccounts;

SavingsAccount s1 = new SavingsAccount();
s1.SetName("Chris");
double Balance=s1.CheckBalance();
Console.WriteLine($"Current Balce in your savings acoount: {Balance}");
Console.WriteLine("Enter the amount to withdraw");
int a = int.Parse(Console.ReadLine()!);
s1.Withdraw(a);
Balance = s1.CheckBalance();
Console.WriteLine($"Current Balce in your savings acoount: {Balance}");

Console.WriteLine();

CurrentAccount c1= new CurrentAccount();
double Balance2 = c1.CheckBalance();
Console.WriteLine($"Current Balce in your current acoount: {Balance2}");
Console.WriteLine("Enter the amount to withdraw");
a = int.Parse(Console.ReadLine()!);
c1.Withdraw(a);
Balance2 = c1.CheckBalance();
Console.WriteLine($"Current Balce in your current acoount: {Balance2}");



Console.ReadLine();