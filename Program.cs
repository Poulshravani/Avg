namespace Avg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = { 10, 20, 30, 40, 50, };
            double sum = 0;

            foreach (int num in number)
            {
                sum += num;
            }
            double average = sum / number.Length;
            Console.WriteLine(average);
        }
    }
}
