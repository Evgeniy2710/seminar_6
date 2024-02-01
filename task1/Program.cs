// Задайте массив символов (тип char []). Создайте строку из
// символов этого массива.
// Указание
// Конструктор строки вида string(char []) не использовать.
// Пример
// [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”

string CharOffString(char[]arr)
{
    string st = "";
    foreach (var item in arr)
    {
        st = st + item;
    }
    return st;
}

 char[] chars = new char[] {'a', 'b', 'c', 'd'};

Console.WriteLine(CharOffString(chars));
