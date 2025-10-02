// switch expression
char ConvertPointsToGrade(int points)
{
    return points switch
    {
        10 or 9 => 'A',
        8 or 7 or 6 => 'B',
        5 or 4 or 3 => 'C',
        2 or 1 => 'D',
        0 => 'E',
        _ => '!'
    };
}

Console.WriteLine("Hello, World!");

// do - while
string word;
do
{
    Console.WriteLine("Enter a word longer than 10 letters");
    word = Console.ReadLine();
}
while (word.Length <= 10);
    Console.WriteLine("The loop is finished");
    Console.ReadKey();


// while
string word2 = "12345";
while (word2.Length >= 3)
{
    Console.WriteLine("Enter a word longer than 10 letters");
    word2 = Console.ReadLine();
}


// for 
for (int i = 0; i < 5; i += 2)
{
    Console.WriteLine("Loop run:" + i);
}

Console.WriteLine("For loop is finished");
Console.ReadKey();


// break
for (int i = 0; i < 100; i++)
{
    Console.WriteLine("i is:" + i);
    if (i > 25)
    {
        break;
    }
}

// continue
for (int i = 0; i < 20; i++)
{
    if (i % 3 == 0)
    {
        continue;
    }
    Console.WriteLine("i:" + i);
}

Console.WriteLine("For loop is finished");
Console.ReadKey();

// array
string[] words = new[] { "one", "two", "three", "four" };

foreach (var word in words)
{
    Console.WriteLine(word);
}

// list
List<string> words2 = new List<string>();
Console.WriteLine("Count of elements is :" + words2.Count);

words2.Add("HELLO");
Console.WriteLine("Count of elements is :" + words2.Count);

var words3 = new List<string> { "one", "two" };

words3.IndexOf("one");
words3.IndexOf("seven"); // returns -1

Console.WriteLine("Contains 'five'?;" + words3.Contains("five"));
Console.WriteLine("Removing an item");

words3.Remove("twenty");
words3.RemoveAt(0);

foreach (var word in words3)
{
    Console.WriteLine(word);
}

Console.ReadKey();

words3.Clear();

// out
var numbers = new[] { 10, -8, 2, 12, -17 };
var onlyPositive = GetOnlyPositive(numbers, out int nonPositiveCount);

foreach (var num in onlyPositive)
{
    Console.WriteLine(num);
}
Console.WriteLine("Count of non positive:", nonPositiveCount);

List<int> GetOnlyPositive(int[] numbers, out int countOfNonPositive)
{
    countOfNonPositive = 0;
    var result = new List<int>();

    foreach (var num in numbers)
    {
        if (num > 0)
        {
            result.Add(num);
        }
        else
        {
            countOfNonPositive++;
        }
    }
    return result;
}

Console.ReadKey();


