// ЗАДАЧА 1

// Console.Clear();
// int max = 0; int min = 0;
// Console.Write("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1>num2)
//      {max = num1; min = num2;
//      Console.WriteLine("Первое число '"+num1+"' больше чем второе число '"+num2+"'");}
// if (num1<num2)  
//      {max = num2; min = num1;
//     Console.WriteLine("Первое число '"+num1+"' меньше чем второе число '"+num2+"'");}
// if (num1==num2)
//      Console.WriteLine("Введенные числа равны "+num1+"'");

// ЗАДАЧА 2

// Console.Clear();
// Console.Write("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите третье число: ");
// int num3 = Convert.ToInt32(Console.ReadLine());
// int max = num1;
// if (num2>max)
//      max = num2;
// if (num3>max)
//      max = num3;
// Console.Write("Максимальное число: '"+max+"'");

// ЗАДАЧА 3

// Console.Clear();
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number%2 == 0)
//     Console.Write("Число '"+number+"' чётное");
// else
//     Console.Write("Число '"+number+"' нёчетное");

// ЗАДАЧА 4

// Console.Clear();
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int i = 2;
// while (i <= number)
// {
//     Console.Write(i+"\t");
//     i += 2; // i = i + 1;
// }

// comment
/*
comment
comment
*/
// ctrl + /

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(n + 10);

// ----------------------------------------------------------------------------------------------------------------
// Напишите программу, которая на вход
// принимает два целых числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5 => да
// a = 2, b = 10 => нет
// a = 9, b = -3 => да
// a = -3, b = 9 => нет

// Console.Clear();
// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число: ");
// int b = Convert.ToInt32(Console.ReadLine());

// if (b * b == a)
//     Console.WriteLine("yes");
// else
//     Console.WriteLine("no");

// -------------------------------------------------------------------------------------------------------------------
// Напишите программу, которая на вход принимает
// целое число N, а на выходе показывает все целые
// числа в промежутке от -N до N.
// Примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int i = n * (-1);
// while (i <= n)
// {
//     Console.Write(i + " ");
//     i += 1; // i = i + 1;
// }

// ---------------------------------------------------------------------------------------------------------------------------
// Напишите программу, которая принимает на вход
// трёхзначное целое число и на выходе показывает сумму
// первой и последней цифры этого числа.
// 456 => 10
// 782 => 9
// 918 => 17

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int n1 = n / 100; // 456 / 100 -> 4(56 ost) = 4
int n3 = n % 10; // 456 % 10 -> 45(6 ost) = 6
Console.WriteLine(n1 + n3);

// 7 / 3 -> 2 (1 ost) = 2
// 7 % 3 -> 2 (1 ost) = 1
// 7.0 / 3 = 2.33