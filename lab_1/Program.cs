using lab_1;
using System;


public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Первая доробь:");
        Console.Write("\tвведите числитель: ");
        int m1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("\tвведите знаменатель: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        rational r1 = new rational(m1, n1);
        Console.Write("Получившаяся дробь: ");
        Console.WriteLine(r1.ToString());

        Console.WriteLine("\nВведите вторую дробь: ");
        Console.Write("\tвведите числитель: ");
        int m2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("\tвведите знаменатель: ");
        int n2 = Convert.ToInt32(Console.ReadLine());
        rational r2 = new rational(m2, n2);
        Console.Write("Получившаяся дробь: ");
        Console.WriteLine(r2.ToString());

        rational result = new rational(0, 1);

        Console.WriteLine("\nСумма дробей: ");
        result = r1 + r2;
        Console.WriteLine(result.ToString());


        Console.WriteLine("\nРазница дробей: ");
        result = r1 - r2;
        Console.WriteLine(result.ToString());

        Console.WriteLine("\nПроизведение дробей: ");
        result = r1 * r2;
        Console.WriteLine(result.ToString());


        Console.WriteLine("\nДеление дробей: ");
        result = r1 / r2;
        Console.WriteLine(result.ToString());


        Console.WriteLine("\nДробь с противоположным знаком: ");
        result = -r1;
        Console.WriteLine(result.ToString());
        result = -r2;
        Console.WriteLine(result.ToString());

        Console.WriteLine("\nПроверка на == и !=");
        if (r1 == r2)
            Console.WriteLine($"{r1.ToString()} == {r2.ToString()}");
        else if (r1 != r2)
            Console.WriteLine($"{r1.ToString()} != {r2.ToString()}");


        Console.WriteLine("\nПроверка на < и >");
        if (r1 < r2)
            Console.WriteLine($"{r1.ToString()} < {r2.ToString()}");
        else if (r1 > r2)
            Console.WriteLine($"{r1.ToString()} > {r2.ToString()}");

        Console.WriteLine("\nПроверка на <= и >=");
        if (r1 <= r2)
           Console.WriteLine($"{r1.ToString()} <= {r2.ToString()}");
        if (r1 >= r2)
           Console.WriteLine($"{r1.ToString()} >= {r2.ToString()}");


        TimeEuro timeEu = new();
        TimeUS timeUS = new();
        Console.WriteLine(timeEu.ShowTime());
        Console.WriteLine(timeUS.ShowTime());
        TimeEuDecorator timeEuDecorator = new TimeEuDecorator(new TimeEuro());
        TimeUSDecorator timeUSDecorator = new TimeUSDecorator(new TimeUS());
        Console.WriteLine(timeEuDecorator.ShowTime());
        Console.WriteLine(timeUSDecorator.ShowTime());

        Console.WriteLine("\nВывод феодалов по старшинству: ");
        tree first = new tree("Король");
        tree second = new tree("\tГерцог");
        tree third = new tree("\t\tГраф");
        tree fourth = new tree("\t\t\tБарон");
        tree fifth = new tree("\t\t\t\tРыцарь");

        first.Add(second);
        first.Add(third);
        first.Add(fourth);
        first.Add(fifth);

        second.Add(third);
        second.Add(fourth);
        second.Add(fifth);

        third.Add(fourth);
        third.Add(fifth);

        fourth.Add(fifth);

        List<string> res= first.output();
        foreach (string item in res)
        {
            Console.WriteLine(item);
        }
    }
}

