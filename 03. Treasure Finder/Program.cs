using System.Text;

int[] key = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

string input;
while ((input = Console.ReadLine()) != "find")
{
    StringBuilder decrypted = new StringBuilder();

    for (int i = 0; i < input.Length; i++)
    {
        int keyValue = key[i % key.Length];
        char decryptedChar = (char)(input[i] - keyValue);
        decrypted.Append(decryptedChar);
    }

    string result = decrypted.ToString();

    int typeStart = result.IndexOf('&') + 1;
    int typeEnd = result.IndexOf('&', typeStart);
    string type = result.Substring(typeStart, typeEnd - typeStart);

    int coordStart = result.IndexOf('<') + 1;
    int coordEnd = result.IndexOf('>');
    string coordinates = result.Substring(coordStart, coordEnd - coordStart);

    Console.WriteLine($"Found {type} at {coordinates}");
}