//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

System.Console.WriteLine("Введите первое число");
int numbera = int.Parse(Console.ReadLine()!);

System.Console.WriteLine("Введите второе число");
int numberb = int.Parse(Console.ReadLine()!);

System.Console.WriteLine("Введите третье число");
int numberc = int.Parse(Console.ReadLine()!);

int d = numbera;

if (numberb > d)
{
    d = numberb;
}
if (numberc > d)
{
   d = numberc; 
}
System.Console.WriteLine("max =" + d);
