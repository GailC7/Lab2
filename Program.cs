using ConsoleTables;

public class lab2
{
    static void Main(string[] args)
    {
        // #1
        Console.WriteLine("Enter a number");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nEnter a second number");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(num1 + " + " + num2 + " = " + (num1+num2));


        // #2
        Console.WriteLine("\nEnter a number");
        int multiNum = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nHow high to multiply by");
        int user = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nResult:");
        for (int i = 0; i <= user; i++)
        {
            Console.WriteLine(multiNum + "*" + (i) + " = " + (multiNum * (i)));
        }



        // #3
        //Console.WriteLine($"{sizeof(decimal)}");

        ConsoleTable table = new ConsoleTable("Type", "Byte(s) of Memory", "Min", "Max");
        table.AddRow("sbyte", "1" , "-128" , "127");
        table.AddRow("byte", "1", "0", "255");
        table.AddRow("short", "2", "-32768", "32767");
        table.AddRow("ushort", "2", "0", "65535");
        table.AddRow("int", "4", "-2147483648", "2147483647");
        table.AddRow("uint", "4", "0", "4294967295");
        table.AddRow("long", "8", "-9223372036854775808", "9223372036854775807");
        table.AddRow("ulong", "8", "0", "18446744073709551615");
        table.AddRow("float", "4", "-3.4028235E+38", "3.4025235E+38");
        table.AddRow("double", "8", "-1.7976931348623157E+308", "1.7976931348623157E+308");
        table.AddRow("decimal", "16", "-79228162514264337593543950335", "79228162514264337593543950335");

        table.Write();

        // #4
        bool exit = false;
        do
        {
            Console.WriteLine("\nEnter a number");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nSelect an operation + , - , * , or / ");
            String op = Console.ReadLine();

            Console.WriteLine("\nEnter a second number");
            int number2 = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case "+":
                    Console.WriteLine("\n" + number1 + " + " + number2 + " = " + (number1 + number2));
                    break;

                case "-":
                    Console.WriteLine("\n" + number1 + " - " + number2 + " = " + (number1 - number2));
                    break;

                case "*":
                    Console.WriteLine("\n" + number1 + " * " + number2 + " = " + (number1 * number2));
                    break;

                case "/":
                    Console.WriteLine("\n" + number1 + " / " + number2 + " = " + (number1 / number2));
                    break;

                default:
                    Console.WriteLine("\nInvalid Information Error");
                    exit = true;
                    break;

            }

            Console.WriteLine("\nDo another calculation?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");
            int choice = Convert.ToInt32(Console.ReadLine());

            if(choice == 1)
            {
                exit = false;

            }
            else
            {
                exit = true;
            }


        } while (exit == false);


    }//end main

}//end lab2

