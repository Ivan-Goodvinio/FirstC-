/* №1 - Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее. */

/*
int a, b;
 
    Console.WriteLine("Введите два числа : ");

        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
 
    if (a > b)
        Console.WriteLine("{0} Наибольшее число ", a);
 
    else
        Console.WriteLine("{0} Наибольшее число ", b);
 
Console.WriteLine();
*/





/* №2 - Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел. */

/*
int a, b, c;

    Console.WriteLine("Введите три числа: ");
    
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        c = Convert.ToInt32(Console.ReadLine());

  if (a>b)
    if (a>c)
        Console.WriteLine("{0} Максимальное число ", a);
    else
        Console.WriteLine("{0} Максимальное число ", c);

  else
    if (b>c)
        Console.WriteLine("{0} Максимальное число ", b);

    else
        Console.WriteLine("{0} Максимальное число ", c);

Console.WriteLine();
*/





/* №3 - Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка). */

/*
int a;

    Console.WriteLine("Введите число: ");
        a = Convert.ToInt32(Console.ReadLine());

    if ((a % 2) == 0)
            Console.WriteLine("Чётное");
    else
            Console.WriteLine("Не чётное");

Console.WriteLine();
*/




/* №4 - Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N. */

/*
int n;
int current = 1;

    Console.WriteLine("Введите ваше число N: ");
        n = Convert.ToInt32(Console.ReadLine());
        
while(current <= n)

{
    current += 1;
    Console.Write(current + " ");
    current++;
}

Console.WriteLine();
*/