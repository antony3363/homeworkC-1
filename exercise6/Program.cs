//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

System.Console.WriteLine("Введите число");
int numbera = int.Parse(Console.ReadLine()!);
int a = numbera % 2;
if (a == 0)
{
   System.Console.WriteLine("да"); 
}
else
{
    System.Console.WriteLine("нет");
}

