// Задача №2

Console.Clear();

Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    Console.WriteLine(numberA);
}
else{
    Console.WriteLine(numberB);
}

// Задача №4

Console.Clear();

Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число число: ");
int numberC = Convert.ToInt32(Console.ReadLine());

if(numberA > numberB & numberA > numberC)
{
    Console.WriteLine(numberA);
}
else if(numberB > numberA & numberB > numberC)
{
    Console.WriteLine(numberB);
}
else{
    Console.WriteLine(numberC);
}

// Задача №6

Console.Clear();

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number % 2 == 0)
{
    Console.WriteLine("Число четное ");
}
else
{
    Console.WriteLine("Число не четное");
}


// Задача №8

Console.Clear();

Console.Write("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int count = 1;

while (count < numberA)
{
    count++;
    if(count % 2 == 0)
    {
        Console.WriteLine(count);
    }
    
}
