using InterfaceSample;

#region normalinstantiation
Phone p1 =new Phone();
p1.TakePhoto();
p1.TakeCall();

Console.WriteLine();

Tablet t1 = new Tablet();
t1.TakePhoto();
t1.TakeCall();

Console.WriteLine();

DigitalCamera d1 = new DigitalCamera();
d1.TakePhoto();

#endregion

#region usingInterface
ICamera p2= new Phone(); //cannot be instatiated
p2.TakePhoto();
p2 = new Tablet(); //??
p2.TakePhoto();

Console.WriteLine();


ICamera t2 = new Tablet();
t2.TakePhoto();

Console.WriteLine();


ICamera d2 = new DigitalCamera();
d2.TakePhoto();
MakeCall(p2);
#endregion

#region testfunctoin
void MakeCall(ICamera camera)
{
    Console.WriteLine("Call made successfully");
}
#endregion

Console.ReadLine();