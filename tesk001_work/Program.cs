/*Задача: Написать программу которая выводит случайное число из отрезка (чисел) [10, 99] и показывает наибольшую цифру числа .

например:
8→ 8

12→2

85→8
*/
Console.Clear();
int GetRandomInt()
{
    // int random = new Random().Next(10, 100);
    // return random;
    return new Random().Next(10, 100);
}
Console.WriteLine(GetRandomInt());
Console.WriteLine(GetRandomInt());
Console.WriteLine(GetRandomInt());
Console.WriteLine(GetRandomInt());