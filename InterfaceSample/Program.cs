using InterfaceSample;

#region normalinstantiation

//Phone p1 = new Phone();
//p1.Call();
//p1.TakePhoto();


//Console.WriteLine();

//Tablet t1 = new Tablet();
//t1.Call();
//t1.TakePhoto();

//Console.WriteLine();

//DigitalCamera d1= new DigitalCamera();
//d1.TakePhoto();

#endregion 

#region usinginterface
//ICamera p2 = new Phone();
//p2.TakePhoto();
//p2 = new Tablet();

//ICamera t2 = new Tablet();
//t2.TakePhoto();

//ICamera d2 = new DigitalCamera();
//d2.TakePhoto();
////MakeCall(p2);


#endregion

#region testfunction

//void MakeCall(ICamera camera) 
//{
//    Console.WriteLine("Call made successfully.");
//}

#endregion

#region declaredasclasses

NormalPrinter normalPrinter1 = new NormalPrinter();
//Console.WriteLine("Enter the number of pages to print: ");
//normalPrinter1.PagesToPrint = Convert.ToInt32(Console.ReadLine());
normalPrinter1.Print();

Console.WriteLine();

AdvancedPrinter advancedPrinter1 = new AdvancedPrinter();
advancedPrinter1.Print();
advancedPrinter1.Scan();

Console.WriteLine();

MultiFunctionPrinter multiFunctionPrinter1 = new MultiFunctionPrinter();
multiFunctionPrinter1.Print();
multiFunctionPrinter1.Scan();
multiFunctionPrinter1.Fax();
#endregion

#region declaredasinterface

//IPrintable normalPrinter1 = new NormalPrinter();
//normalPrinter1.Print();

//Console.WriteLine();

//IScannable advancedPrinter1 = new AdvancedPrinter();
//advancedPrinter1.Scan();

//Console.WriteLine();

//IFaxable multiFunctionPrinter1 = new MultiFunctionPrinter();
//multiFunctionPrinter1.Fax();


#endregion

Console.ReadLine();
