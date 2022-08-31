Console.Write("Введите стоимость 1-го банана: ");
int k = int.Parse(Console.ReadLine() ?? "00");

Console.Write("Введите количество денег: ");
int n = int.Parse(Console.ReadLine() ?? "00");

Console.Write("Введите необходимое количество бананов: ");
int w = int.Parse(Console.ReadLine() ?? "00");
int i = 1;
int sum = 0;

while (i <= w)
{ 
    sum = sum + (i * k);
    i++;
}
int credit = sum - n;
if (credit<=0) Console.WriteLine($"Необходимо занять {credit = 0}");

else Console.WriteLine($"Необходимо занять {credit}");