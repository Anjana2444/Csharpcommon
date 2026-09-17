using InterfaceSample;

#region Normal Instantiation
Console.WriteLine("Phone");
Phone p1  = new Phone();
p1.TakePhoto();
p1.Call();
Console.WriteLine();

Console.WriteLine("Tablet");
Tablet t1 = new Tablet();
t1.TakePhoto();
t1.Call();
Console.WriteLine();

Console.WriteLine("Digital Camera");
DigitalCamera dc1 = new DigitalCamera();
dc1.TakePhoto();
Console.WriteLine();
#endregion

#region Using Interface
ICamera phone = new Phone();
phone.TakePhoto();
phone = new Tablet();

ICamera tablet = new Tablet();
tablet.TakePhoto();

ICamera digitalCamera = new DigitalCamera();
digitalCamera.TakePhoto();
MakeCall(phone);
Console.WriteLine();
#endregion

#region Test Function Call
void MakeCall(ICamera camera)
{
    Console.WriteLine("Making a Call");
}
#endregion

Console.ReadLine();