// На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран.
// Указание
// Метод строки ToCharArray() не использовать.
// Пример
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ] 

char[] StringOfChar(string str)
{
    char[] mas = new char[str.Length];

    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = str[i];
    }
    return mas;
}

void PrintMas(char[] arr)
{
    foreach (var item in arr)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}



string st = Console.ReadLine();
PrintMas(StringOfChar(st));