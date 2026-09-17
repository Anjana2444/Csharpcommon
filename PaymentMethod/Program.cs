using PaymentMethod;

UPI u1 = new UPI();
u1.UpiID = 213;
Console.WriteLine($"UPI ID: {u1.UpiID}");
u1.UpiPayment();
u1.Transaction();
u1.SendNotification();
Console.WriteLine();

DebitCard d1 = new DebitCard();
d1.CardNumber = 123456789;
Console.WriteLine($"Debit Card Number: {d1.CardNumber}");
d1.DebitCardPayment();
d1.Transaction();
d1.SendNotification();
Console.WriteLine();

CreditCard c1 = new CreditCard();
c1.CardNumber = 987654321;
Console.WriteLine($"Credit Card Number: {c1.CardNumber}");
c1.CreditCardPayment();
c1.Transaction();
c1.SendNotification();