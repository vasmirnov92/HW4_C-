// Задача 27: Напишите функцию и запустите ее, которая 
// принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();

int summ (int chislo)
{

    int result = 0;
    while (chislo > 0)
    {
        result = chislo%10 + result;
        chislo = chislo/10;
    }
    return result;
}


void main()
{
    Console.Write("Введите число: ");
    int number = int.Parse(Console.ReadLine()!);
    int result = summ(number);
    Console.WriteLine($"Сумма цифр в числе = {result}");
}

main();