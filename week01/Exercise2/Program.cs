Console.Write("Enter your grade percentage: ");
int grade = int.Parse(Console.ReadLine());

string letter;

if (grade >= 90)
{
    letter = "A";
}
else if (grade >= 80)
{
    letter = "B";
}
else if (grade >= 70)
{
    letter = "C";
}
else if (grade >= 60)
{
    letter = "D";
}
else
{
    letter = "F";
}

string sign = "";

int lastDigit = grade % 10;

if (letter != "A" && letter != "F")
{
    if (lastDigit >= 7)
    {
        sign = "+";
    }
    else if (lastDigit < 3)
    {
        sign = "-";
    }
}

if (letter == "A")
{
    if (lastDigit < 3)
    {
        sign = "-";
    }
}
else if (letter == "F")
{
    sign = "";
}

Console.WriteLine($"Your grade is: {letter}{sign}");

if (grade >= 70)
{
    Console.WriteLine("Congratulations! You passed the course.");
}
else
{
    Console.WriteLine("Keep working hard and you can do better next time.");
}