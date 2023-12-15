namespace Seminar_1_DZ.Operations
{
    internal class Devision
    {
        public static double? Devision2Numbers (double num1,  double num2)
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
