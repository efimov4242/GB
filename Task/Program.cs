/*
Задача. Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоеачальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
*/

string[] GetCreateArray()
{
	string[] array = new string[5];
	int number = 1;
	for (int i = 0; i < array.Length; i++)
	{
		Console.WriteLine("Введите строку: " + number);
		array[i] = Console.ReadLine();
		number++;
	}
	return array;
}

void PrintChar(string[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		if((array[i].Length) <= 3)
		Console.Write(array[i] + " ");
	}
}

PrintChar(GetCreateArray());