// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AckermannFunction(int firstNumber, int secondNumber)
{
    if (firstNumber == 0)
        return secondNumber + 1;
    else if (firstNumber > 0 && secondNumber == 0)
        return AckermannFunction(firstNumber - 1, 1);
    else
        return AckermannFunction(firstNumber - 1, AckermannFunction(firstNumber, secondNumber - 1));
}


Console.Write("Enter the first number (m): ");
int firstSuperNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the second number (n): ");
int secondSuperNumber = Convert.ToInt32(Console.ReadLine());

int ackermannResult = AckermannFunction(firstSuperNumber, secondSuperNumber);

Console.WriteLine($"A({firstSuperNumber},{secondSuperNumber}) = {ackermannResult}");