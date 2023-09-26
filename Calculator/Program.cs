internal class Program
{
        double a, b;// следует давать значимые (передающие смысл) имена. Например number1 или firstNum
        char c; // следует давать значимые (передающие смысл) имена. Например typeOfTransaction
     // в методе Main не должно быть расчетов, весь функционал выносится в отдельные методы, а тут только их вызывают
    private static void Main(string[] args)
    {
       GetInputData();
       Calc();        
    }
     static void Calc()
     {
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
     static void GetInputData()
     {
         Console.WriteLine("Введите a ");
        a = Convert.ToDouble(Console.ReadLine()); // следовало добавить обработку исключения на случай, если не удалось конвертировать строку в число (например ввели дробное число или буквы)
        Console.WriteLine("Введите способ расчёта (+, -, *, /)");
        c = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("Введите b ");
        b = Convert.ToDouble(Console.ReadLine());         
     }
}
