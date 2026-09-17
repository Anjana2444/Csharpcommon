using InterfaceSample;

#region normalInstansittion

Phone p1 = new Phone();
p1.Call();
p1.TakePhoto();
Console.WriteLine();
Tablet t1 = new Tablet();
t1.Call();
t1.TakePhoto();

DigitalCamera d1 = new DigitalCamera();
d1.TakePhoto();
#endregion 

#region usingInterface
ICamera phtype = new Phone();
phtype.TakePhoto();
phtype.Call();

ICamera tabtype = new Tablet();
tabtype.TakePhoto();

ICamera digtype = new DigitalCamera();
digtype.TakePhoto();
MakeCall(p1);


#endregion

#region TestFunction

void MakeCall(ICamera camera)
{
    Console.WriteLine("Call Made sucessfully");
}

#endregion
Console.ReadLine();