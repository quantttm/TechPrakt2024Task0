Console.Write("Перше число: ");
int num1;
while (!int.TryParse(Console.ReadLine(), out num1))
{
    Console.Write("Введіть ціле число: ");
}

Console.Write("Друге число: ");
int num2;
while (!int.TryParse(Console.ReadLine(), out num2))
{
    Console.Write("Введіть ціле число: ");
}

Console.WriteLine("Сума чисел: " + (num1 + num2));