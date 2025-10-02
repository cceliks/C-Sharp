Console.WriteLine("Hello !");
Console.WriteLine("Input the first number:");
string firstAsText = Console.ReadLine();
int firstNumber = int.Parse(firstAsText);


Console.WriteLine("Input the second number:");
string secondAsText = Console.ReadLine();
int secondNumber = int.Parse(secondAsText);

Console.WriteLine("[A]ddition");
Console.WriteLine("[S]ubstraction");
Console.WriteLine("[M]ultiplication");
Console.WriteLine("Choose your operation:");

string op = Console.ReadLine();
int result = 0;
if (EqualsCaseInsensitive(op, "A"))
{
    result = firstNumber + secondNumber;
    printResult("+");
}
else if (EqualsCaseInsensitive(op, "S"))
{
    result = firstNumber - secondNumber;
    printResult("-");
}
else if (EqualsCaseInsensitive(op, "M"))
{
    result = firstNumber * secondNumber;
    printResult("*");
}
else
{
    Console.WriteLine("Invalid operation");
}

    Console.WriteLine("Press any key to close");
    Console.ReadKey();

void printResult(string op)
{
    Console.WriteLine($"{firstNumber} {op} {secondNumber} = {result}");
}

bool EqualsCaseInsensitive(string left, string right)
{
    return left.ToUpper() == right.ToUpper();
}

