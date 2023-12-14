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
                            Sum.Sum2Numbers(number1, number2);
                            break;
                        }
                    case "-":
                        {
                            Sub.Substract2Numbers(number1, number2);
                            break;
                        }
                    case "*":
                        {
                            Mult.Multiplicate2Numbers(number1, number2);
                            break;
                        }
                    case "/":
                        {
                            Dev.Devision2Numbers(number1, number2);
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
