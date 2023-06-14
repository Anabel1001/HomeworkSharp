// Задача2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

System.Console.WriteLine("Введите первое число:");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число:");
int number1 = Convert.ToInt32(Console.ReadLine());

if(number > number1)
{
    System.Console.WriteLine($"Большее, {number}");
    System.Console.WriteLine($"Меньшее, {number1}");
}
else 
{
    System.Console.WriteLine($"Большее {number1}");
    System.Console.WriteLine($"Меньшее {number}");
}

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

System.Console.WriteLine("Введите первое число:");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число:");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());
int max = number;
{
    if(number1>max) max = number1;
    if(number2>max) max = number2;
}
System.Console.WriteLine(max);

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

System.Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
if(number%2==0)
{
    System.Console.WriteLine("Число четное");
}
else 
{
    System.Console.WriteLine("Число нечетное");
}

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

System.Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int index = 0;
while(index <=number);
{
    if(index%2 ==0)
        System.Console.Write(index + "");
    index++;
}