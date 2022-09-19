// ИТОГОВАЯ ПРОВЕРОЧНАЯ РАБОТА

string [] text1 = 
  {"фон", "Африка", "пример", "156","вот","Сон","ехать","17567",
   "дом","он", "здесь","так", "визит", "птица", "7866", "абрикос",
   "мех", "черника", "КодНеполучается", "как", "?"};

Console.WriteLine($"Размер заданного массива: " +$"{text1.Length}");

void FillArray(string[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        if (text1[index].Length <=3)
        collection[index]= text1[index];
        index++;
    }
}
void PrintArray(string[] col)
{
  int count = col.Length;
  int position = 0;
  while (position < count)
  {
    //if(col[position].Length <=3)
    Console.Write(col[position] +", ");
    position++;
  }
}

int size = 0;
for (int i = 0; i < text1.Length; i++)
{
if (text1[i].Length <= 3)
   {
    size = size+1;
   }
}
Console.WriteLine("Размер для нового массива из слов меньше либо");
Console.WriteLine("равно 3 символам составляет: " +$"{size}");

Console.WriteLine("Задан такой массив");
PrintArray(text1);

Console.WriteLine();
/*string[] newtext = new string[size];

void ChangeArray(string[] col)
{
  int count = col.Length;
  int position = 0;
  while (position < count)
  {
    if(col[position].Length <=3)
    Console.Write(col[position] +", ");
    position++;
  }
}



Console.WriteLine("Преобразуем в такой массив из строк <=3:");
FillArray(newtext);
PrintArray(newtext);
Console.WriteLine();*/


