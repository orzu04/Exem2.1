

int n = Convert.ToInt32(Console.ReadLine());
int Even=0;
int Odd=0;
int Digit=0;
int sum =0;

for(int i=n;i>0;i/=10 )
{

    Digit++;
}
System.Console.WriteLine($"Digit: {Digit}");


for(int i=n;i>0;i/=10 )
{

    if(i%2==0)
    {
        Even++;
    }
    else{
     
    }
}


System.Console.WriteLine($"Even: {Even}");

for(int i=n;i>0;i/=10 )
{

    if(i%2!=0)
    {
        Odd++;
    }
    else{
     
    }
}

System.Console.WriteLine($"Odd; {Odd}");

for(int i=n;i>0;i/=10)
{
    sum+=i%10;
}

  
System.Console.WriteLine($"Sum: {sum}");