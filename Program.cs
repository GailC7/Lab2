using ConsoleTables;

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

        Console.WriteLine("Result:");
        for (int i = 0; i <= user; i++)
        {
            Console.WriteLine(multiNum + "*" + (i) + " = " + (multiNum * (i)));
        }



        // #3
        Console.WriteLine($"{sizeof(decimal)}");

        ConsoleTable table = new ConsoleTable("Name");
   

        // #4
        

        bool exit
        if(exit =! true)
        { 
            Console.WriteLine("Enter a number");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Select an operation + , - , * , or / ");
            String op = Console.ReadLine();

            Console.WriteLine("Enter a second number");
            int number2 = Convert.ToInt32(Console.ReadLine());

            switch(op)
            {
                case '+': 
                    Console.WriteLine(number1 + " + " + number2 + " = " + (number1 + number2);
                    break;

                case '-': 
                    Console.WriteLine(number1 + " - " + number2 + " = " + (number1 - number2);
                    break;

                 case '*': 
                    Console.WriteLine(number1 + " * " + number2 + " = " + (number1 * number2);
                    break;

                 case '/': 
                    Console.WriteLine(number1 + " / " + number2 + " = " + (number1 / number2);
                    break;

                  default:
                    Console.WriteLine("Operation Error");
            }

            
        }
        else
        { 
            
        }

       
    }

}

