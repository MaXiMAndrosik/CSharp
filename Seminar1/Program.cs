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
//      Console.WriteLine("Введенные числа равны '"+num1+"'");

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

Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number%2 == 0)
    Console.Write("Число '"+number+"' четное");
else
    Console.Write("Число '"+number+"' нечетное");
