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