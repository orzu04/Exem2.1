


int n = Convert.ToInt32(Console.ReadLine());



int []nums = new int[n];
int k = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    nums[i] = Convert.ToInt32(Console.ReadLine());
  
}
int m = k;
int j = 0;
 for(int i=0;i<n;i++)
 {
    if (nums[i] ==m)
    m = nums[i];
    j = i;
    
     System.Console.Write(nums[i] + " " ); 
 }
 System.Console.WriteLine();
 System.Console.WriteLine(j);



 
