// // Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// 		// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// 		// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// 		// лучше обойтись исключительно массивами.
// 		// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// 		// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// 		// [“Russia”, “Denmark”, “Kazan”] → []
		
Console.Clear();
Console.Write($"Введи количество слов: ");
int m = Convert.ToInt32(Console.ReadLine());
string[] array1 = new string[m];

void InputWords(int m)
{
for (int i = 0; i < array1.Length; i++)
  {
    Console.Write($"Введи {i+1} слово: ");
    array1[i] = Console.ReadLine();
  }
}
		
string[] array2 = new string[array1.Length];
void SecondArrayWithIF(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

InputWords(m);
SecondArrayWithIF(array1, array2);
PrintArray(array2);
