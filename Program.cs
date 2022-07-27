// найти точку пересечения двух прямых 
Console.WriteLine("введите кооэфициент k1=");
double k1=double.Parse(Console.ReadLine () ?? "0");
Console.WriteLine("введите кооэфициент b1=");
double b1=double.Parse(Console.ReadLine () ?? "0");
Console.WriteLine("введите кооэфициент k2=");
double k2=double.Parse(Console.ReadLine () ?? "0");
Console.WriteLine("введите кооэфициент b2=");
double b2=double.Parse(Console.ReadLine () ?? "0");
double x=(b2-b1)/(k1-k2);
double y=((b2*k1-b1*k2)/(k1-k2));
Console.Write($"координата точки пересечения двух прямых x={x}");
Console.Write($" y={y}");