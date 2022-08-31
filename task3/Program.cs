
Console.Write("Введите год: ");
int year = int.Parse(Console.ReadLine()?? "0");
int y = year;
int a = 0;
int b = 0;
int c = 0;
int d = 0;
while(a == b | b == c | c == d | a == c | a == d | b == d)
{
    y = y+1;
    a = y / 1000;
    b = y / 100 % 10;
    c = y / 10 % 10;
    d = y % 10;
}
Console.WriteLine(y);

