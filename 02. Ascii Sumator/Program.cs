char firstChar = char.Parse(Console.ReadLine());
char secondChar = char.Parse(Console.ReadLine());
string text = Console.ReadLine();

int start = Math.Min(firstChar, secondChar);
int end = Math.Max(firstChar, secondChar);

int sum = 0;

foreach (char ch in text)
{
    if (ch > start && ch < end)
    {
        sum += ch;
    }
}

Console.WriteLine(sum);