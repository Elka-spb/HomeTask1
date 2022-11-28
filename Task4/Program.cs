//task 4
Console.Clear();
Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число c: ");
int c = Convert.ToInt32(Console.ReadLine());
if (a >= b && a >= c) 
    Console.WriteLine(a);
if (b >= a && b >= c) 
    Console.WriteLine(b);
if (c >= a && c >= b) 
    Console.WriteLine(c);
