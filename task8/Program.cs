/* Задача 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8 */

Console.WriteLine("Введите положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int i = num;
if(i % 2 == 0)
    while (i > 0)
{
    Console.Write(i + ", ");
    i = i -2;
}
else if(i % 2 !=0)
    i--;
    while (i > 0)
{
    Console.Write(i + ", ");
    i = i -2;
}

    
    



