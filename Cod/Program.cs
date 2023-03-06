// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
//длина которых меньше либо равна трём символам. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами

// Примеры результатов работы программы:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

string[] array1 = new string[5] { "123", "1234", "1567", "-2", "computer science" };
string[] array2 = new string[array1.Length];

void FillArraу(string[] array1, string[] array2)
{
  int count = 0;
  for (int i = 0; i < array1.Length; i++)
  {
    if (array1[i].Length <= 3)
    {
      array2[count] = array1[i];
      count++;
    }
  }
}

void PrintArray(string[] array)
{
  System.Console.Write("[");
  for (int i = 0; i < array.Length; i++)
  System.Console.Write($"{array[i]},");
  System.Console.Write($"{array[array.Length - 1]}]");
}

FillArraу(array1, array2);
PrintArray(array2);
