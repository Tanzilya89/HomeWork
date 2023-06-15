// // Напишите программу, которая принимает на вход три числа 
//и выдаёт максимальное из этих чисел


Console.Write("Введите первое число из трех: ");
string inputedString1 = Console.ReadLine();
int a = Convert.ToInt32(inputedString1);
Console.Write("Введите второе число из трех: ");
string inputedString2 = Console.ReadLine();
int b= Convert.ToInt32(inputedString2);
Console.Write("Введите третье число из трех: ");
string inputedString3 = Console.ReadLine();
int c = Convert.ToInt32(inputedString3);

int max = a; 

if (b > max)
{
  max = b;
}
if (c > max)
{
  max = c;
}
Console.WriteLine($"Максимальное число {max}.");