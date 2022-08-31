internal class Program
{
    private static void Main(string[] args)
    {
        int minRandomNumber = 1;
        int maxRandomNumber = 28;
        int minValue = 100;
        int maxValue = 999;        
        int count = 0;

        Random multiplisity = new Random();
        int number = multiplisity.Next(minRandomNumber, maxRandomNumber);
        Console.WriteLine(number);

        for(int i = 0; i <= maxValue; i += number)
        {
            if (i >= minValue)
            {
                count++;
                Console.WriteLine($"{count}. {i}");
            }            
        }

        Console.WriteLine($"Количество трёхзначных натуральных чисел кратных {number} равно {count}.");
    }
}