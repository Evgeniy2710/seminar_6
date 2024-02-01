// public class Task3
// {
// public static void Main(string[] args)
// {
// // Входная строка для проверки
// string input = "шалаш";
// // Вызов метода для проверки, является ли строка палиндромомbool isPalindrome = IsPalindrome(input);
// // Вывод результата
// Console.WriteLine(isPalindrome ? "Да" : "Нет");
// }
// // Метод для проверки, является ли строка палиндромомpublic static bool IsPalindrome(string str)
// {
// // Нормализация строки путем удаления не буквенно-цифровыхсимволов и приведения к нижнему регистру
// string normalized = new
// string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();
// // Сравнение строки с ее перевернутым вариантом
// return normalized.SequenceEqual(normalized.Reverse());
// }
// }
    Console.WriteLine("Введите слово:");

    string st = Console.ReadLine();
    char[] mas = new char[st.Length];

    for(int i = 0; i < mas.Length; i++){
        mas[i] = st[i];
    }

    for (int i = 0; i < mas.Length/2; i++){
        if(mas[i] == mas[mas.Length - 1])
        {
            Console.WriteLine("Слово является палиндромом");
        }
    }



