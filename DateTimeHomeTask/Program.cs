namespace DateTimeHomeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReverseArray(1,2,3,4,5);
        }

        static void ReverseArray(params int[] arr)
        {
            int[] result = new int[arr.Length];
            int j = 0;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                result[j] = arr[i];
                j++;
            }
            foreach (var item in result)
            {
                Console.Write(item+" ");
            }
        }
    }
}