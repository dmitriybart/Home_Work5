Console.Write("Введите ширину площади: ");
int n = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите длину площади: ");
int m = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите размер плитки: ");
int a = int.Parse(Console.ReadLine() ?? "0");
int x = 0;
int y = 0;
 if (n%a == 0) 
  {
    x = n / a;
  }
  else 
  {
    x = n / a;
    x++;
  }
  if (m%a == 0) 
  {
    y = m / a;
  }
  else {
    y = m / a;
    y++;
  }
Console.Write($"{x*y}");