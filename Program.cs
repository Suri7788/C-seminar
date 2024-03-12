

using System;

public class Tasks {
    static public void Main(string[] args) {
        // Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.
        char[,] charArray = new char[,] { { 'A', 'b', 'C' }, { 'D', 'e', 'D' } };
        string result = "";
        for (int i = 0; i < charArray.GetLength(0); i++) {
            for (int j = 0; j < charArray.GetLongLength(1); j++) {
                result += charArray[i, j];
            }
        }
        Console.WriteLine(result);
        //Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные
        result = result.ToLower();
        Console.WriteLine(result);

        // Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.
        string normalized = new string(result.Where(char.IsLetterOrDigit).ToArray()).ToLower();
        bool isPalidrom = normalized.SequenceEqual(normalized.Reverse());
        result = "нет, строка не является палиндромом";
        if (isPalidrom) {
             result = "да, строка является палиндромом";
        }

        Console.WriteLine(result);
    }
}