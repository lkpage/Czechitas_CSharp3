
public class FizzBuzz
{
    public void CountTo(int lastNumber)
    {
        for (int currentNumber = 1; currentNumber < lastNumber; currentNumber++)
        {
            if (currentNumber % 3 == 0 && currentNumber % 5 == 0)
            {
                Console.WriteLine("FizzBuzz - divisible by 3 && 5");
            }
            else if (currentNumber % 3 == 0)
            {
                Console.WriteLine("Fizz - divisible by 3");
            }
            else if (currentNumber % 5 == 0)
            {
                Console.WriteLine("Buzz - divisible by 5");
            }
            else
            {
                Console.WriteLine(currentNumber);
            }
        }
    }
}
