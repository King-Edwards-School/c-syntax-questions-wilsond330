namespace Console_Blank_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QuestionSix();
        }

        static void RomanNumerals()
        {
            Console.Write("Enter an integer. ");
            string firstNumber = Console.ReadLine();
            Console.Write("Enter another integer. ");
            string secondNumber = Console.ReadLine();
            int firstInt = Convert.ToInt32(firstNumber);
            int secondInt = Convert.ToInt32(secondNumber);
            int finalNumber = 0;
            if (firstInt > secondInt)
            {
                finalNumber = firstInt / secondInt;
            }
            else
            {
                finalNumber = secondInt / firstInt;
            }
            int count = 0;
            while (count!=finalNumber)
            {
                count++;
                if (count % 10 == 0)
                {
                    Console.Write("X");
                }
                else
                {
                    if (count % 5 == 0)
                    {
                        Console.Write("V");
                    }
                    else
                    {
                        Console.Write("/");
                    }
                }
            
        }
            
        }
        static void FindPrimeFactors()
        {
            Console.Write("Enter an integer greater than 1: ");
            string inputNumber = Console.ReadLine();
            int x = 2;
            int count = 0;
            int inputInt = Convert.ToInt32(inputNumber);
            bool multi = false;
            while (inputInt > 1)
            {
                multi = false;
                while (inputInt % x == 0)
                {
                    if (!multi)
                    {
                        Console.WriteLine(x);
                    }
                    count++;
                    multi = true;
                    inputInt = inputInt / x;
                }
                x++;
            }
            Console.WriteLine(count);
        }
        static void FindConsecutiveFactors()
        {
            Console.WriteLine("Input an integer greater than 1: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int product = 1;
            int factor = 0;
            while (product < x)
            {
                factor++;
                product *= factor;
            }
            if (x == product)
            {
                product = 1;
                for (int n =1; n <= factor; n++)
                {
                    product *= n;
                    Console.WriteLine(n);
                }
            }
            else
            {
                Console.WriteLine("No result. ");
            }
        }
        static void FindNumberPersistence()
        {
            Console.Write("Enter integer (0-99): ");
            int value = Convert.ToInt32(Console.ReadLine());
            Console.Write("Calculate additive or multiplicative persistence (a or m)? ");
            string operation = Console.ReadLine();
            int count = 0;
            while (value > 9) //we use a while loop because we don't know how many times the loop will have to run. 
            {
                if (operation == "a")
                {
                    value = (value / 10) + (value % 10);
                }
                else
                {
                    value = (value / 10) * (value % 10);
                }
                count++;
            }
            Console.WriteLine("The persistence is: " + count);
        }
        static void ConvertToBinary()
        {
            Console.Write("Enter a positive whole number: ");
            int numberIn = Convert.ToInt32(Console.ReadLine());
            int numberOut = 0;
            int count = 0;
            int partValue = 0;
            while (numberIn > 0)
            {
                count++;
                partValue = numberIn % 2;
                numberIn /= 2;
                for (int i = 1; i < count; i++)
                {
                    partValue *= 10;
                }
                numberOut += partValue;
            }
            Console.WriteLine("The result is: " + numberOut);
        }
        static void QuestionSix()
        {
            int c = 0;
            int d = 0;
            int s = 0;
            int t = 0;
            int n1 = 0;
            int n2 = 0;
            while (c < 3 && d < 3)
            {
                t++;
                Random rand = new Random();
                n1 = rand.Next(1,7);
                n2 = rand.Next(1,7);
                Console.WriteLine(n1 + ", " + n2);
                s = s + n1 + n2;
                if (n1 == 6 || n2 == 6)
                {
                    c++;
                }
                if (n1 == n2)
                {
                    d++;
                }
            }
            int a = s / (2 * t);
            Console.WriteLine(c + ", " + d + ", " + a);
            //outputs number of sixes, number of times the dice were equal, and the average roll.
        }
    }
}