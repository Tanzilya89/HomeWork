// // Напишите программу, которая на вход принимает два числа 
//и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7


Console.Write("Введите первое число: ");
string inputedString1 = Console.ReadLine();
int a = Convert.ToInt32(inputedString1);

Console.Write("Введите второе число: ");
string inputedString2 = Console.ReadLine();
int b = Convert.ToInt32(inputedString2);

if ( a > b)
{
  Console.WriteLine($"{a} больше."); 
  Console.WriteLine($"{b} меньше.");  
}
else
{
  Console.WriteLine($"{a} и {b} равны.");     
}
  