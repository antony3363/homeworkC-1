//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

System.Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine()!);

int b = 1;

int c;

while (true)
{
    if(b>a ^ b==a)
    {
        break;
    }
    b+=1;
    c = b % 2;
    if (c == 0)
    {
        System.Console.WriteLine(b);
    }


}

