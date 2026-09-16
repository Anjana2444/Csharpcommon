using PaymentMethod;

Console.WriteLine();

Upi u1= new Upi();
u1.UpiId = 1;
Console.WriteLine($"Id : {u1.UpiId}");
u1.UpiPayment();
u1.Transaction();

Console.WriteLine();

DebitCard d1 = new DebitCard();
d1.CardNumber = 1;
Console.WriteLine($"Id : {d1.CardNumber}");
d1.CardStatus();
d1.Transaction();
