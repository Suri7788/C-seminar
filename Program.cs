

using System;

public class Tasks {
    static public void Main(string[] args) {
        // Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.
        int num1 = 10;
        int num2 = 20;
        printNaturalNumbers(num1, num2);

        //Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
        printAkkerman(num1, num2);

        // Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
        int [] nums = {1, 2, 3, 4, 5, 6};
        printReverseArray(nums, nums.Length - 1);
    }

    public static void printNaturalNumbers(int m, int n)
    {
        if (m > n) {
            Console.WriteLine();
            return;
        }
        if (m % 2 == 0) {
            Console.Write($"{m};");
        }
        printNaturalNumbers(m + 1,n);
    }

    public static void printAkkerman(int m, int n)
    {
        Console.Write(Akkerman(m - 1, n));
        Console.WriteLine();
    }

    public static int Akkerman(int m, int n)
    {
        int res = m;
        if (m == n) {
            return 0;
        } else {
            m++;
            res = m + Akkerman(m, n);
            return res;
        }
    }
    public static void printReverseArray(int [] arr, int n) { 
      if (n > 0) { 
      	Console.Write($"{arr[n]};"); 
      	printReverseArray(arr, n - 1); 
      }  else {
        Console.WriteLine(arr[0]);
      } 
    } 
}