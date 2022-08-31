Console.Write("Введите число: ");
int luckyNumber = int.Parse(Console.ReadLine() ?? "0");
int count = 0;
while (luckyNumber > 0)
{
    if(luckyNumber%10 == 4 | luckyNumber%10 == 7)
    {
        count++;
    }
luckyNumber=luckyNumber/10;
}
if (count == 4 | count == 7) Console.Write("YES");

else ("NO");