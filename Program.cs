﻿Console.WriteLine("Здравствуйте. Введите элементы через пробел");
string element = Console.ReadLine();
string[] elements = element.Split(" ");
int count = 0;
int tooMuch = 4;
for (int i = 0; i < elements.Length; i++)
{
    if (elements[i].Length < tooMuch) count++;
}

string[] results = new string[count];
int j = 0;

Console.WriteLine("Элементы, в которых не больше трёх символов:");
for (int i = 0; i < elements.Length; i++)
{

    if (elements[i].Length < tooMuch)
    {
        results[j] = elements[i];
        Console.Write($"{results[j]} ");
        j++;
    }
}