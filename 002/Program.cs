// задачка 002. С клавиатуры вводятся два вещественных числа. Проверить является ли одно число из них квадратом второго. 

double a,b;
string s;
s = Console.ReadLine();
a = Convert.ToDouble(s);
s = Console.ReadLine();
b = Convert.ToDouble(s);

if (a * a == b)
System.Console.WriteLine("b является квадратом числа a");
if (b * b == a)
System.Console.WriteLine("a является квадратом числа b");
else
System.Console.WriteLine("введи снова числа");

