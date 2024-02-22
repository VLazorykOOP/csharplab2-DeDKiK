using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Завдання 1 з одновимірним масивом
        Console.WriteLine("Завдання 1 з одновимірним масивом:");
        Console.Write("Введіть розмірність масиву: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] array1D = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введіть елемент {i + 1}: ");
            array1D[i] = Convert.ToInt32(Console.ReadLine());
        }
        int sum = array1D.Where(x => x % 9 == 0).Sum();
        Console.WriteLine($"Сума елементів, кратних 9: {sum}");

        // Завдання 1 з двовимірним масивом
        Console.WriteLine("\nЗавдання 1 з двовимірним масивом:");
        Console.Write("Введіть розмірність масиву: ");
        n = Convert.ToInt32(Console.ReadLine());
        int[,] array2D = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"Введіть елемент [{i + 1}, {j + 1}]: ");
                array2D[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        sum = array2D.Cast<int>().Where(x => x % 9 == 0).Sum();
        Console.WriteLine($"Сума елементів, кратних 9: {sum}");

         // Завдання 2 
 Console.WriteLine("\nЗавдання 2:");
 Console.Write("Введіть розмірність масиву: ");
 n = Convert.ToInt32(Console.ReadLine());
 double[] array = new double[n];
 for (int i = 0; i < n; i++)
 {
     Console.Write($"Введіть елемент {i + 1}: ");
     array[i] = Convert.ToDouble(Console.ReadLine());
 }
 double max = array.Max();
 int index = Array.IndexOf(array, max) + 1;
 Console.WriteLine($"Номер першого максимального елемента: {index}");

              // Завдання 3
      Console.WriteLine("\nЗавдання 3:");
      Console.Write("Введіть розмірність масиву: ");
      n = Convert.ToInt32(Console.ReadLine());
      array2D = new int[n, n];
      for (int i = 0; i < n; i++)
      {
          for (int j = 0; j < n; j++)
          {
              Console.Write($"Введіть елемент [{i + 1}, {j + 1}]: ");
              array2D[i, j] = Convert.ToInt32(Console.ReadLine());
          }
      }
      if (n % 2 == 0)
      {
          for (int i = 0; i < n; i += 2)
          {
              for (int j = 0; j < n; j++)
              {
                  int temp = array2D[j, i];
                  array2D[j, i] = array2D[j, i + 1];
                  array2D[j, i + 1] = temp;
              }
          }
      }
      Console.WriteLine("Масив після обміну стовпців:");
      for (int i = 0; i < n; i++)
      {
          for (int j = 0; j < n; j++)
          {
              Console.Write($"{array2D[i, j]} ");
          }
          Console.WriteLine();
      }
