Dictionary<string, char> morse = new Dictionary<string, char>
        {
            {".-", 'A'},   {"-...", 'B'}, {"-.-.", 'C'}, {"-..", 'D'},
            {".", 'E'},    {"..-.", 'F'}, {"--.", 'G'},  {"....", 'H'},
            {"..", 'I'},   {".---", 'J'}, {"-.-", 'K'},  {".-..", 'L'},
            {"--", 'M'},   {"-.", 'N'},   {"---", 'O'},  {".--.", 'P'},
            {"--.-", 'Q'}, {".-.", 'R'},  {"...", 'S'},  {"-", 'T'},
            {"..-", 'U'},  {"...-", 'V'}, {".--", 'W'},  {"-..-", 'X'},
            {"-.--", 'Y'}, {"--..", 'Z'}
        };

string input = Console.ReadLine();

string[] words = input.Split(" | ", StringSplitOptions.RemoveEmptyEntries);
List<string> result = new List<string>();

foreach (string word in words)
{
    string translatedWord = string.Concat(
        word.Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(code => morse[code])
    );

    result.Add(translatedWord);
}

Console.WriteLine(string.Join(" ", result));