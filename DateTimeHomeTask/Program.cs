namespace DateTimeHomeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ReverseArray(1,2,3,4,5);

            string date=Console.ReadLine();
            AgeOfUser(date);
            
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

        static void AgeOfUser(string date)
        {
            DateTime dateBirth;
            bool result=DateTime.TryParse(date,out dateBirth);
            if (result)
            {
                dateBirth.ToString("MM/dd/yyyy");
                DateTime currentDate = DateTime.Now;
                int age = currentDate.Year - dateBirth.Year;
                Console.WriteLine(age);
            }
            else
            {
                Console.WriteLine("Enter correct format date.");
            }       
              
        }
    }
}