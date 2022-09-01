
public class lab2
{
    static void Main(string[] args)
    {
        // #1
        Console.WriteLine("Enter a number");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter a second number");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(num1 + " + " + num2 + " = " + (num1+num2));

        // #2
        Console.WriteLine("Enter a number");
        int multiNum = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("How high to multiply by");
        int user = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(multiNum * user);
    }

}

