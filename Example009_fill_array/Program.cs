void FillArray(int[] collection){
    int length = collection.Length;
    int i = 0;
    while(i < length){
        collection[i] = new Random().Next(1, 10);
        i++;
    }
}
void PrintArray(int[] col){
    int count = col.Length;
    int i = 0;
    while(i < count){
        Console.WriteLine(col[i]);
        i++;
    }
}
void FindIndex(int[] collection, int find){
    int count = collection.Length;
    int position = -1;
    int i = 0;
    while(i < count){
        if(collection[i] == find){
            position = i;
            Console.WriteLine($"Число {find} найдено на позиции {i}");
            Console.WriteLine();
            break;
        }
        i++;    
    }
    if(position == -1){
        Console.WriteLine($"Число {find} не найдено");
    }
}
int[] array = new int[10];
FillArray(array);
PrintArray(array);
FindIndex(array, 5);
