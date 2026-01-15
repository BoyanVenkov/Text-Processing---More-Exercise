int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string text = Console.ReadLine();

    int nameStart = text.IndexOf('@') + 1;
    int nameEnd = text.IndexOf('|');
    string name = text.Substring(nameStart, nameEnd - nameStart);

    int ageStart = text.IndexOf('#') + 1;
    int ageEnd = text.IndexOf('*');
    string age = text.Substring(ageStart, ageEnd - ageStart);

    Console.WriteLine($"{name} is {age} years old.");
}