using Seminar_1_DZ.Operations;

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

                switch (args[1])
                {
                    case "+":
                        {
                            Summation.Sum2Numbers(number1, number2);
                            break;
                        }
                    case "-":
                        {
                            Substract.Substract2Numbers(number1, number2);
                            break;
                        }
                    case "*":
                        {
                            Multiplication.Multiplicate2Numbers(number1, number2);
                            break;
                        }
                    case "/":
                        {
                            Devision.Devision2Numbers(number1, number2);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Введен не верный оператор");
                            break;
                        }
                }
            }
            else
            {
                Console.WriteLine("Для использования программы введите: число знак(+-/*) число");
            }
        }
    }
}
