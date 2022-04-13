int [] array = {12, 31, 24, 2, 4, 52, 61, 17, 56};
int find = 61;
int n = array.Length;
int i = 0;

while(i < n){
    if (array[i] == find){
    Console.WriteLine(i);
    i++;
    }
}