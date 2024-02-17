
int sum =0;

int SumOfDigits(int n)

{

  for(int i=n;i>0;i/=10)
  {
    sum+=i%10;
  }
  return sum;

}
SumOfDigits(1234);
System.Console.Write($"The sum of the digits of the number 1234 is : ");
System.Console.WriteLine($"{sum}");