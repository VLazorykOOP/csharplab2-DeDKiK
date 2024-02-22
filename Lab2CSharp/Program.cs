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
        //Завдання 4
        Console.WriteLine("\nЗавдання 4:");
        Console.Write("Введіть кількість рядків масиву: ");
        int n1 = Convert.ToInt32(Console.ReadLine());

        int[][] jaggedArray = new int[n][];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введіть кількість елементів в рядку {i + 1}: ");
            int m = Convert.ToInt32(Console.ReadLine());

            jaggedArray[i] = new int[m];

            for (int j = 0; j < m; j++)
            {
                Console.Write($"Введіть елемент {j + 1} в рядку {i + 1}: ");
                jaggedArray[i][j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        List<int> result = new List<int>();

        for (int i = 0; i < jaggedArray.Length; i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                if (jaggedArray[i][j] < 0)
                {
                    result.Add(j + 1); // Додаємо 1, оскільки індексація починається з 0
                    break;
                }
            }
        }

        // Виводимо результат
        Console.WriteLine("Номери перших від’ємних елементів в кожному рядку:");
        foreach (int index1 in result)
        {
            Console.WriteLine(index);
        }
    }
}
