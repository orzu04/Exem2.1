
string a = "n";

  string  IsPalindrome(int n)
 {

   if(n==0)
   {
     return "0";
   }
   else 
   {
       n%=10;
       return IsPalindrome(n/10);

   }

 }
 IsPalindrome(1001);


 


