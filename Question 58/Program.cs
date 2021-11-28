// See https://aka.ms/new-console-template for more information
int a = 2, b = 3, c = 5;

//(a)
Console.WriteLine("a");
int a1=++a;
Console.WriteLine("Valid Statement");
Console.WriteLine(a1);
Console.WriteLine(b);
Console.WriteLine(c);

//(b)
Console.WriteLine("b");
Console.WriteLine("Invalid Statement");

//(c)
Console.WriteLine("c");
int a2=a++;
Console.WriteLine("Valid Statement");
Console.WriteLine(a2);
Console.WriteLine(b);
Console.WriteLine(c);

//(d)
Console.WriteLine("d");
b += a;
Console.WriteLine("Valid Statement");
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);

//(e)
Console.WriteLine("e");
b += a * c;
Console.WriteLine("Valid Statement");
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);

//(f)
Console.WriteLine("f");
Console.WriteLine("Invalid Statement");

//(g)
Console.WriteLine("g");
a += 2;
b = 2 / 2;
c = a * b;
Console.WriteLine("Valid Statement");
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);

//(h)

Console.WriteLine("h");
Console.WriteLine("Invalid Statement");

//(i)
Console.WriteLine("i");
int b3 = a++ + b++;
Console.WriteLine("Valid Statement");
Console.WriteLine(a);
Console.WriteLine(b3);
Console.WriteLine(c);