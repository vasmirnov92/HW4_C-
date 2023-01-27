// Задача 25: Напишите цикл, который принимает на вход 
// два числа (A и B) и возводит число A в натуральную 
// степень B. Реализовать функцию возведения в степень 
// самостоятельно!

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();

int stepen (int osnovanie, int pokazatel)
{
    int count = 0;
    int result = 1;
    while (count < pokazatel)
    {
        result = result * osnovanie;
        count++;
    }
    return result;
}

void main()
{
    Console.Write("Введите основание степени: ");
    int number1 = int.Parse(Console.ReadLine()!);
    Console.Write("Введите показатель степени: ");
    int number2 = int.Parse(Console.ReadLine()!);
    int result = stepen(number1, number2);
    Console.WriteLine($"{result}");
}

main();

