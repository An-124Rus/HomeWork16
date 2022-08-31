internal class Program
{
    private static void Main(string[] args)
    {
        int minRandomNumber = 1;
        int maxRandomNumber = 28;
        int minValue = 100;
        int maxValue = 999;
        int value = 0;
        int count = 0;

        Random multiplisity = new Random();
        int number = multiplisity.Next(minRandomNumber, maxRandomNumber);
        Console.WriteLine(number);

        for(int i = 1; i <= maxValue; i++)
        {
            value += number;

            if (value >= minValue && value <= maxValue)
            {
                Console.WriteLine($"{count}. {value}");
                count++;
            }            
        }

        Console.WriteLine($"Количество трёхзначных натуральных чисел кратных {number} равно {count}.");
    }
}