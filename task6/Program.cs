

int c;

void Swap(ref int a, ref int b)
{
 
     c =a;
     a = b;
     b =c;
}

int a = 5;
int b = 10;
System.Console.WriteLine($"{a} {b}");
Swap( ref a, ref b);


System.Console.WriteLine($"{a} {b}");



