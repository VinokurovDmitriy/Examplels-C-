Console.Clear();
int x1 = 40, y1 = 1, x2  =  1, y2 = 80, x3 = 80, y3 = 80;
Console.SetCursorPosition(x1, y1);
Console.WriteLine("+");
Console.SetCursorPosition(x2, y2);
Console.Write("+");
Console.SetCursorPosition(x3, y3);
Console.Write("+");
int count = 0;
int x = x1, y = y2;
while(count < 10000)
{
    int what = new Random().Next(0, 3);
    if (what == 0){
        x = (x + x1) / 2;
        y = (y1 + y) / 2;
    }
    if (what == 1){
        x = (x2 + x) / 2;
        y = (y2 + y) / 2;
    }
    if (what == 2){
        x = (x3 + x) / 2;
        y = (y3 + y) / 2;
    }
    Console.SetCursorPosition(x, y);
    Console.Write("+");
    count++;
}