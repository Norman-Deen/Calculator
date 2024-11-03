PrintMessage("Calculator app 1.6");

int firstNumber = ReadNumber("First Number: ");
int secondNumber = ReadNumber("Second Number: ");
char operation = ReadOperation("Operation: ", firstNumber, secondNumber);

var result = Calculate(firstNumber, secondNumber, operation);
Console.WriteLine($"{firstNumber} {operation} {secondNumber} = {result}");

void PrintMessage(string message)
{
    Console.WriteLine($"{message}\n\n");
}

int ReadNumber(string message)
{
    Console.Write(message);
    bool isConverted = int.TryParse(Console.ReadLine(), out int number);
    if (!isConverted)
    {
        Console.WriteLine("\nInvalid input. Try again:\n");
        return ReadNumber(message);
    }
    Console.Clear();
    return number;
}

char ReadOperation(string message, int firstNumber = 0, int secondNumber = 0)
{
    Console.Write(message);
    bool isConverted = char.TryParse(Console.ReadLine(), out char operation);
    if (!isConverted || !"+-*/".Contains(operation) || (operation == '/' && secondNumber == 0))
    {
        Console.WriteLine("\nInvalid input. Try again:\n");
        return ReadOperation(message);
    }
    Console.Clear();
    return operation;
}

double Calculate(int firstNumber, int secondNumber, char operation)
{
    double calculation = 0;
    switch (operation)
    {
        case '+':
            calculation = firstNumber + secondNumber;
            break;

        case '-':
            calculation = firstNumber - secondNumber;
            break;

        case '*':
            calculation = firstNumber * secondNumber;
            break;

        case '/':
            calculation = (double)firstNumber / secondNumber;
            break;

        default:
            Console.WriteLine("Invalid operation.");
            break;
    }

    return calculation;
}
