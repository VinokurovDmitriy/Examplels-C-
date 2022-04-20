// сортируем массив с цифрами
void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

int[] array = { 2, 6, 1, 8, 5, 3, 4, 9, 0, 7, 1, 3 };
printArray(array);
for (int i = 0; i < array.Length -1; i++)
{
    int minPosition = i;
    for (int j = i + 1; j < array.Length; j++)
    {
        if (array[j] < array[minPosition])  minPosition = j;
    }
    int temp = array[i];
    array[i] = array[minPosition];
    array[minPosition] = temp;
}

printArray(array);