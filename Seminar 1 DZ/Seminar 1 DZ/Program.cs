namespace Seminar_1_DZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                throw new Exception("Ничего не введено");
            }

            if (!double.TryParse(args[0], out double number1) || !double.TryParse(args[2], out double number2))
            {
                throw new Exception("Неверный ввод");
            }

            switch (args[1])
            {
                case "+":
                    {
                        Console.WriteLine(number1 + number2);
                        break;
                    }
                case "-":
                    {
                        Console.WriteLine(number1 - number2);
                        break;
                    }
                case "*":
                    {
                        Console.WriteLine(number1 * number2);
                        break;
                    }
                case "/":
                    {
                        if (number2 != 0)
                        {
                            Console.WriteLine(number1 / number2);
                        }
                        else
                        {
                            Console.WriteLine("Попытка деления на ноль. А так нельзя");
                        }
                        break;
                    }
            }
        }
    }
}
