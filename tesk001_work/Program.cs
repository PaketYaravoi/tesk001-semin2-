/*Задача: Написать программу которая выводит случайное число из отрезка (чисел) [10, 99] и показывает наибольшую цифру числа .

например:
8→ 8

12→2

85→8
*/
Console.Clear();
int GetRandomInt(int minValue, int maxValue )
{
    //int random = new Random().Next(minValue, maxValue + 1);
    //return random;
    return new Random().Next(minValue, maxValue + 1 );
}

int GetMaxTwoDigit(int number)
{
    int digit1 = number % 10;
    int digit2 = number / 10;
    int max = digit1;
    if(digit2 > max)
{
        max = digit2;
}
return max;
}


int number = GetRandomInt(10, 99);
Console.WriteLine(number);
int maxDigit = GetMaxTwoDigit(number);
Console.WriteLine(maxDigit);


