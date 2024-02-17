




void IncrementArrayElements(ref int[] arr, ref int a)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] += a;
    }
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
}
int[] arr = new int[]{1, 2, 3};
int a = Convert.ToInt32(Console.ReadLine());
IncrementArrayElements(ref arr,ref a);
