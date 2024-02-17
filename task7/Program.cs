

int sum =0;


int SumDigit(int n)
{
  if(n>0)
  {
   if(n==0)
   return 0;
   else{
       
        sum+=n%10;
 
        SumDigit(n/10);
        return sum;
   }
  }
  else{
    return 0;
  }

}

SumDigit(111);
System.Console.WriteLine(sum);
