Console.Write("Введите расстояние до друга: ");
int s = int.Parse(Console.ReadLine() ?? "0");
int steps = 0;
if (s % 5 > 0)
{
    steps = (s / 5) + 1;
}
else
{
    steps = s / 5;
}
Console.WriteLine($"{steps}");