internal class Program
{
    private static void Main(string[] args)
    {
        double a, b;
        char c;
        Console.WriteLine("Введите a ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите способ расчёта (+, -, *, /)");
        c = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("Введите b ");
        b = Convert.ToDouble(Console.ReadLine());
        switch (c)
        {
            case '+':
                Console.WriteLine("{0}+{1}={2}", a, b, a + b);
                break;
            case '-':
                Console.WriteLine("{0}-{1}={2}", a, b, a - b);
                break;
            case '*':
                Console.WriteLine("{0}*{1}={2}", a, b, a * b);
                break;
            case '/':
                Console.WriteLine("{0}/{1}={2}", a, b, a / b);
                break;
            default:
                Console.WriteLine("Ошибка");
                break;
        }
    }
}
