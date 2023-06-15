// Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.


Console.Write("Введите число:");
string inputedString = Console.ReadLine();
int N = Convert.ToInt32(inputedString);
 
Console.WriteLine($"Чётные числа от 1 до {N}:");

int i = 2;
while (i <= N);
{
  Console.WriteLine(i);
  i +=2;  
}

