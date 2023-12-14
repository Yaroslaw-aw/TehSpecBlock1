namespace Seminar_1_DZ.Operations
{
    internal class Dev
    {
        public static void Devision2Numbers (double num1,  double num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("Попытка деления на ноль");
                return;
            }
            else
            {
                Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
            }
        }
    }
}
