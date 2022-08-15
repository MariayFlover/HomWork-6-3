
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//       0, 7, 8, -2, -2 -> 2        1, -7, 567, 89, 223-> 3


/*
int Pozitiv (int size)
{
   int count = 0;
   int i = 0;

   while(i < size)
   {
      Console.Write($"input{i+1} element of {size}:");
      int num = Convert.ToInt32(Console.ReadLine());
      if(num > 0)
      count++;
      i++;
   }
   return count;
}
Console.Write("Input size :");
int size = Convert.ToInt32(Console.ReadLine());
int num2 = Pozitiv(size);
Console.Write($"{num2}  чисел больше 0:");
*/




// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//   b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

double Tochka (int b1, int k1, int b2, int k2)
{
   
  double x = (b2 - b1) / (k1 - k2);
  double y = k1 + (b2 - b1) / (k1 - k2) + b1;
   
}
Console.Write("Input coordinates b1: ");
int b1=Convert.ToInt32(Console.ReadLine());

Console.Write("Input coordinates b2: ");
int b2=Convert.ToInt32(Console.ReadLine());

Console.Write("Input coordinates k1: ");
int k1=Convert.ToInt32(Console.ReadLine());

Console.Write("Input coordinates k2: ");
int k2=Convert.ToInt32(Console.ReadLine());
double xy = Tochka(b1, k1, b2, k2);
Console.WriteLine(xy);
