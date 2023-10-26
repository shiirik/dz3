using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = "Это строка с некоторыми словами, которые содержат букву 'a'.";

        // Используем регулярное выражение для поиска слов с буквой 'a'
        string pattern = @"\b\w*?a\w*\b";
        string result = Regex.Replace(input, pattern, "");

        Console.WriteLine("Исходная строка: " + input);
        Console.WriteLine("Строка после удаления слов с 'a': " + result);
    }
}

