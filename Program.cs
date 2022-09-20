// ИТОГОВАЯ ПРОВЕРОЧНАЯ РАБОТА

Console.Clear();

string [] ChangeArray(string[] array, int TheLongestWord)
{
    string [] changedArray = {};
    for (int i = 0; i <array.Length; i++)
    {
        if (array[i].Length <= TheLongestWord)
        {
            Array.Resize(ref changedArray, changedArray.Length+1);
            changedArray[changedArray.Length-1] = array[i];
        }
    }
    return changedArray;
}

void PrintArray(string[] array)
{
  int i = 0;
  while (i < array.Length)
  {
    Console.Write(array[i] +", ");
    i++;
  }
}

string [] text1 = 
  {"фон", "Африка", "пример", "156","вот","Сон","ехать","17567",
   "дом","он", "здесь","так", "визит", "птица", "7866", "абрикос",
   "мех", "черника", "КодНеполучается", "как", "?"};

Console.WriteLine("Задан такой массив строк:");
PrintArray(text1);
Console.WriteLine();

var action = ChangeArray(text1, 3);

Console.WriteLine("Преобразуем в такой массив из строк <= 3:");

PrintArray(action);
Console.WriteLine();
// результат: фон, 156, вот, Сон, дом, он, так, мех, как, ?,
