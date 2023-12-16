namespace Seminar_1_DZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 3)
            {
                double number1 = double.Parse(args[0]);
                double number2 = double.Parse(args[2]);

                double? result = default;

                string operation = args[1];                

                switch (operation)
                {
                    case "+":
                        {
                            result = number1 + number2;
                            break;
                        }
                    case "-":
                        {
                            result = number1 - number2;
                            break;
                        }
                    case "*":
                        {
                            result = number1 * number2;
                            break;
                        }
                    case "/":
                        {
                            result = Devision(number1, number2);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Введен неверный оператор");
                            break;
                        }
                }

                if (result != null) 
                    Console.WriteLine($"{number1} {operation} {number2} = {result}");
            }
            else
            {
                Console.WriteLine("Для использования программы введите: число знак(+-/*) число");
            }

            double? Devision(double num1, double num2)
            {
                if (num2 == 0)
                {
                    Console.WriteLine("Попытка деления на ноль");
                    return null;
                }
                else
                {
                    return num1 / num2;
                }
            }
        }
    }
}
