int [] array = {13, 22, 53, 14, 35, 622, 27, 38, 39};
int Max(int arg1, int arg2, int arg3)
{
    int max = arg1;
    if (arg2 > max) max = arg2;
    if (arg3 > max) max = arg3;
    return max;
}

int result1 = Max(array[0], array[1], array[2]);
int result2 = Max(array[3], array[4], array[5]);
int result3 = Max(array[6], array[7], array[8]);
int result = Max(result1, result2, result3);

Console.WriteLine(result);