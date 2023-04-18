/* Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

456 -> 46
782 -> 72
918 -> 98
*/

int GetRandomInt(int arg1, int arg2)
{
    return new Random().Next(arg1, arg2 + 1);
    
}

int GetDigit13(int number)
{
    int digit3 = (number % 10);
    int digit1 = (number / 100)*10;

    int resolt = digit1 + digit3;
    return resolt;
}


int number = GetRandomInt(100, 999);
Console.WriteLine(number);
int maxDigit = GetDigit13(number);
Console.WriteLine(maxDigit);
