

int c=0;


void Add(string a, int b)
{

if(c==b)
{
    System.Console.WriteLine();
}
else {

    System.Console.Write(a);
      c++;
    Add(a,b);
  
}

}

Add("ab",3);