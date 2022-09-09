// Напишите программу, которая из имеющегося массива строк формирует масив из строк, длина которых
// меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами


void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
     if (i < array.Length - 1) Console.Write("\"" + array[i] + "\", ");
     else Console.Write("\"" + array[i] + "\"");
    }
    Console.Write("]");
}

Console.Clear();   
Console.Write("Введите количество строк в массиве: ");
int sourceCount = Convert.ToInt32(Console.ReadLine());
string[] sourceArray = new string[sourceCount];

int destinationCount = 0;
int minStringLength = 3;
for (int i = 0; i < sourceCount; i++)
{
    Console.Write($"Введите {i+1}-ую строку: ");
    sourceArray[i] = Console.ReadLine();
    if (sourceArray[i].Length <= minStringLength) destinationCount++;
}


string[] destinationArray = new string[destinationCount];
destinationCount = 0;

for (int i = 0; i < sourceCount; i++)
{
    if (sourceArray[i].Length <= minStringLength) 
        destinationArray[destinationCount++] = sourceArray[i];    
}

PrintArray(sourceArray);
Console.Write(" -> ");
PrintArray(destinationArray);
Console.WriteLine();


