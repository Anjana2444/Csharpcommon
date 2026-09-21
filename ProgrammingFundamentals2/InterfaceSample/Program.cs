using InterfaceSample;
Console.WriteLine("Learn Interface");

#region normal instantiation
Console.WriteLine("");
Phone p1 = new Phone();
p1.TakePhoto();
p1.Call(); 
//p1 = new Tablet(); //not possible

Console.WriteLine("");
Tablet t1 = new Tablet();
t1.TakePhoto();
t1.Call();

Console.WriteLine("");
DigitalCamera d1 = new DigitalCamera();
d1.TakePhoto();
MakeCall(d1);
#endregion

#region using interface
Console.WriteLine("");
Console.WriteLine("using interface");
Console.WriteLine("");
ICamera p2 = new Phone();
p2.TakePhoto();
p2=new Tablet(); //possible to do when using interface to instantiate a class.
//p2.Call(); // not possible as initiated with interface ICamera

Console.WriteLine("");
ICamera t2 = new Tablet();
t2.TakePhoto();

Console.WriteLine("");
ICamera d2 = new DigitalCamera();
d2.TakePhoto();
MakeCall(d2);
#endregion

#region test function
Console.WriteLine("");
void MakeCall(ICamera camera)
{
    Console.WriteLine("Call is successfully connected");
}
#endregion

Console.ReadLine();