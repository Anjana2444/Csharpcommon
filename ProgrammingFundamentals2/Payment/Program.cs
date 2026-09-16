using Payment; //Part of Oops project
Console.WriteLine("Payment details");

//Payments p1 = new Payments(); // cannot create object as the parent class is prohibitted from creating object

Upi u1 = new Upi();
u1.PaymentId = 1;
u1.DisplayDetails();
u1.UpiId = 132;
Console.WriteLine($"Upi {u1.UpiId}");
u1.Transaction();
u1.UpiPayment();
u1.SendNotification();

Credit c1 = new Credit();
c1.PaymentId = 2;
c1.DisplayDetails();
c1.CreditID = 132;
Console.WriteLine($"Credit {c1.CreditID}");
c1.Transaction();
c1.CreditPayment();
c1.SendNotification();